﻿
namespace Dormitory_Management_2021.GUI.NhanVien
{
    partial class UCNhanVien
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgv = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.btnAdd = new Guna.UI2.WinForms.Guna2Button();
            this.btn_Refresh = new Guna.UI2.WinForms.Guna2Button();
            this.btn_Workplace_Employee = new Guna.UI2.WinForms.Guna2Button();
            this.cb_Workplace_Employee = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btn_Work_Employee = new Guna.UI2.WinForms.Guna2Button();
            this.cb_Work_Employee = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btn_Name_Employee = new Guna.UI2.WinForms.Guna2Button();
            this.txt_Home_Town_Employee = new Guna.UI2.WinForms.Guna2TextBox();
            this.btn_Home_Town_Employee = new Guna.UI2.WinForms.Guna2Button();
            this.txt_Name_Employee = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.btn_Excel = new Guna.UI2.WinForms.Guna2Button();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hoten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gioitinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmnd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diachi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quequan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.congviec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.luong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sdt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.AllowUserToResizeColumns = false;
            this.dgv.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgv.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv.BackgroundColor = System.Drawing.Color.White;
            this.dgv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgv.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            this.dgv.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(209)))), ((int)(((byte)(161)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(209)))), ((int)(((byte)(161)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv.ColumnHeadersHeight = 60;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.hoten,
            this.gioitinh,
            this.cmnd,
            this.diachi,
            this.quequan,
            this.congviec,
            this.luong,
            this.sdt});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv.DefaultCellStyle = dataGridViewCellStyle3;
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
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv.RowHeadersVisible = false;
            this.dgv.RowHeadersWidth = 51;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.Padding = new System.Windows.Forms.Padding(0, 0, 0, 3);
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            this.dgv.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgv.RowTemplate.Height = 50;
            this.dgv.RowTemplate.ReadOnly = true;
            this.dgv.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv.Size = new System.Drawing.Size(1839, 800);
            this.dgv.TabIndex = 41;
            this.dgv.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dgv_RowPostPaint);
            this.dgv.DoubleClick += new System.EventHandler(this.dgv_DoubleClick);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Transparent;
            this.btnAdd.BorderColor = System.Drawing.Color.Transparent;
            this.btnAdd.BorderRadius = 20;
            this.btnAdd.CheckedState.Parent = this.btnAdd;
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.CustomImages.Parent = this.btnAdd;
            this.btnAdd.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.HoverState.Parent = this.btnAdd;
            this.btnAdd.Image = global::Dormitory_Management_2021.Properties.Resources.add_500px;
            this.btnAdd.ImageSize = new System.Drawing.Size(60, 60);
            this.btnAdd.Location = new System.Drawing.Point(1583, 16);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.ShadowDecoration.Parent = this.btnAdd;
            this.btnAdd.Size = new System.Drawing.Size(275, 111);
            this.btnAdd.TabIndex = 50;
            this.btnAdd.Text = "Thêm mới";
            this.btnAdd.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.BorderColor = System.Drawing.Color.Transparent;
            this.btn_Refresh.BorderRadius = 20;
            this.btn_Refresh.CheckedState.Parent = this.btn_Refresh;
            this.btn_Refresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Refresh.CustomImages.Parent = this.btn_Refresh;
            this.btn_Refresh.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.btn_Refresh.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Refresh.ForeColor = System.Drawing.Color.White;
            this.btn_Refresh.HoverState.Parent = this.btn_Refresh;
            this.btn_Refresh.Image = global::Dormitory_Management_2021.Properties.Resources.refresh_500px;
            this.btn_Refresh.ImageSize = new System.Drawing.Size(60, 60);
            this.btn_Refresh.Location = new System.Drawing.Point(1300, 16);
            this.btn_Refresh.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.ShadowDecoration.Parent = this.btn_Refresh;
            this.btn_Refresh.Size = new System.Drawing.Size(275, 111);
            this.btn_Refresh.TabIndex = 49;
            this.btn_Refresh.Text = "Làm mới";
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
            // 
            // btn_Workplace_Employee
            // 
            this.btn_Workplace_Employee.AutoRoundedCorners = true;
            this.btn_Workplace_Employee.BorderColor = System.Drawing.Color.Transparent;
            this.btn_Workplace_Employee.BorderRadius = 34;
            this.btn_Workplace_Employee.CheckedState.Parent = this.btn_Workplace_Employee;
            this.btn_Workplace_Employee.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Workplace_Employee.CustomImages.Parent = this.btn_Workplace_Employee;
            this.btn_Workplace_Employee.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(188)))), ((int)(((byte)(156)))));
            this.btn_Workplace_Employee.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Workplace_Employee.ForeColor = System.Drawing.Color.White;
            this.btn_Workplace_Employee.HoverState.Parent = this.btn_Workplace_Employee;
            this.btn_Workplace_Employee.Image = global::Dormitory_Management_2021.Properties.Resources.place_marker_500px;
            this.btn_Workplace_Employee.ImageSize = new System.Drawing.Size(60, 60);
            this.btn_Workplace_Employee.Location = new System.Drawing.Point(1005, 16);
            this.btn_Workplace_Employee.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Workplace_Employee.Name = "btn_Workplace_Employee";
            this.btn_Workplace_Employee.ShadowDecoration.Parent = this.btn_Workplace_Employee;
            this.btn_Workplace_Employee.Size = new System.Drawing.Size(271, 70);
            this.btn_Workplace_Employee.TabIndex = 61;
            this.btn_Workplace_Employee.Text = "Địa Điểm";
            this.btn_Workplace_Employee.Click += new System.EventHandler(this.btn_Workplace_Employee_Click);
            // 
            // cb_Workplace_Employee
            // 
            this.cb_Workplace_Employee.AutoRoundedCorners = true;
            this.cb_Workplace_Employee.BackColor = System.Drawing.Color.Transparent;
            this.cb_Workplace_Employee.BorderRadius = 17;
            this.cb_Workplace_Employee.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cb_Workplace_Employee.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Workplace_Employee.FocusedColor = System.Drawing.Color.Empty;
            this.cb_Workplace_Employee.FocusedState.Parent = this.cb_Workplace_Employee;
            this.cb_Workplace_Employee.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cb_Workplace_Employee.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cb_Workplace_Employee.FormattingEnabled = true;
            this.cb_Workplace_Employee.HoverState.Parent = this.cb_Workplace_Employee;
            this.cb_Workplace_Employee.ItemHeight = 30;
            this.cb_Workplace_Employee.Items.AddRange(new object[] {
            "Trống",
            "Còn chỗ",
            "Đầy"});
            this.cb_Workplace_Employee.ItemsAppearance.Parent = this.cb_Workplace_Employee;
            this.cb_Workplace_Employee.Location = new System.Drawing.Point(1005, 91);
            this.cb_Workplace_Employee.Margin = new System.Windows.Forms.Padding(4);
            this.cb_Workplace_Employee.Name = "cb_Workplace_Employee";
            this.cb_Workplace_Employee.ShadowDecoration.Parent = this.cb_Workplace_Employee;
            this.cb_Workplace_Employee.Size = new System.Drawing.Size(269, 36);
            this.cb_Workplace_Employee.TabIndex = 60;
            // 
            // btn_Work_Employee
            // 
            this.btn_Work_Employee.AutoRoundedCorners = true;
            this.btn_Work_Employee.BorderColor = System.Drawing.Color.Transparent;
            this.btn_Work_Employee.BorderRadius = 34;
            this.btn_Work_Employee.CheckedState.Parent = this.btn_Work_Employee;
            this.btn_Work_Employee.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Work_Employee.CustomImages.Parent = this.btn_Work_Employee;
            this.btn_Work_Employee.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(188)))), ((int)(((byte)(156)))));
            this.btn_Work_Employee.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Work_Employee.ForeColor = System.Drawing.Color.White;
            this.btn_Work_Employee.HoverState.Parent = this.btn_Work_Employee;
            this.btn_Work_Employee.Image = global::Dormitory_Management_2021.Properties.Resources.work_500px;
            this.btn_Work_Employee.ImageSize = new System.Drawing.Size(60, 60);
            this.btn_Work_Employee.Location = new System.Drawing.Point(676, 16);
            this.btn_Work_Employee.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Work_Employee.Name = "btn_Work_Employee";
            this.btn_Work_Employee.ShadowDecoration.Parent = this.btn_Work_Employee;
            this.btn_Work_Employee.Size = new System.Drawing.Size(271, 70);
            this.btn_Work_Employee.TabIndex = 59;
            this.btn_Work_Employee.Text = "Công Việc";
            this.btn_Work_Employee.Click += new System.EventHandler(this.btn_Work_Employee_Click);
            // 
            // cb_Work_Employee
            // 
            this.cb_Work_Employee.AutoRoundedCorners = true;
            this.cb_Work_Employee.BackColor = System.Drawing.Color.Transparent;
            this.cb_Work_Employee.BorderRadius = 17;
            this.cb_Work_Employee.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cb_Work_Employee.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Work_Employee.FocusedColor = System.Drawing.Color.Empty;
            this.cb_Work_Employee.FocusedState.Parent = this.cb_Work_Employee;
            this.cb_Work_Employee.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cb_Work_Employee.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cb_Work_Employee.FormattingEnabled = true;
            this.cb_Work_Employee.HoverState.Parent = this.cb_Work_Employee;
            this.cb_Work_Employee.ItemHeight = 30;
            this.cb_Work_Employee.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cb_Work_Employee.ItemsAppearance.Parent = this.cb_Work_Employee;
            this.cb_Work_Employee.Location = new System.Drawing.Point(676, 91);
            this.cb_Work_Employee.Margin = new System.Windows.Forms.Padding(4);
            this.cb_Work_Employee.Name = "cb_Work_Employee";
            this.cb_Work_Employee.ShadowDecoration.Parent = this.cb_Work_Employee;
            this.cb_Work_Employee.Size = new System.Drawing.Size(269, 36);
            this.cb_Work_Employee.TabIndex = 58;
            // 
            // btn_Name_Employee
            // 
            this.btn_Name_Employee.AutoRoundedCorners = true;
            this.btn_Name_Employee.BorderColor = System.Drawing.Color.Transparent;
            this.btn_Name_Employee.BorderRadius = 34;
            this.btn_Name_Employee.CheckedState.Parent = this.btn_Name_Employee;
            this.btn_Name_Employee.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Name_Employee.CustomImages.Parent = this.btn_Name_Employee;
            this.btn_Name_Employee.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(188)))), ((int)(((byte)(156)))));
            this.btn_Name_Employee.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Name_Employee.ForeColor = System.Drawing.Color.White;
            this.btn_Name_Employee.HoverState.Parent = this.btn_Name_Employee;
            this.btn_Name_Employee.Image = global::Dormitory_Management_2021.Properties.Resources.contact_500px;
            this.btn_Name_Employee.ImageSize = new System.Drawing.Size(60, 60);
            this.btn_Name_Employee.Location = new System.Drawing.Point(17, 16);
            this.btn_Name_Employee.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Name_Employee.Name = "btn_Name_Employee";
            this.btn_Name_Employee.ShadowDecoration.Parent = this.btn_Name_Employee;
            this.btn_Name_Employee.Size = new System.Drawing.Size(271, 70);
            this.btn_Name_Employee.TabIndex = 57;
            this.btn_Name_Employee.Text = "Tên";
            this.btn_Name_Employee.Click += new System.EventHandler(this.btn_Name_Employee_Click);
            // 
            // txt_Home_Town_Employee
            // 
            this.txt_Home_Town_Employee.AutoRoundedCorners = true;
            this.txt_Home_Town_Employee.BorderRadius = 21;
            this.txt_Home_Town_Employee.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Home_Town_Employee.DefaultText = "";
            this.txt_Home_Town_Employee.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_Home_Town_Employee.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_Home_Town_Employee.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_Home_Town_Employee.DisabledState.Parent = this.txt_Home_Town_Employee;
            this.txt_Home_Town_Employee.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_Home_Town_Employee.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_Home_Town_Employee.FocusedState.Parent = this.txt_Home_Town_Employee;
            this.txt_Home_Town_Employee.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Home_Town_Employee.ForeColor = System.Drawing.Color.Black;
            this.txt_Home_Town_Employee.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_Home_Town_Employee.HoverState.Parent = this.txt_Home_Town_Employee;
            this.txt_Home_Town_Employee.Location = new System.Drawing.Point(347, 91);
            this.txt_Home_Town_Employee.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.txt_Home_Town_Employee.Name = "txt_Home_Town_Employee";
            this.txt_Home_Town_Employee.PasswordChar = '\0';
            this.txt_Home_Town_Employee.PlaceholderText = "hai phong";
            this.txt_Home_Town_Employee.SelectedText = "";
            this.txt_Home_Town_Employee.ShadowDecoration.Parent = this.txt_Home_Town_Employee;
            this.txt_Home_Town_Employee.Size = new System.Drawing.Size(271, 44);
            this.txt_Home_Town_Employee.TabIndex = 55;
            this.txt_Home_Town_Employee.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_Home_Town_Employee.TextChanged += new System.EventHandler(this.btn_Home_Town_Employee_Click);
            // 
            // btn_Home_Town_Employee
            // 
            this.btn_Home_Town_Employee.AutoRoundedCorners = true;
            this.btn_Home_Town_Employee.BorderColor = System.Drawing.Color.Transparent;
            this.btn_Home_Town_Employee.BorderRadius = 34;
            this.btn_Home_Town_Employee.CheckedState.Parent = this.btn_Home_Town_Employee;
            this.btn_Home_Town_Employee.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Home_Town_Employee.CustomImages.Parent = this.btn_Home_Town_Employee;
            this.btn_Home_Town_Employee.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(188)))), ((int)(((byte)(156)))));
            this.btn_Home_Town_Employee.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btn_Home_Town_Employee.ForeColor = System.Drawing.Color.White;
            this.btn_Home_Town_Employee.HoverState.Parent = this.btn_Home_Town_Employee;
            this.btn_Home_Town_Employee.Image = global::Dormitory_Management_2021.Properties.Resources.location_500px;
            this.btn_Home_Town_Employee.ImageSize = new System.Drawing.Size(40, 40);
            this.btn_Home_Town_Employee.Location = new System.Drawing.Point(347, 16);
            this.btn_Home_Town_Employee.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Home_Town_Employee.Name = "btn_Home_Town_Employee";
            this.btn_Home_Town_Employee.ShadowDecoration.Parent = this.btn_Home_Town_Employee;
            this.btn_Home_Town_Employee.Size = new System.Drawing.Size(271, 70);
            this.btn_Home_Town_Employee.TabIndex = 54;
            this.btn_Home_Town_Employee.Text = "Quê Quán";
            this.btn_Home_Town_Employee.Click += new System.EventHandler(this.btn_Home_Town_Employee_Click);
            // 
            // txt_Name_Employee
            // 
            this.txt_Name_Employee.AutoRoundedCorners = true;
            this.txt_Name_Employee.BorderRadius = 21;
            this.txt_Name_Employee.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Name_Employee.DefaultText = "";
            this.txt_Name_Employee.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_Name_Employee.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_Name_Employee.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_Name_Employee.DisabledState.Parent = this.txt_Name_Employee;
            this.txt_Name_Employee.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_Name_Employee.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_Name_Employee.FocusedState.Parent = this.txt_Name_Employee;
            this.txt_Name_Employee.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Name_Employee.ForeColor = System.Drawing.Color.Black;
            this.txt_Name_Employee.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_Name_Employee.HoverState.Parent = this.txt_Name_Employee;
            this.txt_Name_Employee.Location = new System.Drawing.Point(17, 91);
            this.txt_Name_Employee.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.txt_Name_Employee.Name = "txt_Name_Employee";
            this.txt_Name_Employee.PasswordChar = '\0';
            this.txt_Name_Employee.PlaceholderText = "dong";
            this.txt_Name_Employee.SelectedText = "";
            this.txt_Name_Employee.ShadowDecoration.Parent = this.txt_Name_Employee;
            this.txt_Name_Employee.Size = new System.Drawing.Size(271, 44);
            this.txt_Name_Employee.TabIndex = 62;
            this.txt_Name_Employee.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_Name_Employee.TextChanged += new System.EventHandler(this.btn_Name_Employee_Click);
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 20;
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
            this.btn_Excel.Location = new System.Drawing.Point(1581, 959);
            this.btn_Excel.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Excel.Name = "btn_Excel";
            this.btn_Excel.ShadowDecoration.Parent = this.btn_Excel;
            this.btn_Excel.Size = new System.Drawing.Size(275, 91);
            this.btn_Excel.TabIndex = 63;
            this.btn_Excel.Text = "Excel";
            this.btn_Excel.Click += new System.EventHandler(this.btn_Excel_Click);
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
            // hoten
            // 
            this.hoten.DataPropertyName = "hoten";
            this.hoten.HeaderText = "Họ Tên";
            this.hoten.MinimumWidth = 6;
            this.hoten.Name = "hoten";
            this.hoten.ReadOnly = true;
            // 
            // gioitinh
            // 
            this.gioitinh.DataPropertyName = "gioitinh";
            this.gioitinh.HeaderText = "Giới Tính";
            this.gioitinh.MinimumWidth = 6;
            this.gioitinh.Name = "gioitinh";
            this.gioitinh.ReadOnly = true;
            // 
            // cmnd
            // 
            this.cmnd.DataPropertyName = "cmnd";
            this.cmnd.HeaderText = "CMND";
            this.cmnd.MinimumWidth = 6;
            this.cmnd.Name = "cmnd";
            this.cmnd.ReadOnly = true;
            // 
            // diachi
            // 
            this.diachi.DataPropertyName = "diachi";
            this.diachi.HeaderText = "Địa Chỉ";
            this.diachi.MinimumWidth = 6;
            this.diachi.Name = "diachi";
            this.diachi.ReadOnly = true;
            // 
            // quequan
            // 
            this.quequan.DataPropertyName = "quequan";
            this.quequan.HeaderText = "Quê Quán";
            this.quequan.MinimumWidth = 6;
            this.quequan.Name = "quequan";
            this.quequan.ReadOnly = true;
            // 
            // congviec
            // 
            this.congviec.DataPropertyName = "congviec";
            this.congviec.HeaderText = "Công Việc";
            this.congviec.MinimumWidth = 6;
            this.congviec.Name = "congviec";
            this.congviec.ReadOnly = true;
            // 
            // luong
            // 
            this.luong.DataPropertyName = "luong";
            this.luong.HeaderText = "Lương";
            this.luong.MinimumWidth = 6;
            this.luong.Name = "luong";
            this.luong.ReadOnly = true;
            // 
            // sdt
            // 
            this.sdt.DataPropertyName = "sdt";
            this.sdt.HeaderText = "Số Điện Thoại";
            this.sdt.MinimumWidth = 6;
            this.sdt.Name = "sdt";
            this.sdt.ReadOnly = true;
            // 
            // UCNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.Controls.Add(this.btn_Excel);
            this.Controls.Add(this.txt_Name_Employee);
            this.Controls.Add(this.btn_Workplace_Employee);
            this.Controls.Add(this.cb_Workplace_Employee);
            this.Controls.Add(this.btn_Work_Employee);
            this.Controls.Add(this.cb_Work_Employee);
            this.Controls.Add(this.btn_Name_Employee);
            this.Controls.Add(this.txt_Home_Town_Employee);
            this.Controls.Add(this.btn_Home_Town_Employee);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btn_Refresh);
            this.Controls.Add(this.dgv);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UCNhanVien";
            this.Size = new System.Drawing.Size(1873, 1063);
            this.Load += new System.EventHandler(this.UC_NhanVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        public Bunifu.Framework.UI.BunifuCustomDataGrid dgv;
        private Guna.UI2.WinForms.Guna2Button btn_Refresh;
        private Guna.UI2.WinForms.Guna2Button btnAdd;
        private Guna.UI2.WinForms.Guna2Button btn_Workplace_Employee;
        private Guna.UI2.WinForms.Guna2ComboBox cb_Workplace_Employee;
        private Guna.UI2.WinForms.Guna2Button btn_Work_Employee;
        private Guna.UI2.WinForms.Guna2ComboBox cb_Work_Employee;
        private Guna.UI2.WinForms.Guna2Button btn_Name_Employee;
        private Guna.UI2.WinForms.Guna2TextBox txt_Home_Town_Employee;
        private Guna.UI2.WinForms.Guna2Button btn_Home_Town_Employee;
        private Guna.UI2.WinForms.Guna2TextBox txt_Name_Employee;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Button btn_Excel;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn hoten;
        private System.Windows.Forms.DataGridViewTextBoxColumn gioitinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmnd;
        private System.Windows.Forms.DataGridViewTextBoxColumn diachi;
        private System.Windows.Forms.DataGridViewTextBoxColumn quequan;
        private System.Windows.Forms.DataGridViewTextBoxColumn congviec;
        private System.Windows.Forms.DataGridViewTextBoxColumn luong;
        private System.Windows.Forms.DataGridViewTextBoxColumn sdt;
    }
}
