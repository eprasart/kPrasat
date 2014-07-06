﻿using System;
using System.Collections.Generic;
using ServiceStack.OrmLite;
using ServiceStack.DataAnnotations;
using System.Linq;
using System.Data;
using Npgsql;
using kPrasat.SYS;
using System.Windows.Forms;

namespace kPrasat.SM
{
    [Alias("SmUser")]
    class User
    {
        [AutoIncrement]
        public long Id { get; set; }
        [Required]
        public string Username { get; set; }
        public string FullName { get; set; }
        public string Pwd { get; set; }
        public DateTime? PwdChangeOn { get; set; }
        public bool PwdChangeForce { get; set; }
        public int TimeLevel { get; set; }
        public DateTime? StartOn { get; set; }
        public DateTime? EndOn { get; set; }
        public int Success { get; set; }
        public int Fail { get; set; }
        public bool Locked { get; set; }
        public string Right { get; set; }
        public string SecurityNo { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Note { get; set; }
        public String Status { get; set; }
        public string LockBy { get; set; }
        public DateTime? LockAt { get; set; }
        public string InsertBy { get; set; }
        [Default(typeof(DateTime), "now()")]
        public DateTime? InsertAt { get; set; }
        public string ChangeBy { get; set; }
        public DateTime? ChangeAt { get; set; }
        public static string Module = "User List";  // Module name for logging
    }

    static class UserFacade
    {
        public static List<User> Select(string filter = "")
        {
            SqlExpression<User> e = OrmLiteConfig.DialectProvider.SqlExpression<User>();
            e.Where(q => q.Status == Type.RecordStatus_Active && (q.Username.Contains(filter) || q.FullName.Contains(filter)))
                .OrderBy(q => q.Username);
            //System.Windows.Forms.MessageBox.Show(e.SelectExpression + "\n" + e.WhereExpression);           
            return Database.Connection.Select<User>(e);
        }

        public static DataTable GetDataTable(string filter = "", string status = "")
        {
            var sql = "select id, username, full_name, phone, email from sm_user where 1 = 1";
            if (status.Length > 0)
                sql += " and status = '" + status + "'";
            if (filter.Length > 0)
                sql += " and (username ~* :filter or full_name ~* :filter or phone ~* :filter or email ~* :filter or note ~* :filter)";
            sql += "\norder by username";
            var cmd = new NpgsqlCommand(sql, new NpgsqlConnection(Database.ConnectionString));
            if (filter.Length > 0)
                cmd.Parameters.AddWithValue(":filter", filter);
            var da = new NpgsqlDataAdapter(cmd);
            var dt = new DataTable();
            try
            {
                da.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while loading data.\n" + ex.Message, "Location", MessageBoxButtons.OK, MessageBoxIcon.Error);
                SYS.ErrorLogFacade.Log(ex);
            }
            return dt;
        }

        public static long Save(User m)
        {
            DateTime? ts = Database.GetCurrentTimeStamp();
            if (m.Id == 0)
            {
                m.Status = Type.RecordStatus_Active;
                m.InsertBy = App.session.Username;
                m.InsertAt = ts;
                string sqlPwd = "select crypt('" + m.Pwd + "', gen_salt('bf'))";    // Blowfish algorithm
                m.Pwd = Database.ExcuteString(sqlPwd);
                m.Id = Database.Connection.Insert(m, true); // New inserted sequence
            }
            else
            {
                m.ChangeBy = App.session.Username;
                m.ChangeAt = ts;

                Database.Connection.UpdateOnly(m, p => new { p.Username, p.FullName, p.StartOn, p.EndOn, p.Phone, p.Email, p.Note, p.ChangeBy, p.ChangeAt },
                    p => p.Id == m.Id);
                // If record is locked then unlock
                if (IsLocked(m.Id)) ReleaseLock(m.Id);
            }
            return m.Id;
        }

        public static User Select(long Id)
        {
            return Database.Connection.SingleById<User>(Id);
        }

        public static void SetStatus(long Id, string s)
        {
            DateTime? ts = Database.GetCurrentTimeStamp();
            Database.Connection.UpdateOnly(new User { Status = s, ChangeBy = App.session.Username, ChangeAt = ts }, p => new { p.Status, p.ChangeBy, p.ChangeAt }, p => p.Id == Id);
        }

