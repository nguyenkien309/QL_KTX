﻿
namespace Dormitory_Management_2021.GUI.SinhVien
{
    partial class UC_SinhVien
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgv = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.masv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hoten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gioitinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quequan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nienkhoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maphong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_Refresh = new Guna.UI2.WinForms.Guna2Button();
            this.txt_Name_Student_Contract = new Guna.UI2.WinForms.Guna2TextBox();
            this.btn_Name_Student_Contract = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.btn_Excel = new Guna.UI2.WinForms.Guna2Button();
            this.btn_Identity_Card_Student_Contract = new Guna.UI2.WinForms.Guna2Button();
            this.txt_Identity_Card_Student_Contract = new Guna.UI2.WinForms.Guna2TextBox();
            this.btn_Home_Town_Student_Contract = new Guna.UI2.WinForms.Guna2Button();
            this.txt_Home_Town_Student_Contract = new Guna.UI2.WinForms.Guna2TextBox();
            this.btn_Class_Student_Contract = new Guna.UI2.WinForms.Guna2Button();
            this.txt_Class_Student_Contract = new Guna.UI2.WinForms.Guna2TextBox();
            this.btn_Parents_Name_Student_Contract = new Guna.UI2.WinForms.Guna2Button();
            this.txt_Parents_Name_Student_Contract = new Guna.UI2.WinForms.Guna2TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.AllowUserToResizeColumns = false;
            this.dgv.AllowUserToResizeRows = false;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.White;
            this.dgv.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle11;
            this.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv.BackgroundColor = System.Drawing.Color.White;
            this.dgv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgv.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            this.dgv.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(209)))), ((int)(((byte)(161)))));
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(209)))), ((int)(((byte)(161)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.dgv.ColumnHeadersHeight = 60;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.masv,
            this.hoten,
            this.lop,
            this.gioitinh,
            this.quequan,
            this.nienkhoa,
            this.maphong});
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv.DefaultCellStyle = dataGridViewCellStyle13;
            this.dgv.DoubleBuffered = true;
            this.dgv.EnableHeadersVisualStyles = false;
            this.dgv.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(209)))), ((int)(((byte)(161)))));
            this.dgv.HeaderForeColor = System.Drawing.Color.White;
            this.dgv.Location = new System.Drawing.Point(17, 146);
            this.dgv.Margin = new System.Windows.Forms.Padding(4);
            this.dgv.MultiSelect = false;
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv.RowHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.dgv.RowHeadersVisible = false;
            this.dgv.RowHeadersWidth = 51;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle15.Padding = new System.Windows.Forms.Padding(0, 0, 0, 3);
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.Black;
            this.dgv.RowsDefaultCellStyle = dataGridViewCellStyle15;
            this.dgv.RowTemplate.Height = 50;
            this.dgv.RowTemplate.ReadOnly = true;
            this.dgv.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv.Size = new System.Drawing.Size(1839, 800);
            this.dgv.TabIndex = 34;
            this.dgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellContentClick);
            this.dgv.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dgv_RowPostPaint);
            this.dgv.DoubleClick += new System.EventHandler(this.dgv_DoubleClick);
            // 
            // id
            // 
            this.id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "ID";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Width = 65;
            // 
            // masv
            // 
            this.masv.DataPropertyName = "masv";
            this.masv.HeaderText = "MSSV";
            this.masv.MinimumWidth = 6;
            this.masv.Name = "masv";
            this.masv.ReadOnly = true;
            // 
            // hoten
            // 
            this.hoten.DataPropertyName = "hoten";
            this.hoten.HeaderText = "Họ Tên";
            this.hoten.MinimumWidth = 30;
            this.hoten.Name = "hoten";
            this.hoten.ReadOnly = true;
            // 
            // lop
            // 
            this.lop.DataPropertyName = "lop";
            this.lop.HeaderText = "Lớp";
            this.lop.MinimumWidth = 6;
            this.lop.Name = "lop";
            this.lop.ReadOnly = true;
            // 
            // gioitinh
            // 
            this.gioitinh.DataPropertyName = "gioitinh";
            this.gioitinh.HeaderText = "Giới Tính";
            this.gioitinh.MinimumWidth = 6;
            this.gioitinh.Name = "gioitinh";
            this.gioitinh.ReadOnly = true;
            // 
            // quequan
            // 
            this.quequan.DataPropertyName = "quequan";
            this.quequan.HeaderText = "Quê Quán ";
            this.quequan.MinimumWidth = 6;
            this.quequan.Name = "quequan";
            this.quequan.ReadOnly = true;
            // 
            // nienkhoa
            // 
            this.nienkhoa.DataPropertyName = "nienkhoa";
            this.nienkhoa.HeaderText = "Niên Khóa";
            this.nienkhoa.MinimumWidth = 6;
            this.nienkhoa.Name = "nienkhoa";
            this.nienkhoa.ReadOnly = true;
            // 
            // maphong
            // 
            this.maphong.DataPropertyName = "maphong";
            this.maphong.HeaderText = "Mã Phòng";
            this.maphong.MinimumWidth = 6;
            this.maphong.Name = "maphong";
            this.maphong.ReadOnly = true;
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.BorderColor = System.Drawing.Color.Transparent;
            this.btn_Refresh.BorderRadius = 15;
            this.btn_Refresh.CheckedState.Parent = this.btn_Refresh;
            this.btn_Refresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Refresh.CustomImages.Parent = this.btn_Refresh;
            this.btn_Refresh.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.btn_Refresh.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Refresh.ForeColor = System.Drawing.Color.White;
            this.btn_Refresh.HoverState.Parent = this.btn_Refresh;
            this.btn_Refresh.Image = global::Dormitory_Management_2021.Properties.Resources.refresh_500px;
            this.btn_Refresh.ImageSize = new System.Drawing.Size(60, 60);
            this.btn_Refresh.Location = new System.Drawing.Point(1583, 16);
            this.btn_Refresh.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.ShadowDecoration.Parent = this.btn_Refresh;
            this.btn_Refresh.Size = new System.Drawing.Size(275, 111);
            this.btn_Refresh.TabIndex = 50;
            this.btn_Refresh.Text = "Làm mới";
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click_1);
            // 
            // txt_Name_Student_Contract
            // 
            this.txt_Name_Student_Contract.AutoRoundedCorners = true;
            this.txt_Name_Student_Contract.BorderRadius = 21;
            this.txt_Name_Student_Contract.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Name_Student_Contract.DefaultText = "";
            this.txt_Name_Student_Contract.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_Name_Student_Contract.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_Name_Student_Contract.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_Name_Student_Contract.DisabledState.Parent = this.txt_Name_Student_Contract;
            this.txt_Name_Student_Contract.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_Name_Student_Contract.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_Name_Student_Contract.FocusedState.Parent = this.txt_Name_Student_Contract;
            this.txt_Name_Student_Contract.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Name_Student_Contract.ForeColor = System.Drawing.Color.Black;
            this.txt_Name_Student_Contract.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_Name_Student_Contract.HoverState.Parent = this.txt_Name_Student_Contract;
            this.txt_Name_Student_Contract.Location = new System.Drawing.Point(17, 91);
            this.txt_Name_Student_Contract.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.txt_Name_Student_Contract.Name = "txt_Name_Student_Contract";
            this.txt_Name_Student_Contract.PasswordChar = '\0';
            this.txt_Name_Student_Contract.PlaceholderText = "";
            this.txt_Name_Student_Contract.SelectedText = "";
            this.txt_Name_Student_Contract.ShadowDecoration.Parent = this.txt_Name_Student_Contract;
            this.txt_Name_Student_Contract.Size = new System.Drawing.Size(271, 44);
            this.txt_Name_Student_Contract.TabIndex = 56;
            this.txt_Name_Student_Contract.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_Name_Student_Contract.TextChanged += new System.EventHandler(this.btn_Name_Student_Contract_Click);
            // 
            // btn_Name_Student_Contract
            // 
            this.btn_Name_Student_Contract.AutoRoundedCorners = true;
            this.btn_Name_Student_Contract.BorderColor = System.Drawing.Color.Transparent;
            this.btn_Name_Student_Contract.BorderRadius = 34;
            this.btn_Name_Student_Contract.CheckedState.Parent = this.btn_Name_Student_Contract;
            this.btn_Name_Student_Contract.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Name_Student_Contract.CustomImages.Parent = this.btn_Name_Student_Contract;
            this.btn_Name_Student_Contract.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(188)))), ((int)(((byte)(156)))));
            this.btn_Name_Student_Contract.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Name_Student_Contract.ForeColor = System.Drawing.Color.White;
            this.btn_Name_Student_Contract.HoverState.Parent = this.btn_Name_Student_Contract;
            this.btn_Name_Student_Contract.Image = global::Dormitory_Management_2021.Properties.Resources.name_tag_500px;
            this.btn_Name_Student_Contract.ImageSize = new System.Drawing.Size(60, 60);
            this.btn_Name_Student_Contract.Location = new System.Drawing.Point(17, 16);
            this.btn_Name_Student_Contract.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Name_Student_Contract.Name = "btn_Name_Student_Contract";
            this.btn_Name_Student_Contract.ShadowDecoration.Parent = this.btn_Name_Student_Contract;
            this.btn_Name_Student_Contract.Size = new System.Drawing.Size(271, 70);
            this.btn_Name_Student_Contract.TabIndex = 55;
            this.btn_Name_Student_Contract.Text = "Tên";
            this.btn_Name_Student_Contract.Click += new System.EventHandler(this.btn_Name_Student_Contract_Click);
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this.dgv;
            // 
            // btn_Excel
            // 
            this.btn_Excel.BorderColor = System.Drawing.Color.Transparent;
            this.btn_Excel.BorderRadius = 20;
            this.btn_Excel.CheckedState.Parent = this.btn_Excel;
            this.btn_Excel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Excel.CustomImages.Parent = this.btn_Excel;
            this.btn_Excel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(172)))), ((int)(((byte)(132)))));
            this.btn_Excel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Excel.ForeColor = System.Drawing.Color.White;
            this.btn_Excel.HoverState.Parent = this.btn_Excel;
            this.btn_Excel.Image = global::Dormitory_Management_2021.Properties.Resources.microsoft_excel_500px;
            this.btn_Excel.ImageSize = new System.Drawing.Size(60, 60);
            this.btn_Excel.Location = new System.Drawing.Point(1581, 961);
            this.btn_Excel.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Excel.Name = "btn_Excel";
            this.btn_Excel.ShadowDecoration.Parent = this.btn_Excel;
            this.btn_Excel.Size = new System.Drawing.Size(275, 91);
            this.btn_Excel.TabIndex = 59;
            this.btn_Excel.Text = "Excel";
            this.btn_Excel.Click += new System.EventHandler(this.btn_Excel_Click);
            // 
            // btn_Identity_Card_Student_Contract
            // 
            this.btn_Identity_Card_Student_Contract.AutoRoundedCorners = true;
            this.btn_Identity_Card_Student_Contract.BorderColor = System.Drawing.Color.Transparent;
            this.btn_Identity_Card_Student_Contract.BorderRadius = 34;
            this.btn_Identity_Card_Student_Contract.CheckedState.Parent = this.btn_Identity_Card_Student_Contract;
            this.btn_Identity_Card_Student_Contract.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Identity_Card_Student_Contract.CustomImages.Parent = this.btn_Identity_Card_Student_Contract;
            this.btn_Identity_Card_Student_Contract.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(188)))), ((int)(((byte)(156)))));
            this.btn_Identity_Card_Student_Contract.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Identity_Card_Student_Contract.ForeColor = System.Drawing.Color.White;
            this.btn_Identity_Card_Student_Contract.HoverState.Parent = this.btn_Identity_Card_Student_Contract;
            this.btn_Identity_Card_Student_Contract.Image = global::Dormitory_Management_2021.Properties.Resources.name_tag_500px;
            this.btn_Identity_Card_Student_Contract.ImageSize = new System.Drawing.Size(60, 60);
            this.btn_Identity_Card_Student_Contract.Location = new System.Drawing.Point(296, 16);
            this.btn_Identity_Card_Student_Contract.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Identity_Card_Student_Contract.Name = "btn_Identity_Card_Student_Contract";
            this.btn_Identity_Card_Student_Contract.ShadowDecoration.Parent = this.btn_Identity_Card_Student_Contract;
            this.btn_Identity_Card_Student_Contract.Size = new System.Drawing.Size(271, 70);
            this.btn_Identity_Card_Student_Contract.TabIndex = 55;
            this.btn_Identity_Card_Student_Contract.Text = "MSSV";
            this.btn_Identity_Card_Student_Contract.Click += new System.EventHandler(this.btn_Identity_Card_Student_Contract_Click);
            // 
            // txt_Identity_Card_Student_Contract
            // 
            this.txt_Identity_Card_Student_Contract.AutoRoundedCorners = true;
            this.txt_Identity_Card_Student_Contract.BorderRadius = 21;
            this.txt_Identity_Card_Student_Contract.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Identity_Card_Student_Contract.DefaultText = "";
            this.txt_Identity_Card_Student_Contract.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_Identity_Card_Student_Contract.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_Identity_Card_Student_Contract.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_Identity_Card_Student_Contract.DisabledState.Parent = this.txt_Identity_Card_Student_Contract;
            this.txt_Identity_Card_Student_Contract.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_Identity_Card_Student_Contract.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_Identity_Card_Student_Contract.FocusedState.Parent = this.txt_Identity_Card_Student_Contract;
            this.txt_Identity_Card_Student_Contract.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Identity_Card_Student_Contract.ForeColor = System.Drawing.Color.Black;
            this.txt_Identity_Card_Student_Contract.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_Identity_Card_Student_Contract.HoverState.Parent = this.txt_Identity_Card_Student_Contract;
            this.txt_Identity_Card_Student_Contract.Location = new System.Drawing.Point(296, 91);
            this.txt_Identity_Card_Student_Contract.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.txt_Identity_Card_Student_Contract.Name = "txt_Identity_Card_Student_Contract";
            this.txt_Identity_Card_Student_Contract.PasswordChar = '\0';
            this.txt_Identity_Card_Student_Contract.PlaceholderText = "dong";
            this.txt_Identity_Card_Student_Contract.SelectedText = "";
            this.txt_Identity_Card_Student_Contract.ShadowDecoration.Parent = this.txt_Identity_Card_Student_Contract;
            this.txt_Identity_Card_Student_Contract.Size = new System.Drawing.Size(271, 44);
            this.txt_Identity_Card_Student_Contract.TabIndex = 56;
            this.txt_Identity_Card_Student_Contract.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_Identity_Card_Student_Contract.TextChanged += new System.EventHandler(this.btn_Identity_Card_Student_Contract_Click);
            this.txt_Identity_Card_Student_Contract.Click += new System.EventHandler(this.btn_Identity_Card_Student_Contract_Click);
            // 
            // btn_Home_Town_Student_Contract
            // 
            this.btn_Home_Town_Student_Contract.AutoRoundedCorners = true;
            this.btn_Home_Town_Student_Contract.BorderColor = System.Drawing.Color.Transparent;
            this.btn_Home_Town_Student_Contract.BorderRadius = 34;
            this.btn_Home_Town_Student_Contract.CheckedState.Parent = this.btn_Home_Town_Student_Contract;
            this.btn_Home_Town_Student_Contract.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Home_Town_Student_Contract.CustomImages.Parent = this.btn_Home_Town_Student_Contract;
            this.btn_Home_Town_Student_Contract.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(188)))), ((int)(((byte)(156)))));
            this.btn_Home_Town_Student_Contract.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Home_Town_Student_Contract.ForeColor = System.Drawing.Color.White;
            this.btn_Home_Town_Student_Contract.HoverState.Parent = this.btn_Home_Town_Student_Contract;
            this.btn_Home_Town_Student_Contract.Image = global::Dormitory_Management_2021.Properties.Resources.name_tag_500px;
            this.btn_Home_Town_Student_Contract.ImageSize = new System.Drawing.Size(60, 60);
            this.btn_Home_Town_Student_Contract.Location = new System.Drawing.Point(575, 16);
            this.btn_Home_Town_Student_Contract.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Home_Town_Student_Contract.Name = "btn_Home_Town_Student_Contract";
            this.btn_Home_Town_Student_Contract.ShadowDecoration.Parent = this.btn_Home_Town_Student_Contract;
            this.btn_Home_Town_Student_Contract.Size = new System.Drawing.Size(271, 70);
            this.btn_Home_Town_Student_Contract.TabIndex = 55;
            this.btn_Home_Town_Student_Contract.Text = "Lớp";
            this.btn_Home_Town_Student_Contract.Click += new System.EventHandler(this.btn_Home_Town_Student_Contract_Click);
            // 
            // txt_Home_Town_Student_Contract
            // 
            this.txt_Home_Town_Student_Contract.AutoRoundedCorners = true;
            this.txt_Home_Town_Student_Contract.BorderRadius = 21;
            this.txt_Home_Town_Student_Contract.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Home_Town_Student_Contract.DefaultText = "";
            this.txt_Home_Town_Student_Contract.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_Home_Town_Student_Contract.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_Home_Town_Student_Contract.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_Home_Town_Student_Contract.DisabledState.Parent = this.txt_Home_Town_Student_Contract;
            this.txt_Home_Town_Student_Contract.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_Home_Town_Student_Contract.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_Home_Town_Student_Contract.FocusedState.Parent = this.txt_Home_Town_Student_Contract;
            this.txt_Home_Town_Student_Contract.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Home_Town_Student_Contract.ForeColor = System.Drawing.Color.Black;
            this.txt_Home_Town_Student_Contract.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_Home_Town_Student_Contract.HoverState.Parent = this.txt_Home_Town_Student_Contract;
            this.txt_Home_Town_Student_Contract.Location = new System.Drawing.Point(575, 91);
            this.txt_Home_Town_Student_Contract.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.txt_Home_Town_Student_Contract.Name = "txt_Home_Town_Student_Contract";
            this.txt_Home_Town_Student_Contract.PasswordChar = '\0';
            this.txt_Home_Town_Student_Contract.PlaceholderText = "dong";
            this.txt_Home_Town_Student_Contract.SelectedText = "";
            this.txt_Home_Town_Student_Contract.ShadowDecoration.Parent = this.txt_Home_Town_Student_Contract;
            this.txt_Home_Town_Student_Contract.Size = new System.Drawing.Size(271, 44);
            this.txt_Home_Town_Student_Contract.TabIndex = 56;
            this.txt_Home_Town_Student_Contract.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_Home_Town_Student_Contract.TextChanged += new System.EventHandler(this.btn_Home_Town_Student_Contract_Click);
            this.txt_Home_Town_Student_Contract.Click += new System.EventHandler(this.btn_Home_Town_Student_Contract_Click);
            // 
            // btn_Class_Student_Contract
            // 
            this.btn_Class_Student_Contract.AutoRoundedCorners = true;
            this.btn_Class_Student_Contract.BorderColor = System.Drawing.Color.Transparent;
            this.btn_Class_Student_Contract.BorderRadius = 34;
            this.btn_Class_Student_Contract.CheckedState.Parent = this.btn_Class_Student_Contract;
            this.btn_Class_Student_Contract.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Class_Student_Contract.CustomImages.Parent = this.btn_Class_Student_Contract;
            this.btn_Class_Student_Contract.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(188)))), ((int)(((byte)(156)))));
            this.btn_Class_Student_Contract.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Class_Student_Contract.ForeColor = System.Drawing.Color.White;
            this.btn_Class_Student_Contract.HoverState.Parent = this.btn_Class_Student_Contract;
            this.btn_Class_Student_Contract.Image = global::Dormitory_Management_2021.Properties.Resources.name_tag_500px;
            this.btn_Class_Student_Contract.ImageSize = new System.Drawing.Size(60, 60);
            this.btn_Class_Student_Contract.Location = new System.Drawing.Point(853, 16);
            this.btn_Class_Student_Contract.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Class_Student_Contract.Name = "btn_Class_Student_Contract";
            this.btn_Class_Student_Contract.ShadowDecoration.Parent = this.btn_Class_Student_Contract;
            this.btn_Class_Student_Contract.Size = new System.Drawing.Size(271, 70);
            this.btn_Class_Student_Contract.TabIndex = 55;
            this.btn_Class_Student_Contract.Text = "Quê Quán";
            this.btn_Class_Student_Contract.Click += new System.EventHandler(this.btn_Class_Student_Contract_Click);
            // 
            // txt_Class_Student_Contract
            // 
            this.txt_Class_Student_Contract.AutoRoundedCorners = true;
            this.txt_Class_Student_Contract.BorderRadius = 21;
            this.txt_Class_Student_Contract.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Class_Student_Contract.DefaultText = "";
            this.txt_Class_Student_Contract.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_Class_Student_Contract.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_Class_Student_Contract.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_Class_Student_Contract.DisabledState.Parent = this.txt_Class_Student_Contract;
            this.txt_Class_Student_Contract.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_Class_Student_Contract.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_Class_Student_Contract.FocusedState.Parent = this.txt_Class_Student_Contract;
            this.txt_Class_Student_Contract.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Class_Student_Contract.ForeColor = System.Drawing.Color.Black;
            this.txt_Class_Student_Contract.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_Class_Student_Contract.HoverState.Parent = this.txt_Class_Student_Contract;
            this.txt_Class_Student_Contract.Location = new System.Drawing.Point(853, 91);
            this.txt_Class_Student_Contract.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.txt_Class_Student_Contract.Name = "txt_Class_Student_Contract";
            this.txt_Class_Student_Contract.PasswordChar = '\0';
            this.txt_Class_Student_Contract.PlaceholderText = "dong";
            this.txt_Class_Student_Contract.SelectedText = "";
            this.txt_Class_Student_Contract.ShadowDecoration.Parent = this.txt_Class_Student_Contract;
            this.txt_Class_Student_Contract.Size = new System.Drawing.Size(271, 44);
            this.txt_Class_Student_Contract.TabIndex = 56;
            this.txt_Class_Student_Contract.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_Class_Student_Contract.TextChanged += new System.EventHandler(this.btn_Class_Student_Contract_Click);
            this.txt_Class_Student_Contract.Click += new System.EventHandler(this.btn_Class_Student_Contract_Click);
            // 
            // btn_Parents_Name_Student_Contract
            // 
            this.btn_Parents_Name_Student_Contract.AutoRoundedCorners = true;
            this.btn_Parents_Name_Student_Contract.BorderColor = System.Drawing.Color.Transparent;
            this.btn_Parents_Name_Student_Contract.BorderRadius = 34;
            this.btn_Parents_Name_Student_Contract.CheckedState.Parent = this.btn_Parents_Name_Student_Contract;
            this.btn_Parents_Name_Student_Contract.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Parents_Name_Student_Contract.CustomImages.Parent = this.btn_Parents_Name_Student_Contract;
            this.btn_Parents_Name_Student_Contract.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(188)))), ((int)(((byte)(156)))));
            this.btn_Parents_Name_Student_Contract.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Parents_Name_Student_Contract.ForeColor = System.Drawing.Color.White;
            this.btn_Parents_Name_Student_Contract.HoverState.Parent = this.btn_Parents_Name_Student_Contract;
            this.btn_Parents_Name_Student_Contract.Image = global::Dormitory_Management_2021.Properties.Resources.name_tag_500px;
            this.btn_Parents_Name_Student_Contract.ImageSize = new System.Drawing.Size(60, 60);
            this.btn_Parents_Name_Student_Contract.Location = new System.Drawing.Point(1132, 16);
            this.btn_Parents_Name_Student_Contract.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Parents_Name_Student_Contract.Name = "btn_Parents_Name_Student_Contract";
            this.btn_Parents_Name_Student_Contract.ShadowDecoration.Parent = this.btn_Parents_Name_Student_Contract;
            this.btn_Parents_Name_Student_Contract.Size = new System.Drawing.Size(271, 70);
            this.btn_Parents_Name_Student_Contract.TabIndex = 55;
            this.btn_Parents_Name_Student_Contract.Text = "Phòng";
            this.btn_Parents_Name_Student_Contract.Click += new System.EventHandler(this.btn_Parents_Name_Student_Contract_Click);
            // 
            // txt_Parents_Name_Student_Contract
            // 
            this.txt_Parents_Name_Student_Contract.AutoRoundedCorners = true;
            this.txt_Parents_Name_Student_Contract.BorderRadius = 21;
            this.txt_Parents_Name_Student_Contract.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Parents_Name_Student_Contract.DefaultText = "";
            this.txt_Parents_Name_Student_Contract.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_Parents_Name_Student_Contract.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_Parents_Name_Student_Contract.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_Parents_Name_Student_Contract.DisabledState.Parent = this.txt_Parents_Name_Student_Contract;
            this.txt_Parents_Name_Student_Contract.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_Parents_Name_Student_Contract.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_Parents_Name_Student_Contract.FocusedState.Parent = this.txt_Parents_Name_Student_Contract;
            this.txt_Parents_Name_Student_Contract.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Parents_Name_Student_Contract.ForeColor = System.Drawing.Color.Black;
            this.txt_Parents_Name_Student_Contract.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_Parents_Name_Student_Contract.HoverState.Parent = this.txt_Parents_Name_Student_Contract;
            this.txt_Parents_Name_Student_Contract.Location = new System.Drawing.Point(1132, 91);
            this.txt_Parents_Name_Student_Contract.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.txt_Parents_Name_Student_Contract.Name = "txt_Parents_Name_Student_Contract";
            this.txt_Parents_Name_Student_Contract.PasswordChar = '\0';
            this.txt_Parents_Name_Student_Contract.PlaceholderText = "dong";
            this.txt_Parents_Name_Student_Contract.SelectedText = "";
            this.txt_Parents_Name_Student_Contract.ShadowDecoration.Parent = this.txt_Parents_Name_Student_Contract;
            this.txt_Parents_Name_Student_Contract.Size = new System.Drawing.Size(271, 44);
            this.txt_Parents_Name_Student_Contract.TabIndex = 56;
            this.txt_Parents_Name_Student_Contract.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_Parents_Name_Student_Contract.TextChanged += new System.EventHandler(this.btn_Parents_Name_Student_Contract_Click);
            this.txt_Parents_Name_Student_Contract.Click += new System.EventHandler(this.btn_Parents_Name_Student_Contract_Click);
            // 
            // UC_SinhVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.Controls.Add(this.btn_Excel);
            this.Controls.Add(this.txt_Parents_Name_Student_Contract);
            this.Controls.Add(this.txt_Class_Student_Contract);
            this.Controls.Add(this.txt_Home_Town_Student_Contract);
            this.Controls.Add(this.txt_Identity_Card_Student_Contract);
            this.Controls.Add(this.txt_Name_Student_Contract);
            this.Controls.Add(this.btn_Parents_Name_Student_Contract);
            this.Controls.Add(this.btn_Class_Student_Contract);
            this.Controls.Add(this.btn_Home_Town_Student_Contract);
            this.Controls.Add(this.btn_Identity_Card_Student_Contract);
            this.Controls.Add(this.btn_Name_Student_Contract);
            this.Controls.Add(this.btn_Refresh);
            this.Controls.Add(this.dgv);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UC_SinhVien";
            this.Size = new System.Drawing.Size(1873, 1063);
            this.Load += new System.EventHandler(this.UC_SinhVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public Bunifu.Framework.UI.BunifuCustomDataGrid dgv;
        private Guna.UI2.WinForms.Guna2Button btn_Refresh;
        private Guna.UI2.WinForms.Guna2TextBox txt_Name_Student_Contract;
        private Guna.UI2.WinForms.Guna2Button btn_Name_Student_Contract;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Button btn_Excel;
        private Guna.UI2.WinForms.Guna2Button btn_Identity_Card_Student_Contract;
        private Guna.UI2.WinForms.Guna2TextBox txt_Identity_Card_Student_Contract;
        private Guna.UI2.WinForms.Guna2Button btn_Home_Town_Student_Contract;
        private Guna.UI2.WinForms.Guna2TextBox txt_Home_Town_Student_Contract;
        private Guna.UI2.WinForms.Guna2Button btn_Class_Student_Contract;
        private Guna.UI2.WinForms.Guna2TextBox txt_Class_Student_Contract;
        private Guna.UI2.WinForms.Guna2Button btn_Parents_Name_Student_Contract;
        private Guna.UI2.WinForms.Guna2TextBox txt_Parents_Name_Student_Contract;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn masv;
        private System.Windows.Forms.DataGridViewTextBoxColumn hoten;
        private System.Windows.Forms.DataGridViewTextBoxColumn lop;
        private System.Windows.Forms.DataGridViewTextBoxColumn gioitinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn quequan;
        private System.Windows.Forms.DataGridViewTextBoxColumn nienkhoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn maphong;
    }
}
