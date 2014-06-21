﻿namespace kPrasat.SM
{
    partial class frmAuditLog
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.cboPriority = new kPrasat.UI.ComboBox(this.components);
            this.dtpFrom = new kPrasat.UI.DateTimePicker(this.components);
            this.dgvList = new kPrasat.UI.DataGridView();
            this.txtSearch = new kPrasat.UI.TextBox(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new kPrasat.UI.DateTimePicker(this.components);
            this.dtpTo = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cboType = new kPrasat.UI.ComboBox(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).BeginInit();
            this.SuspendLayout();
            // 
            // cboPriority
            // 
            this.cboPriority.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPriority.FormattingEnabled = true;
            this.cboPriority.Items.AddRange(new object[] {
            "[All]",
            "Information",
            "Caution",
            "Warning",
            "Error"});
            this.cboPriority.Location = new System.Drawing.Point(375, 12);
            this.cboPriority.Name = "cboPriority";
            this.cboPriority.Size = new System.Drawing.Size(118, 21);
            this.cboPriority.TabIndex = 8;
            this.cboPriority.TabOnEnter = true;
            // 
            // dtpFrom
            // 
            this.dtpFrom.CustomFormat = "ddd dd-MM-yy";
            this.dtpFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFrom.Location = new System.Drawing.Point(49, 12);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Size = new System.Drawing.Size(118, 21);
            this.dtpFrom.TabIndex = 4;
            this.dtpFrom.TabOnEnter = true;
            // 
            // dgvList
            // 
            this.dgvList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvList.BackgroundColor = System.Drawing.Color.White;
            this.dgvList.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvList.Column1 = null;
            this.dgvList.Column2 = null;
            this.dgvList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvList.Location = new System.Drawing.Point(12, 39);
            this.dgvList.Name = "dgvList";
            this.dgvList.Size = new System.Drawing.Size(911, 386);
            this.dgvList.TabIndex = 11;
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.Location = new System.Drawing.Point(712, 12);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(130, 21);
            this.txtSearch.TabIndex = 1;
            this.txtSearch.TabOnEnter = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "From";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CustomFormat = "ddd dd-MM-yy";
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker2.Location = new System.Drawing.Point(201, 12);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(118, 21);
            this.dateTimePicker2.TabIndex = 6;
            this.dateTimePicker2.TabOnEnter = true;
            // 
            // dtpTo
            // 
            this.dtpTo.AutoSize = true;
            this.dtpTo.Location = new System.Drawing.Point(176, 15);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.Size = new System.Drawing.Size(19, 13);
            this.dtpTo.TabIndex = 5;
            this.dtpTo.Text = "To";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(666, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Search";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(328, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Priority";
            // 
            // cboType
            // 
            this.cboType.FormattingEnabled = true;
            this.cboType.Location = new System.Drawing.Point(539, 12);
            this.cboType.Name = "cboType";
            this.cboType.Size = new System.Drawing.Size(118, 21);
            this.cboType.TabIndex = 10;
            this.cboType.TabOnEnter = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(502, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Type";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefresh.Location = new System.Drawing.Point(848, 11);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 2;
            this.btnRefresh.Text = "&Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            // 
            // frmAuditLog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(935, 437);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtpTo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.dgvList);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dtpFrom);
            this.Controls.Add(this.cboType);
            this.Controls.Add(this.cboPriority);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinimumSize = new System.Drawing.Size(951, 476);
            this.Name = "frmAuditLog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Audit Log";
            this.Load += new System.EventHandler(this.frmAuditLog_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UI.ComboBox cboPriority;
        private UI.DateTimePicker dtpFrom;
        private UI.DataGridView dgvList;
        private UI.TextBox txtSearch;
        private System.Windows.Forms.Label label1;
        private UI.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label dtpTo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private UI.ComboBox cboType;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnRefresh;
    }
}