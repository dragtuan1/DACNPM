namespace DACNPM.Library_Control
{
    partial class QL_HopDong
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QL_HopDong));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.customer_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.created_at = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.return_at = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pn_chitiet = new System.Windows.Forms.Panel();
            this.label14 = new System.Windows.Forms.Label();
            this.cancel_ct = new System.Windows.Forms.Button();
            this.reset_ct = new System.Windows.Forms.Button();
            this.xoa_ct = new System.Windows.Forms.Button();
            this.save_ct = new System.Windows.Forms.Button();
            this.sua_ct = new System.Windows.Forms.Button();
            this.them_ct = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.ma_hd_2 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.gw_chitiethoadon = new System.Windows.Forms.DataGridView();
            this.order_detail_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.STTs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ma_cthd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.order_ids = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.car_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.full_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ma_hds = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.status = new System.Windows.Forms.CheckBox();
            this.ngaytra = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.ngaythem = new System.Windows.Forms.DateTimePicker();
            this.label12 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.cancel_hd = new System.Windows.Forms.Button();
            this.reset_hd = new System.Windows.Forms.Button();
            this.xoa_hd = new System.Windows.Forms.Button();
            this.save_hd = new System.Windows.Forms.Button();
            this.sua_hd = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.them_hd = new System.Windows.Forms.Button();
            this.tongtien = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.gw_hoadon = new System.Windows.Forms.DataGridView();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.pn_chitiet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gw_chitiethoadon)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gw_hoadon)).BeginInit();
            this.SuspendLayout();
            // 
            // customer_name
            // 
            this.customer_name.DataPropertyName = "customer_name";
            this.customer_name.HeaderText = "Tên Khách Hàng";
            this.customer_name.Name = "customer_name";
            this.customer_name.ReadOnly = true;
            // 
            // created_at
            // 
            this.created_at.DataPropertyName = "created_at";
            this.created_at.HeaderText = "Ngày Thuê";
            this.created_at.Name = "created_at";
            this.created_at.ReadOnly = true;
            // 
            // return_at
            // 
            this.return_at.HeaderText = "Ngày Trả";
            this.return_at.Name = "return_at";
            this.return_at.ReadOnly = true;
            // 
            // total
            // 
            this.total.DataPropertyName = "total";
            dataGridViewCellStyle5.Format = "#,###";
            this.total.DefaultCellStyle = dataGridViewCellStyle5;
            this.total.HeaderText = "Tổng Tiền";
            this.total.Name = "total";
            this.total.ReadOnly = true;
            // 
            // pn_chitiet
            // 
            this.pn_chitiet.Controls.Add(this.textBox1);
            this.pn_chitiet.Controls.Add(this.label14);
            this.pn_chitiet.Controls.Add(this.cancel_ct);
            this.pn_chitiet.Controls.Add(this.reset_ct);
            this.pn_chitiet.Controls.Add(this.xoa_ct);
            this.pn_chitiet.Controls.Add(this.save_ct);
            this.pn_chitiet.Controls.Add(this.sua_ct);
            this.pn_chitiet.Controls.Add(this.them_ct);
            this.pn_chitiet.Controls.Add(this.label8);
            this.pn_chitiet.Controls.Add(this.ma_hd_2);
            this.pn_chitiet.Controls.Add(this.label7);
            this.pn_chitiet.Controls.Add(this.gw_chitiethoadon);
            this.pn_chitiet.Location = new System.Drawing.Point(14, 362);
            this.pn_chitiet.Name = "pn_chitiet";
            this.pn_chitiet.Size = new System.Drawing.Size(1019, 295);
            this.pn_chitiet.TabIndex = 8;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Red;
            this.label14.Location = new System.Drawing.Point(577, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(341, 30);
            this.label14.TabIndex = 42;
            this.label14.Text = "THÔNG TIN CHI TIẾT HỢP ĐỒNG";
            // 
            // cancel_ct
            // 
            this.cancel_ct.BackColor = System.Drawing.SystemColors.Info;
            this.cancel_ct.FlatAppearance.BorderSize = 0;
            this.cancel_ct.Image = ((System.Drawing.Image)(resources.GetObject("cancel_ct.Image")));
            this.cancel_ct.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cancel_ct.Location = new System.Drawing.Point(242, 239);
            this.cancel_ct.Name = "cancel_ct";
            this.cancel_ct.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.cancel_ct.Size = new System.Drawing.Size(110, 40);
            this.cancel_ct.TabIndex = 37;
            this.cancel_ct.Text = "         Hủy";
            this.cancel_ct.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cancel_ct.UseVisualStyleBackColor = false;
            // 
            // reset_ct
            // 
            this.reset_ct.BackColor = System.Drawing.SystemColors.Info;
            this.reset_ct.FlatAppearance.BorderSize = 0;
            this.reset_ct.Image = ((System.Drawing.Image)(resources.GetObject("reset_ct.Image")));
            this.reset_ct.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.reset_ct.Location = new System.Drawing.Point(10, 239);
            this.reset_ct.Name = "reset_ct";
            this.reset_ct.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.reset_ct.Size = new System.Drawing.Size(111, 40);
            this.reset_ct.TabIndex = 32;
            this.reset_ct.Text = "         Nhập Lại";
            this.reset_ct.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.reset_ct.UseVisualStyleBackColor = false;
            // 
            // xoa_ct
            // 
            this.xoa_ct.BackColor = System.Drawing.SystemColors.Info;
            this.xoa_ct.FlatAppearance.BorderSize = 0;
            this.xoa_ct.ForeColor = System.Drawing.SystemColors.ControlText;
            this.xoa_ct.Image = ((System.Drawing.Image)(resources.GetObject("xoa_ct.Image")));
            this.xoa_ct.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.xoa_ct.Location = new System.Drawing.Point(242, 193);
            this.xoa_ct.Name = "xoa_ct";
            this.xoa_ct.Padding = new System.Windows.Forms.Padding(23, 0, 0, 0);
            this.xoa_ct.Size = new System.Drawing.Size(110, 40);
            this.xoa_ct.TabIndex = 36;
            this.xoa_ct.Text = "         Xóa";
            this.xoa_ct.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.xoa_ct.UseVisualStyleBackColor = false;
            // 
            // save_ct
            // 
            this.save_ct.BackColor = System.Drawing.SystemColors.Info;
            this.save_ct.FlatAppearance.BorderSize = 0;
            this.save_ct.Image = ((System.Drawing.Image)(resources.GetObject("save_ct.Image")));
            this.save_ct.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.save_ct.Location = new System.Drawing.Point(126, 239);
            this.save_ct.Name = "save_ct";
            this.save_ct.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.save_ct.Size = new System.Drawing.Size(110, 40);
            this.save_ct.TabIndex = 35;
            this.save_ct.Text = "          Lưu Lại";
            this.save_ct.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.save_ct.UseVisualStyleBackColor = false;
            // 
            // sua_ct
            // 
            this.sua_ct.BackColor = System.Drawing.SystemColors.Info;
            this.sua_ct.FlatAppearance.BorderSize = 0;
            this.sua_ct.Image = ((System.Drawing.Image)(resources.GetObject("sua_ct.Image")));
            this.sua_ct.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.sua_ct.Location = new System.Drawing.Point(126, 193);
            this.sua_ct.Name = "sua_ct";
            this.sua_ct.Size = new System.Drawing.Size(110, 40);
            this.sua_ct.TabIndex = 34;
            this.sua_ct.Text = "        Sửa Thông Tin";
            this.sua_ct.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.sua_ct.UseVisualStyleBackColor = false;
            // 
            // them_ct
            // 
            this.them_ct.BackColor = System.Drawing.SystemColors.Info;
            this.them_ct.FlatAppearance.BorderSize = 0;
            this.them_ct.Image = ((System.Drawing.Image)(resources.GetObject("them_ct.Image")));
            this.them_ct.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.them_ct.Location = new System.Drawing.Point(10, 193);
            this.them_ct.Name = "them_ct";
            this.them_ct.Padding = new System.Windows.Forms.Padding(13, 0, 0, 0);
            this.them_ct.Size = new System.Drawing.Size(110, 40);
            this.them_ct.TabIndex = 33;
            this.them_ct.Text = "         Thêm Mới";
            this.them_ct.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.them_ct.UseVisualStyleBackColor = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label8.Location = new System.Drawing.Point(37, 108);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 16);
            this.label8.TabIndex = 27;
            this.label8.Text = "Biển số xe:";
            // 
            // ma_hd_2
            // 
            this.ma_hd_2.BackColor = System.Drawing.Color.White;
            this.ma_hd_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ma_hd_2.Location = new System.Drawing.Point(117, 64);
            this.ma_hd_2.Multiline = true;
            this.ma_hd_2.Name = "ma_hd_2";
            this.ma_hd_2.Size = new System.Drawing.Size(215, 25);
            this.ma_hd_2.TabIndex = 25;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label7.Location = new System.Drawing.Point(25, 73);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 16);
            this.label7.TabIndex = 24;
            this.label7.Text = "Mã Hóa Đơn:";
            // 
            // gw_chitiethoadon
            // 
            this.gw_chitiethoadon.AllowUserToAddRows = false;
            this.gw_chitiethoadon.AllowUserToDeleteRows = false;
            this.gw_chitiethoadon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gw_chitiethoadon.BackgroundColor = System.Drawing.SystemColors.Info;
            this.gw_chitiethoadon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gw_chitiethoadon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.order_detail_id,
            this.STTs,
            this.ma_cthd,
            this.order_ids,
            this.car_name,
            this.price});
            this.gw_chitiethoadon.Location = new System.Drawing.Point(398, 33);
            this.gw_chitiethoadon.Name = "gw_chitiethoadon";
            this.gw_chitiethoadon.ReadOnly = true;
            this.gw_chitiethoadon.Size = new System.Drawing.Size(600, 246);
            this.gw_chitiethoadon.TabIndex = 23;
            // 
            // order_detail_id
            // 
            this.order_detail_id.DataPropertyName = "order_detail_id";
            this.order_detail_id.HeaderText = "ID";
            this.order_detail_id.Name = "order_detail_id";
            this.order_detail_id.ReadOnly = true;
            this.order_detail_id.Visible = false;
            // 
            // STTs
            // 
            this.STTs.HeaderText = "STT";
            this.STTs.Name = "STTs";
            this.STTs.ReadOnly = true;
            // 
            // ma_cthd
            // 
            this.ma_cthd.DataPropertyName = "ma_cthd";
            this.ma_cthd.HeaderText = "Mã CT Hóa Đơn";
            this.ma_cthd.Name = "ma_cthd";
            this.ma_cthd.ReadOnly = true;
            // 
            // order_ids
            // 
            this.order_ids.DataPropertyName = "ma_hd";
            this.order_ids.HeaderText = "Mã Hóa Đơn";
            this.order_ids.Name = "order_ids";
            this.order_ids.ReadOnly = true;
            // 
            // car_name
            // 
            this.car_name.DataPropertyName = "car_name";
            this.car_name.HeaderText = "Tên Xe";
            this.car_name.Name = "car_name";
            this.car_name.ReadOnly = true;
            // 
            // price
            // 
            this.price.DataPropertyName = "price";
            dataGridViewCellStyle6.Format = "#,###";
            this.price.DefaultCellStyle = dataGridViewCellStyle6;
            this.price.HeaderText = "Giá";
            this.price.Name = "price";
            this.price.ReadOnly = true;
            // 
            // full_name
            // 
            this.full_name.DataPropertyName = "full_name";
            this.full_name.HeaderText = "Tên Nhân Viên";
            this.full_name.Name = "full_name";
            this.full_name.ReadOnly = true;
            // 
            // ma_hds
            // 
            this.ma_hds.DataPropertyName = "ma_hd";
            this.ma_hds.HeaderText = "Mã Hóa Đơn";
            this.ma_hds.Name = "ma_hds";
            this.ma_hds.ReadOnly = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.textBox4);
            this.panel3.Controls.Add(this.textBox3);
            this.panel3.Controls.Add(this.textBox2);
            this.panel3.Controls.Add(this.status);
            this.panel3.Controls.Add(this.ngaytra);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.ngaythem);
            this.panel3.Controls.Add(this.label12);
            this.panel3.Controls.Add(this.comboBox1);
            this.panel3.Controls.Add(this.label15);
            this.panel3.Controls.Add(this.label13);
            this.panel3.Controls.Add(this.cancel_hd);
            this.panel3.Controls.Add(this.reset_hd);
            this.panel3.Controls.Add(this.xoa_hd);
            this.panel3.Controls.Add(this.save_hd);
            this.panel3.Controls.Add(this.sua_hd);
            this.panel3.Controls.Add(this.button1);
            this.panel3.Controls.Add(this.them_hd);
            this.panel3.Controls.Add(this.tongtien);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.gw_hoadon);
            this.panel3.Location = new System.Drawing.Point(13, 20);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1021, 346);
            this.panel3.TabIndex = 7;
            // 
            // status
            // 
            this.status.AutoSize = true;
            this.status.Checked = true;
            this.status.CheckState = System.Windows.Forms.CheckState.Checked;
            this.status.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.status.Location = new System.Drawing.Point(117, 266);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(99, 24);
            this.status.TabIndex = 56;
            this.status.Text = "Trạng thái";
            this.status.UseVisualStyleBackColor = true;
            // 
            // ngaytra
            // 
            this.ngaytra.CustomFormat = "dd-MM-yyyy";
            this.ngaytra.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ngaytra.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.ngaytra.Location = new System.Drawing.Point(117, 187);
            this.ngaytra.Name = "ngaytra";
            this.ngaytra.Size = new System.Drawing.Size(215, 29);
            this.ngaytra.TabIndex = 47;
            this.ngaytra.Value = new System.DateTime(2020, 5, 23, 16, 10, 16, 0);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label1.Location = new System.Drawing.Point(3, 197);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 16);
            this.label1.TabIndex = 46;
            this.label1.Text = "Ngày Trả:";
            // 
            // ngaythem
            // 
            this.ngaythem.CustomFormat = "dd-MM-yyyy";
            this.ngaythem.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ngaythem.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.ngaythem.Location = new System.Drawing.Point(117, 152);
            this.ngaythem.Name = "ngaythem";
            this.ngaythem.Size = new System.Drawing.Size(215, 29);
            this.ngaythem.TabIndex = 47;
            this.ngaythem.Value = new System.DateTime(2020, 5, 23, 16, 10, 16, 0);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label12.Location = new System.Drawing.Point(3, 162);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(78, 16);
            this.label12.TabIndex = 46;
            this.label12.Text = "Ngày Thuê:";
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "SĐT",
            "Tên khách hàng"});
            this.comboBox1.Location = new System.Drawing.Point(117, 298);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(86, 33);
            this.comboBox1.TabIndex = 44;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Red;
            this.label15.Location = new System.Drawing.Point(338, 228);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(43, 21);
            this.label15.TabIndex = 43;
            this.label15.Text = "VNĐ";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Red;
            this.label13.Location = new System.Drawing.Point(622, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(251, 30);
            this.label13.TabIndex = 41;
            this.label13.Text = "THÔNG TIN HỢP ĐỒNG";
            // 
            // cancel_hd
            // 
            this.cancel_hd.BackColor = System.Drawing.SystemColors.Info;
            this.cancel_hd.FlatAppearance.BorderSize = 0;
            this.cancel_hd.Image = ((System.Drawing.Image)(resources.GetObject("cancel_hd.Image")));
            this.cancel_hd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cancel_hd.Location = new System.Drawing.Point(635, 296);
            this.cancel_hd.Name = "cancel_hd";
            this.cancel_hd.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.cancel_hd.Size = new System.Drawing.Size(110, 40);
            this.cancel_hd.TabIndex = 21;
            this.cancel_hd.Text = "         Hủy";
            this.cancel_hd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cancel_hd.UseVisualStyleBackColor = false;
            // 
            // reset_hd
            // 
            this.reset_hd.BackColor = System.Drawing.SystemColors.Info;
            this.reset_hd.FlatAppearance.BorderSize = 0;
            this.reset_hd.Image = ((System.Drawing.Image)(resources.GetObject("reset_hd.Image")));
            this.reset_hd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.reset_hd.Location = new System.Drawing.Point(403, 296);
            this.reset_hd.Name = "reset_hd";
            this.reset_hd.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.reset_hd.Size = new System.Drawing.Size(110, 40);
            this.reset_hd.TabIndex = 16;
            this.reset_hd.Text = "         Nhập Lại";
            this.reset_hd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.reset_hd.UseVisualStyleBackColor = false;
            // 
            // xoa_hd
            // 
            this.xoa_hd.BackColor = System.Drawing.SystemColors.Info;
            this.xoa_hd.FlatAppearance.BorderSize = 0;
            this.xoa_hd.ForeColor = System.Drawing.SystemColors.ControlText;
            this.xoa_hd.Image = ((System.Drawing.Image)(resources.GetObject("xoa_hd.Image")));
            this.xoa_hd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.xoa_hd.Location = new System.Drawing.Point(635, 250);
            this.xoa_hd.Name = "xoa_hd";
            this.xoa_hd.Padding = new System.Windows.Forms.Padding(23, 0, 0, 0);
            this.xoa_hd.Size = new System.Drawing.Size(110, 40);
            this.xoa_hd.TabIndex = 20;
            this.xoa_hd.Text = "         Xóa";
            this.xoa_hd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.xoa_hd.UseVisualStyleBackColor = false;
            // 
            // save_hd
            // 
            this.save_hd.BackColor = System.Drawing.SystemColors.Info;
            this.save_hd.FlatAppearance.BorderSize = 0;
            this.save_hd.Image = ((System.Drawing.Image)(resources.GetObject("save_hd.Image")));
            this.save_hd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.save_hd.Location = new System.Drawing.Point(519, 296);
            this.save_hd.Name = "save_hd";
            this.save_hd.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.save_hd.Size = new System.Drawing.Size(110, 40);
            this.save_hd.TabIndex = 19;
            this.save_hd.Text = "          Lưu Lại";
            this.save_hd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.save_hd.UseVisualStyleBackColor = false;
            // 
            // sua_hd
            // 
            this.sua_hd.BackColor = System.Drawing.SystemColors.Info;
            this.sua_hd.FlatAppearance.BorderSize = 0;
            this.sua_hd.Image = ((System.Drawing.Image)(resources.GetObject("sua_hd.Image")));
            this.sua_hd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.sua_hd.Location = new System.Drawing.Point(519, 250);
            this.sua_hd.Name = "sua_hd";
            this.sua_hd.Size = new System.Drawing.Size(110, 40);
            this.sua_hd.TabIndex = 18;
            this.sua_hd.Text = "        Sửa Thông Tin";
            this.sua_hd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.sua_hd.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Info;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(1, 296);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(13, 0, 0, 0);
            this.button1.Size = new System.Drawing.Size(110, 40);
            this.button1.TabIndex = 17;
            this.button1.Text = "         Tìm kiếm";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // them_hd
            // 
            this.them_hd.BackColor = System.Drawing.SystemColors.Info;
            this.them_hd.FlatAppearance.BorderSize = 0;
            this.them_hd.Image = ((System.Drawing.Image)(resources.GetObject("them_hd.Image")));
            this.them_hd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.them_hd.Location = new System.Drawing.Point(403, 250);
            this.them_hd.Name = "them_hd";
            this.them_hd.Padding = new System.Windows.Forms.Padding(13, 0, 0, 0);
            this.them_hd.Size = new System.Drawing.Size(110, 40);
            this.them_hd.TabIndex = 17;
            this.them_hd.Text = "         Thêm Mới";
            this.them_hd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.them_hd.UseVisualStyleBackColor = false;
            this.them_hd.Click += new System.EventHandler(this.them_hd_Click);
            // 
            // tongtien
            // 
            this.tongtien.BackColor = System.Drawing.Color.White;
            this.tongtien.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tongtien.Location = new System.Drawing.Point(117, 222);
            this.tongtien.Multiline = true;
            this.tongtien.Name = "tongtien";
            this.tongtien.Size = new System.Drawing.Size(215, 27);
            this.tongtien.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label5.Location = new System.Drawing.Point(3, 233);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Tổng Tiền:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label3.Location = new System.Drawing.Point(8, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "CMND";
            // 
            // gw_hoadon
            // 
            this.gw_hoadon.AllowUserToAddRows = false;
            this.gw_hoadon.AllowUserToDeleteRows = false;
            this.gw_hoadon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gw_hoadon.BackgroundColor = System.Drawing.SystemColors.Info;
            this.gw_hoadon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gw_hoadon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.ma_hds,
            this.customer_name,
            this.full_name,
            this.created_at,
            this.return_at,
            this.total});
            this.gw_hoadon.Location = new System.Drawing.Point(399, 33);
            this.gw_hoadon.Name = "gw_hoadon";
            this.gw_hoadon.ReadOnly = true;
            this.gw_hoadon.Size = new System.Drawing.Size(600, 211);
            this.gw_hoadon.TabIndex = 0;
            // 
            // STT
            // 
            this.STT.HeaderText = "STT";
            this.STT.Name = "STT";
            this.STT.ReadOnly = true;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.White;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(117, 104);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(215, 25);
            this.textBox1.TabIndex = 43;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.White;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(209, 299);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(124, 32);
            this.textBox2.TabIndex = 57;
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.White;
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(117, 75);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(215, 27);
            this.textBox3.TabIndex = 58;
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.Color.White;
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.Location = new System.Drawing.Point(117, 108);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(215, 27);
            this.textBox4.TabIndex = 59;
            // 
            // QL_HopDong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pn_chitiet);
            this.Controls.Add(this.panel3);
            this.Name = "QL_HopDong";
            this.Size = new System.Drawing.Size(1100, 700);
            this.pn_chitiet.ResumeLayout(false);
            this.pn_chitiet.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gw_chitiethoadon)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gw_hoadon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridViewTextBoxColumn customer_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn created_at;
        private System.Windows.Forms.DataGridViewTextBoxColumn return_at;
        private System.Windows.Forms.DataGridViewTextBoxColumn total;
        private System.Windows.Forms.Panel pn_chitiet;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button cancel_ct;
        private System.Windows.Forms.Button reset_ct;
        private System.Windows.Forms.Button xoa_ct;
        private System.Windows.Forms.Button save_ct;
        private System.Windows.Forms.Button sua_ct;
        private System.Windows.Forms.Button them_ct;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox ma_hd_2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView gw_chitiethoadon;
        private System.Windows.Forms.DataGridViewTextBoxColumn order_detail_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn STTs;
        private System.Windows.Forms.DataGridViewTextBoxColumn ma_cthd;
        private System.Windows.Forms.DataGridViewTextBoxColumn order_ids;
        private System.Windows.Forms.DataGridViewTextBoxColumn car_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.DataGridViewTextBoxColumn full_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn ma_hds;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.CheckBox status;
        private System.Windows.Forms.DateTimePicker ngaytra;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker ngaythem;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button cancel_hd;
        private System.Windows.Forms.Button reset_hd;
        private System.Windows.Forms.Button xoa_hd;
        private System.Windows.Forms.Button save_hd;
        private System.Windows.Forms.Button sua_hd;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button them_hd;
        private System.Windows.Forms.TextBox tongtien;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView gw_hoadon;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
    }
}
