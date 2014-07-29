﻿namespace kBit.ERP.IC
{
    partial class frmLocationList
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnNew = new System.Windows.Forms.ToolStripButton();
            this.btnCopy = new System.Windows.Forms.ToolStripButton();
            this.btnUnlock = new System.Windows.Forms.ToolStripButton();
            this.btnSave = new System.Windows.Forms.ToolStripButton();
            this.btnSaveNew = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.btnActive = new System.Windows.Forms.ToolStripButton();
            this.btnDelete = new System.Windows.Forms.ToolStripButton();
            this.txtFind = new System.Windows.Forms.ToolStripTextBox();
            this.btnFind = new System.Windows.Forms.ToolStripButton();
            this.btnClear = new System.Windows.Forms.ToolStripButton();
            this.btnFilter = new System.Windows.Forms.ToolStripButton();
            this.btnMode = new System.Windows.Forms.ToolStripButton();
            this.btnExport = new System.Windows.Forms.ToolStripButton();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.dgvList = new kBit.UI.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDesc1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupLabel3 = new kBit.UI.GroupLabel();
            this.groupLabel2 = new kBit.UI.GroupLabel();
            this.groupLabel1 = new kBit.UI.GroupLabel();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtName = new kBit.UI.TextBox(this.components);
            this.txtEmail = new kBit.UI.TextBox(this.components);
            this.txtFax = new kBit.UI.TextBox(this.components);
            this.txtPhone = new kBit.UI.TextBox(this.components);
            this.txtCode = new kBit.UI.TextBox(this.components);
            this.label8 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDesc = new kBit.UI.TextBox(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNote = new System.Windows.Forms.TextBox();
            this.mnuShow = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mnuShowA = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuShowI = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).BeginInit();
            this.mnuShow.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Font = new System.Drawing.Font("Noto Sans Khmer", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnNew,
            this.btnCopy,
            this.btnUnlock,
            this.btnSave,
            this.btnSaveNew,
            this.toolStripSeparator,
            this.btnActive,
            this.btnDelete,
            this.txtFind,
            this.btnFind,
            this.btnClear,
            this.btnFilter,
            this.btnMode,
            this.btnExport});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1008, 27);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnNew
            // 
            this.btnNew.Image = global::kBit.ERP.Properties.Resources.New;
            this.btnNew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(55, 24);
            this.btnNew.Text = "&New";
            this.btnNew.ToolTipText = "New (Ctrl+N)";
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnCopy
            // 
            this.btnCopy.Enabled = false;
            this.btnCopy.Image = global::kBit.ERP.Properties.Resources.Copy;
            this.btnCopy.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(60, 24);
            this.btnCopy.Text = "Cop&y";
            this.btnCopy.ToolTipText = "Copy (Ctrl+Y)";
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // btnUnlock
            // 
            this.btnUnlock.Enabled = false;
            this.btnUnlock.Image = global::kBit.ERP.Properties.Resources.Unlock;
            this.btnUnlock.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnUnlock.Name = "btnUnlock";
            this.btnUnlock.Size = new System.Drawing.Size(70, 24);
            this.btnUnlock.Text = "Unl&ock";
            this.btnUnlock.ToolTipText = "Unlock (Ctrl+L)";
            this.btnUnlock.Click += new System.EventHandler(this.btnUnlock_Click);
            // 
            // btnSave
            // 
            this.btnSave.Enabled = false;
            this.btnSave.Image = global::kBit.ERP.Properties.Resources.Save;
            this.btnSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(60, 24);
            this.btnSave.Text = "&Save";
            this.btnSave.ToolTipText = "Save (Ctrl+S)";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnSaveNew
            // 
            this.btnSaveNew.Enabled = false;
            this.btnSaveNew.Image = global::kBit.ERP.Properties.Resources.SaveNew;
            this.btnSaveNew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSaveNew.Name = "btnSaveNew";
            this.btnSaveNew.Size = new System.Drawing.Size(116, 24);
            this.btnSaveNew.Text = "Save and Ne&w";
            this.btnSaveNew.ToolTipText = "Save and New (Ctrl+W)";
            this.btnSaveNew.Click += new System.EventHandler(this.btnSaveNew_Click);
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // btnActive
            // 
            this.btnActive.Enabled = false;
            this.btnActive.Image = global::kBit.ERP.Properties.Resources.Inactive;
            this.btnActive.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnActive.Name = "btnActive";
            this.btnActive.Size = new System.Drawing.Size(74, 24);
            this.btnActive.Text = "Inactiv&e";
            this.btnActive.ToolTipText = "Active/Inactive (Ctrl+E)";
            this.btnActive.Click += new System.EventHandler(this.btnActive_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Enabled = false;
            this.btnDelete.Image = global::kBit.ERP.Properties.Resources.Recyclebin;
            this.btnDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(68, 24);
            this.btnDelete.Text = "Delete";
            this.btnDelete.ToolTipText = "Delete (Del)";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // txtFind
            // 
            this.txtFind.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFind.Font = new System.Drawing.Font("Noto Sans Khmer", 9.75F);
            this.txtFind.Margin = new System.Windows.Forms.Padding(1);
            this.txtFind.Name = "txtFind";
            this.txtFind.Size = new System.Drawing.Size(150, 25);
            this.txtFind.ToolTipText = "Enter text to find (Ctrl+F)";
            this.txtFind.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSearch_KeyDown);
            this.txtFind.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // btnFind
            // 
            this.btnFind.Image = global::kBit.ERP.Properties.Resources.Search;
            this.btnFind.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(54, 24);
            this.btnFind.Text = "Find";
            this.btnFind.ToolTipText = "Find/Refresh (F3)";
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // btnClear
            // 
            this.btnClear.Image = global::kBit.ERP.Properties.Resources.Brush;
            this.btnClear.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(60, 24);
            this.btnClear.Text = "Clear";
            this.btnClear.ToolTipText = "Clear search (F4)";
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnFilter
            // 
            this.btnFilter.Image = global::kBit.ERP.Properties.Resources.Filter;
            this.btnFilter.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(57, 24);
            this.btnFilter.Text = "Filter";
            this.btnFilter.ToolTipText = "Filter (F8)";
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // btnMode
            // 
            this.btnMode.Image = global::kBit.ERP.Properties.Resources.Expand;
            this.btnMode.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnMode.Name = "btnMode";
            this.btnMode.Size = new System.Drawing.Size(88, 24);
            this.btnMode.Text = "List/Detail";
            this.btnMode.ToolTipText = "Toggle between list and detail mode (F9)";
            this.btnMode.Click += new System.EventHandler(this.btnMode_Click);
            // 
            // btnExport
            // 
            this.btnExport.Image = global::kBit.ERP.Properties.Resources.Export;
            this.btnExport.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(66, 21);
            this.btnExport.Text = "Export";
            this.btnExport.ToolTipText = "Export all data to CSV file (F12)";
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(0, 27);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.dgvList);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.label4);
            this.splitContainer1.Panel2.Controls.Add(this.label5);
            this.splitContainer1.Panel2.Controls.Add(this.groupLabel3);
            this.splitContainer1.Panel2.Controls.Add(this.groupLabel2);
            this.splitContainer1.Panel2.Controls.Add(this.groupLabel1);
            this.splitContainer1.Panel2.Controls.Add(this.txtAddress);
            this.splitContainer1.Panel2.Controls.Add(this.txtName);
            this.splitContainer1.Panel2.Controls.Add(this.txtEmail);
            this.splitContainer1.Panel2.Controls.Add(this.txtFax);
            this.splitContainer1.Panel2.Controls.Add(this.txtPhone);
            this.splitContainer1.Panel2.Controls.Add(this.txtCode);
            this.splitContainer1.Panel2.Controls.Add(this.label8);
            this.splitContainer1.Panel2.Controls.Add(this.label13);
            this.splitContainer1.Panel2.Controls.Add(this.label7);
            this.splitContainer1.Panel2.Controls.Add(this.txtDesc);
            this.splitContainer1.Panel2.Controls.Add(this.label6);
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Panel2.Controls.Add(this.txtNote);
            this.splitContainer1.Panel2.Font = new System.Drawing.Font("Noto Sans Khmer", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.splitContainer1.Panel2.Padding = new System.Windows.Forms.Padding(8, 4, 8, 8);
            this.splitContainer1.Panel2MinSize = 0;
            this.splitContainer1.Size = new System.Drawing.Size(1008, 535);
            this.splitContainer1.SplitterDistance = 228;
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.TabIndex = 1;
            // 
            // dgvList
            // 
            this.dgvList.AllowUserToAddRows = false;
            this.dgvList.AllowUserToDeleteRows = false;
            this.dgvList.AllowUserToResizeRows = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Honeydew;
            this.dgvList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvList.BackgroundColor = System.Drawing.Color.White;
            this.dgvList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.colCode,
            this.colDesc1,
            this.Column4,
            this.Column7,
            this.Column2,
            this.Column3,
            this.Column5});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Noto Sans Khmer", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvList.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvList.Location = new System.Drawing.Point(1, -1);
            this.dgvList.Margin = new System.Windows.Forms.Padding(4);
            this.dgvList.MultiSelect = false;
            this.dgvList.Name = "dgvList";
            this.dgvList.ReadOnly = true;
            this.dgvList.RowHeadersVisible = false;
            this.dgvList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvList.Size = new System.Drawing.Size(223, 530);
            this.dgvList.TabIndex = 1;
            this.dgvList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvList_CellDoubleClick);
            this.dgvList.SelectionChanged += new System.EventHandler(this.dgvList_SelectionChanged);
            this.dgvList.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvList_KeyDown);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Id";
            this.Column1.HeaderText = "Id";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Visible = false;
            // 
            // colCode
            // 
            this.colCode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colCode.DataPropertyName = "code";
            this.colCode.HeaderText = "Code";
            this.colCode.Name = "colCode";
            this.colCode.ReadOnly = true;
            this.colCode.Width = 66;
            // 
            // colDesc1
            // 
            this.colDesc1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colDesc1.DataPropertyName = "description";
            this.colDesc1.HeaderText = "Description";
            this.colDesc1.Name = "colDesc1";
            this.colDesc1.ReadOnly = true;
            this.colDesc1.Width = 101;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column4.DataPropertyName = "Desc2";
            this.Column4.HeaderText = "Contact Name";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 118;
            // 
            // Column7
            // 
            this.Column7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column7.DataPropertyName = "phone";
            this.Column7.HeaderText = "Phone";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Width = 72;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column2.DataPropertyName = "fax";
            this.Column2.HeaderText = "Fax";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 55;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column3.DataPropertyName = "email";
            this.Column3.HeaderText = "Email";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 67;
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column5.DataPropertyName = "address";
            this.Column5.HeaderText = "Address";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Noto Sans Khmer", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(59, 43);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "Code";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Noto Sans Khmer", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Tomato;
            this.label5.Location = new System.Drawing.Point(49, 43);
            this.label5.Margin = new System.Windows.Forms.Padding(0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(15, 17);
            this.label5.TabIndex = 54;
            this.label5.Text = "*";
            // 
            // groupLabel3
            // 
            this.groupLabel3.Caption = "Note";
            this.groupLabel3.Font = new System.Drawing.Font("Noto Sans Khmer", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupLabel3.Location = new System.Drawing.Point(12, 180);
            this.groupLabel3.Margin = new System.Windows.Forms.Padding(4, 12, 4, 4);
            this.groupLabel3.Name = "groupLabel3";
            this.groupLabel3.Size = new System.Drawing.Size(749, 21);
            this.groupLabel3.TabIndex = 16;
            this.groupLabel3.TabStop = false;
            // 
            // groupLabel2
            // 
            this.groupLabel2.Caption = "Contact";
            this.groupLabel2.Font = new System.Drawing.Font("Noto Sans Khmer", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupLabel2.Location = new System.Drawing.Point(421, 11);
            this.groupLabel2.Margin = new System.Windows.Forms.Padding(4, 12, 4, 4);
            this.groupLabel2.Name = "groupLabel2";
            this.groupLabel2.Size = new System.Drawing.Size(340, 21);
            this.groupLabel2.TabIndex = 7;
            this.groupLabel2.TabStop = false;
            // 
            // groupLabel1
            // 
            this.groupLabel1.Caption = "Location";
            this.groupLabel1.Font = new System.Drawing.Font("Noto Sans Khmer", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupLabel1.Location = new System.Drawing.Point(12, 11);
            this.groupLabel1.Margin = new System.Windows.Forms.Padding(4, 12, 4, 4);
            this.groupLabel1.Name = "groupLabel1";
            this.groupLabel1.Size = new System.Drawing.Size(356, 21);
            this.groupLabel1.TabIndex = 0;
            this.groupLabel1.TabStop = false;
            // 
            // txtAddress
            // 
            this.txtAddress.Font = new System.Drawing.Font("Noto Sans Khmer", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.Location = new System.Drawing.Point(108, 106);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(4);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.ReadOnly = true;
            this.txtAddress.Size = new System.Drawing.Size(260, 58);
            this.txtAddress.TabIndex = 6;
            this.txtAddress.TextChanged += new System.EventHandler(this.Dirty_TextChanged);
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Noto Sans Khmer", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(501, 40);
            this.txtName.Margin = new System.Windows.Forms.Padding(4);
            this.txtName.Name = "txtName";
            this.txtName.ReadOnly = true;
            this.txtName.Size = new System.Drawing.Size(260, 25);
            this.txtName.TabIndex = 9;
            this.txtName.TabOnEnter = true;
            this.txtName.TextChanged += new System.EventHandler(this.Dirty_TextChanged);
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Noto Sans Khmer", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(501, 139);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.ReadOnly = true;
            this.txtEmail.Size = new System.Drawing.Size(260, 25);
            this.txtEmail.TabIndex = 15;
            this.txtEmail.TabOnEnter = true;
            this.txtEmail.TextChanged += new System.EventHandler(this.Dirty_TextChanged);
            // 
            // txtFax
            // 
            this.txtFax.Font = new System.Drawing.Font("Noto Sans Khmer", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFax.Location = new System.Drawing.Point(501, 106);
            this.txtFax.Margin = new System.Windows.Forms.Padding(4);
            this.txtFax.Name = "txtFax";
            this.txtFax.ReadOnly = true;
            this.txtFax.Size = new System.Drawing.Size(260, 25);
            this.txtFax.TabIndex = 13;
            this.txtFax.TabOnEnter = true;
            this.txtFax.TextChanged += new System.EventHandler(this.Dirty_TextChanged);
            // 
            // txtPhone
            // 
            this.txtPhone.Font = new System.Drawing.Font("Noto Sans Khmer", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhone.Location = new System.Drawing.Point(501, 73);
            this.txtPhone.Margin = new System.Windows.Forms.Padding(4);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.ReadOnly = true;
            this.txtPhone.Size = new System.Drawing.Size(260, 25);
            this.txtPhone.TabIndex = 11;
            this.txtPhone.TabOnEnter = true;
            this.txtPhone.TextChanged += new System.EventHandler(this.Dirty_TextChanged);
            // 
            // txtCode
            // 
            this.txtCode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCode.Font = new System.Drawing.Font("Noto Sans Khmer", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCode.Location = new System.Drawing.Point(108, 40);
            this.txtCode.Margin = new System.Windows.Forms.Padding(4);
            this.txtCode.Name = "txtCode";
            this.txtCode.ReadOnly = true;
            this.txtCode.Size = new System.Drawing.Size(260, 25);
            this.txtCode.TabIndex = 2;
            this.txtCode.TabOnEnter = true;
            this.txtCode.TextChanged += new System.EventHandler(this.Dirty_TextChanged);
            this.txtCode.Leave += new System.EventHandler(this.txtCode_Leave);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Noto Sans Khmer", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(451, 142);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 17);
            this.label8.TabIndex = 14;
            this.label8.Text = "Email";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Noto Sans Khmer", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(41, 109);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(59, 17);
            this.label13.TabIndex = 5;
            this.label13.Text = "Address";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Noto Sans Khmer", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(463, 109);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(30, 17);
            this.label7.TabIndex = 12;
            this.label7.Text = "Fax";
            // 
            // txtDesc
            // 
            this.txtDesc.Font = new System.Drawing.Font("Noto Sans Khmer", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDesc.Location = new System.Drawing.Point(108, 73);
            this.txtDesc.Margin = new System.Windows.Forms.Padding(4);
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.ReadOnly = true;
            this.txtDesc.Size = new System.Drawing.Size(260, 25);
            this.txtDesc.TabIndex = 4;
            this.txtDesc.TabOnEnter = true;
            this.txtDesc.TextChanged += new System.EventHandler(this.Dirty_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Noto Sans Khmer", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(446, 76);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "Phone";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Noto Sans Khmer", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(448, 43);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Noto Sans Khmer", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 75);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Description";
            // 
            // txtNote
            // 
            this.txtNote.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtNote.Location = new System.Drawing.Point(12, 209);
            this.txtNote.Margin = new System.Windows.Forms.Padding(4);
            this.txtNote.Multiline = true;
            this.txtNote.Name = "txtNote";
            this.txtNote.ReadOnly = true;
            this.txtNote.Size = new System.Drawing.Size(749, 312);
            this.txtNote.TabIndex = 17;
            this.txtNote.TextChanged += new System.EventHandler(this.Dirty_TextChanged);
            // 
            // mnuShow
            // 
            this.mnuShow.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuShowA,
            this.mnuShowI});
            this.mnuShow.Name = "contextMenuStrip1";
            this.mnuShow.Size = new System.Drawing.Size(148, 48);
            // 
            // mnuShowA
            // 
            this.mnuShowA.Checked = true;
            this.mnuShowA.CheckOnClick = true;
            this.mnuShowA.CheckState = System.Windows.Forms.CheckState.Checked;
            this.mnuShowA.Name = "mnuShowA";
            this.mnuShowA.Size = new System.Drawing.Size(147, 22);
            this.mnuShowA.Text = "Show Active";
            this.mnuShowA.CheckedChanged += new System.EventHandler(this.mnuShow_CheckedChanged);
            // 
            // mnuShowI
            // 
            this.mnuShowI.CheckOnClick = true;
            this.mnuShowI.Name = "mnuShowI";
            this.mnuShowI.Size = new System.Drawing.Size(147, 22);
            this.mnuShowI.Text = "Show Inactive";
            this.mnuShowI.CheckedChanged += new System.EventHandler(this.mnuShow_CheckedChanged);
            // 
            // frmLocationList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1008, 562);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("Noto Sans Khmer", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmLocationList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Location";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmLocationList_FormClosing);
            this.Load += new System.EventHandler(this.frmLocationList_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).EndInit();
            this.mnuShow.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnNew;
        private System.Windows.Forms.ToolStripButton btnSave;
        private System.Windows.Forms.ToolStripButton btnCopy;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripButton btnDelete;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ToolStripButton btnSaveNew;
        private System.Windows.Forms.TextBox txtNote;
        private System.Windows.Forms.ContextMenuStrip mnuShow;
        private System.Windows.Forms.ToolStripButton btnActive;
        private System.Windows.Forms.ToolStripButton btnUnlock;
        private System.Windows.Forms.ToolStripMenuItem mnuShowA;
        private System.Windows.Forms.ToolStripMenuItem mnuShowI;
        private kBit.UI.DataGridView dgvList;
        private System.Windows.Forms.Label label4;
        private kBit.UI.GroupLabel groupLabel2;
        private kBit.UI.GroupLabel groupLabel1;
        private System.Windows.Forms.TextBox txtAddress;
        private kBit.UI.TextBox txtCode;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label7;
        private kBit.UI.TextBox txtDesc;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private kBit.UI.TextBox txtName;
        private kBit.UI.TextBox txtPhone;
        private kBit.UI.TextBox txtEmail;
        private kBit.UI.TextBox txtFax;
        private System.Windows.Forms.Label label5;
        private kBit.UI.GroupLabel groupLabel3;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolStripButton btnFind;
        private System.Windows.Forms.ToolStripButton btnClear;
        private System.Windows.Forms.ToolStripButton btnMode;
        private System.Windows.Forms.ToolStripTextBox txtFind;
        private System.Windows.Forms.ToolStripButton btnFilter;
        private System.Windows.Forms.ToolStripButton btnExport;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDesc1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;        
    }
}

