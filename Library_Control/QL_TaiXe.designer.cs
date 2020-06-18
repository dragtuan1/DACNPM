namespace DACNPM.Library_Control
{
    partial class QL_TaiXe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QL_TaiXe));
            this.gw_khachhang = new System.Windows.Forms.DataGridView();
            this.customer_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ma_kh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customer_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phones = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.ten_xe = new System.Windows.Forms.ComboBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.status = new System.Windows.Forms.CheckBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.phone = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dia_chi = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_reset = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_edit = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.ten_khach_hang = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ma_khach_hang = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gw_khachhang)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gw_khachhang
            // 
            this.gw_khachhang.AllowUserToAddRows = false;
            this.gw_khachhang.AllowUserToDeleteRows = false;
            this.gw_khachhang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gw_khachhang.BackgroundColor = System.Drawing.SystemColors.Info;
            this.gw_khachhang.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.gw_khachhang.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.gw_khachhang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gw_khachhang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.customer_id,
            this.STT,
            this.ma_kh,
            this.customer_name,
            this.address,
            this.phones,
            this.description,
            this.Column1});
            this.gw_khachhang.Location = new System.Drawing.Point(21, 473);
            this.gw_khachhang.Margin = new System.Windows.Forms.Padding(4);
            this.gw_khachhang.Name = "gw_khachhang";
            this.gw_khachhang.ReadOnly = true;
            this.gw_khachhang.RowHeadersWidth = 51;
            this.gw_khachhang.Size = new System.Drawing.Size(1062, 193);
            this.gw_khachhang.TabIndex = 24;
            // 
            // customer_id
            // 
            this.customer_id.DataPropertyName = "customer_id";
            this.customer_id.HeaderText = "ID";
            this.customer_id.MinimumWidth = 6;
            this.customer_id.Name = "customer_id";
            this.customer_id.ReadOnly = true;
            this.customer_id.Visible = false;
            // 
            // STT
            // 
            this.STT.HeaderText = "STT";
            this.STT.MinimumWidth = 6;
            this.STT.Name = "STT";
            this.STT.ReadOnly = true;
            // 
            // ma_kh
            // 
            this.ma_kh.DataPropertyName = "ma_kh";
            this.ma_kh.HeaderText = "Mã Khách Hàng";
            this.ma_kh.MinimumWidth = 6;
            this.ma_kh.Name = "ma_kh";
            this.ma_kh.ReadOnly = true;
            // 
            // customer_name
            // 
            this.customer_name.DataPropertyName = "customer_name";
            this.customer_name.HeaderText = "Tên Khách Hàng";
            this.customer_name.MinimumWidth = 6;
            this.customer_name.Name = "customer_name";
            this.customer_name.ReadOnly = true;
            // 
            // address
            // 
            this.address.DataPropertyName = "address";
            this.address.HeaderText = "Địa Chỉ";
            this.address.MinimumWidth = 6;
            this.address.Name = "address";
            this.address.ReadOnly = true;
            // 
            // phones
            // 
            this.phones.DataPropertyName = "phone";
            this.phones.HeaderText = "Điện Thoại";
            this.phones.MinimumWidth = 6;
            this.phones.Name = "phones";
            this.phones.ReadOnly = true;
            // 
            // description
            // 
            this.description.DataPropertyName = "description";
            this.description.HeaderText = "CMND";
            this.description.MinimumWidth = 6;
            this.description.Name = "description";
            this.description.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Bằng Lái";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(29, 441);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(190, 21);
            this.label6.TabIndex = 25;
            this.label6.Text = "Danh Sách Chi Tiết Tài Xế";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.ten_xe);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.status);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.phone);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.dia_chi);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.btn_reset);
            this.groupBox1.Controls.Add(this.btn_delete);
            this.groupBox1.Controls.Add(this.btn_edit);
            this.groupBox1.Controls.Add(this.btn_add);
            this.groupBox1.Controls.Add(this.ten_khach_hang);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.ma_khach_hang);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.groupBox1.Location = new System.Drawing.Point(32, 38);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(1051, 394);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Còn Bảo Hành",
            "Hết Bảo Hành"});
            this.comboBox1.Location = new System.Drawing.Point(686, 338);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(312, 33);
            this.comboBox1.TabIndex = 47;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.Info;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(497, 338);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Padding = new System.Windows.Forms.Padding(31, 0, 0, 0);
            this.button2.Size = new System.Drawing.Size(140, 49);
            this.button2.TabIndex = 46;
            this.button2.Text = "     Sort";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Info;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(497, 274);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(31, 0, 0, 0);
            this.button1.Size = new System.Drawing.Size(140, 49);
            this.button1.TabIndex = 45;
            this.button1.Text = "Tìm Kiếm";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // ten_xe
            // 
            this.ten_xe.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ten_xe.FormattingEnabled = true;
            this.ten_xe.Items.AddRange(new object[] {
            "Còn Bảo Hành",
            "Hết Bảo Hành"});
            this.ten_xe.Location = new System.Drawing.Point(686, 278);
            this.ten_xe.Margin = new System.Windows.Forms.Padding(4);
            this.ten_xe.Name = "ten_xe";
            this.ten_xe.Size = new System.Drawing.Size(137, 33);
            this.ten_xe.TabIndex = 43;
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.White;
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(847, 278);
            this.textBox3.Margin = new System.Windows.Forms.Padding(4);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(151, 40);
            this.textBox3.TabIndex = 42;
            // 
            // status
            // 
            this.status.AutoSize = true;
            this.status.Checked = true;
            this.status.CheckState = System.Windows.Forms.CheckState.Checked;
            this.status.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.status.Location = new System.Drawing.Point(789, 33);
            this.status.Margin = new System.Windows.Forms.Padding(4);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(102, 24);
            this.status.TabIndex = 36;
            this.status.Text = "Trạng Thái";
            this.status.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.White;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(686, 212);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(312, 45);
            this.textBox2.TabIndex = 35;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label4.Location = new System.Drawing.Point(539, 222);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 16);
            this.label4.TabIndex = 34;
            this.label4.Text = "Bằng Lái:";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.White;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(686, 144);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(312, 45);
            this.textBox1.TabIndex = 33;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label1.Location = new System.Drawing.Point(539, 154);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 16);
            this.label1.TabIndex = 32;
            this.label1.Text = "CMND:";
            // 
            // phone
            // 
            this.phone.BackColor = System.Drawing.Color.White;
            this.phone.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phone.Location = new System.Drawing.Point(686, 81);
            this.phone.Margin = new System.Windows.Forms.Padding(4);
            this.phone.Multiline = true;
            this.phone.Name = "phone";
            this.phone.Size = new System.Drawing.Size(312, 45);
            this.phone.TabIndex = 31;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label11.Location = new System.Drawing.Point(536, 92);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(96, 16);
            this.label11.TabIndex = 30;
            this.label11.Text = "Số Điện Thoại:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label8.Location = new System.Drawing.Point(31, 211);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 16);
            this.label8.TabIndex = 21;
            this.label8.Text = "Địa Chỉ:";
            // 
            // dia_chi
            // 
            this.dia_chi.BackColor = System.Drawing.Color.White;
            this.dia_chi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dia_chi.Location = new System.Drawing.Point(177, 201);
            this.dia_chi.Margin = new System.Windows.Forms.Padding(4);
            this.dia_chi.Multiline = true;
            this.dia_chi.Name = "dia_chi";
            this.dia_chi.Size = new System.Drawing.Size(300, 45);
            this.dia_chi.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(8, 0);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 21);
            this.label5.TabIndex = 17;
            this.label5.Text = "Thông Tin Tài Xế";
            // 
            // btn_reset
            // 
            this.btn_reset.BackColor = System.Drawing.SystemColors.Info;
            this.btn_reset.FlatAppearance.BorderSize = 0;
            this.btn_reset.Image = ((System.Drawing.Image)(resources.GetObject("btn_reset.Image")));
            this.btn_reset.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_reset.Location = new System.Drawing.Point(294, 338);
            this.btn_reset.Margin = new System.Windows.Forms.Padding(4);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btn_reset.Size = new System.Drawing.Size(147, 49);
            this.btn_reset.TabIndex = 11;
            this.btn_reset.Text = "         Nhập Lại";
            this.btn_reset.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_reset.UseVisualStyleBackColor = false;
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.SystemColors.Info;
            this.btn_delete.FlatAppearance.BorderSize = 0;
            this.btn_delete.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_delete.Image = ((System.Drawing.Image)(resources.GetObject("btn_delete.Image")));
            this.btn_delete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_delete.Location = new System.Drawing.Point(82, 333);
            this.btn_delete.Margin = new System.Windows.Forms.Padding(4);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Padding = new System.Windows.Forms.Padding(31, 0, 0, 0);
            this.btn_delete.Size = new System.Drawing.Size(153, 49);
            this.btn_delete.TabIndex = 15;
            this.btn_delete.Text = "         Xóa";
            this.btn_delete.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_delete.UseVisualStyleBackColor = false;
            // 
            // btn_edit
            // 
            this.btn_edit.BackColor = System.Drawing.SystemColors.Info;
            this.btn_edit.FlatAppearance.BorderSize = 0;
            this.btn_edit.Image = ((System.Drawing.Image)(resources.GetObject("btn_edit.Image")));
            this.btn_edit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_edit.Location = new System.Drawing.Point(294, 269);
            this.btn_edit.Margin = new System.Windows.Forms.Padding(4);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(147, 49);
            this.btn_edit.TabIndex = 13;
            this.btn_edit.Text = "        Sửa Thông Tin";
            this.btn_edit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_edit.UseVisualStyleBackColor = false;
            // 
            // btn_add
            // 
            this.btn_add.BackColor = System.Drawing.SystemColors.Info;
            this.btn_add.FlatAppearance.BorderSize = 0;
            this.btn_add.Image = ((System.Drawing.Image)(resources.GetObject("btn_add.Image")));
            this.btn_add.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_add.Location = new System.Drawing.Point(80, 269);
            this.btn_add.Margin = new System.Windows.Forms.Padding(4);
            this.btn_add.Name = "btn_add";
            this.btn_add.Padding = new System.Windows.Forms.Padding(17, 0, 0, 0);
            this.btn_add.Size = new System.Drawing.Size(155, 49);
            this.btn_add.TabIndex = 12;
            this.btn_add.Text = "         Thêm Mới";
            this.btn_add.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_add.UseVisualStyleBackColor = false;
            // 
            // ten_khach_hang
            // 
            this.ten_khach_hang.BackColor = System.Drawing.Color.White;
            this.ten_khach_hang.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ten_khach_hang.Location = new System.Drawing.Point(177, 140);
            this.ten_khach_hang.Margin = new System.Windows.Forms.Padding(4);
            this.ten_khach_hang.Multiline = true;
            this.ten_khach_hang.Name = "ten_khach_hang";
            this.ten_khach_hang.Size = new System.Drawing.Size(300, 45);
            this.ten_khach_hang.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label3.Location = new System.Drawing.Point(28, 151);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tên Tài Xế:";
            // 
            // ma_khach_hang
            // 
            this.ma_khach_hang.BackColor = System.Drawing.Color.White;
            this.ma_khach_hang.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ma_khach_hang.Location = new System.Drawing.Point(177, 81);
            this.ma_khach_hang.Margin = new System.Windows.Forms.Padding(4);
            this.ma_khach_hang.Multiline = true;
            this.ma_khach_hang.Name = "ma_khach_hang";
            this.ma_khach_hang.Size = new System.Drawing.Size(300, 45);
            this.ma_khach_hang.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label2.Location = new System.Drawing.Point(28, 92);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã Tài Xế:";
            // 
            // QL_TaiXe
            // 
            this.Controls.Add(this.gw_khachhang);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox1);
            this.Name = "QL_TaiXe";
            this.Size = new System.Drawing.Size(1100, 700);
            ((System.ComponentModel.ISupportInitialize)(this.gw_khachhang)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gw_khachhang;
        private System.Windows.Forms.DataGridViewTextBoxColumn customer_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn ma_kh;
        private System.Windows.Forms.DataGridViewTextBoxColumn customer_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn address;
        private System.Windows.Forms.DataGridViewTextBoxColumn phones;
        private System.Windows.Forms.DataGridViewTextBoxColumn description;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox ten_xe;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.CheckBox status;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox phone;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox dia_chi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.TextBox ten_khach_hang;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ma_khach_hang;
        private System.Windows.Forms.Label label2;
    }
}