        public static bool IsLocked(long Id)
        {
            return Database.Connection.Exists<User>("Id = @Id and Lock_By = @LockBy", new { Id = Id, LockBy = App.session.Username });
        }

        public static LockInfo GetLockInfo(long Id)
        {
            var m = Select(Id);
            var l = new LockInfo();
            l.Id = Id;
            l.LockBy = m.LockBy;
            l.LockAt = m.LockAt;
            return l;
        }

        public static void Lock(long Id)
        {
            DateTime ts = Database.GetCurrentTimeStamp();
            Database.Connection.UpdateOnly(new User { LockBy = App.session.Username, LockAt = ts }, p => new { p.LockBy, p.LockAt }, p => p.Id == Id);
        }

        public static void ReleaseLock(long Id)
        {
            if (Id == 0) return;
            DateTime ts = Database.GetCurrentTimeStamp();
            Database.Connection.UpdateOnly(new User { LockBy = null }, p => p.LockBy, p => p.Id == Id);
        }

        public static bool IsExist(string Username, long Id = 0)
        {
            return Database.Connection.Exists<User>("Id <> @Id and Username = @Username", new { Id = Id, Username = Username });
        }

        public static void UpdatePwd(User m)
        {
            string sqlPwd = "select crypt('" + m.Pwd + "', gen_salt('bf'))";
            m.Pwd = Database.ExcuteString(sqlPwd);
            Database.Connection.UpdateOnly(m, p => new { p.Pwd }, p => p.Id == m.Id);
        }
    }

    [Alias("SmFunction")]
    class Function
    {
        [AutoIncrement]
        public long Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string Code { get; set; }
        public string Type { get; set; }
        public string Right { get; set; }
        public string Note { get; set; }
        public String Status { get; set; }
        public string LockBy { get; set; }
        public DateTime? LockAt { get; set; }
        public string InsertBy { get; set; }
        [Default(typeof(DateTime), "now()")]
        public DateTime? InsertAt { get; set; }
        public string ChangeBy { get; set; }
        public DateTime? ChangeAt { get; set; }
    }

    [Alias("SmRole")]
    class Role
    {
        [AutoIncrement]
        public long Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string Note { get; set; }
        public String Status { get; set; }
        public string LockBy { get; set; }
        public DateTime? LockAt { get; set; }
        public string InsertBy { get; set; }
        [Default(typeof(DateTime), "now()")]
        public DateTime? InsertAt { get; set; }
        public string ChangeBy { get; set; }
        public DateTime? ChangeAt { get; set; }
    }

    [Alias("SmRoleFunction")]
    class RoleFunction
    {
        [AutoIncrement]
        public long Id { get; set; }
        [Required]
        public long RoleId { get; set; }
        public long FunctionId { get; set; }
        public string Right { get; set; }        
        public String Status { get; set; }
        public string LockBy { get; set; }
        public DateTime? LockAt { get; set; }
        public string InsertBy { get; set; }
        [Default(typeof(DateTime), "now()")]
        public DateTime? InsertAt { get; set; }
        public string ChangeBy { get; set; }
        public DateTime? ChangeAt { get; set; }
    }

    [Alias("SmUserFunction")]
    class UserFunction
    {
        [AutoIncrement]
        public long Id { get; set; }
        [Required]
        public long UserId { get; set; }
        public long FunctionId { get; set; }        
        public String Status { get; set; }
        public string LockBy { get; set; }
        public DateTime? LockAt { get; set; }
        public string InsertBy { get; set; }
        [Default(typeof(DateTime), "now()")]
        public DateTime? InsertAt { get; set; }
        public string ChangeBy { get; set; }
        public DateTime? ChangeAt { get; set; }
    }

    [Alias("SmUserRole")]
    class UserRole
    {
        [AutoIncrement]
        public long Id { get; set; }
        public long UserId { get; set; }
        public long RoleId { get; set; }        
        public String Status { get; set; }
        public string LockBy { get; set; }
        public DateTime? LockAt { get; set; }
        public string InsertBy { get; set; }
        [Default(typeof(DateTime), "now()")]
        public DateTime? InsertAt { get; set; }
        public string ChangeBy { get; set; }
        public DateTime? ChangeAt { get; set; }
    }
}