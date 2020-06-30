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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QL_HopDong));
            this.pn_chitiet = new System.Windows.Forms.Panel();
            this.label14 = new System.Windows.Forms.Label();
            this.xoa_ct = new System.Windows.Forms.Button();
            this.them_ct = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txtma_hd_2 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.gw_chitiethoadon = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCMND_QLHopDong = new System.Windows.Forms.TextBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.ngaytra = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.ngaythem = new System.Windows.Forms.DateTimePicker();
            this.label12 = new System.Windows.Forms.Label();
            this.cbbType = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.xoa_hd = new System.Windows.Forms.Button();
            this.sua_hd = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.them_hd = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.gw_hoadon = new System.Windows.Forms.DataGridView();
            this.cbbXe = new System.Windows.Forms.ComboBox();
            this.pn_chitiet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gw_chitiethoadon)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gw_hoadon)).BeginInit();
            this.SuspendLayout();
            // 
            // pn_chitiet
            // 
            this.pn_chitiet.Controls.Add(this.cbbXe);
            this.pn_chitiet.Controls.Add(this.label14);
            this.pn_chitiet.Controls.Add(this.xoa_ct);
            this.pn_chitiet.Controls.Add(this.them_ct);
            this.pn_chitiet.Controls.Add(this.label8);
            this.pn_chitiet.Controls.Add(this.txtma_hd_2);
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
            // xoa_ct
            // 
            this.xoa_ct.BackColor = System.Drawing.SystemColors.Info;
            this.xoa_ct.FlatAppearance.BorderSize = 0;
            this.xoa_ct.ForeColor = System.Drawing.SystemColors.ControlText;
            this.xoa_ct.Image = ((System.Drawing.Image)(resources.GetObject("xoa_ct.Image")));
            this.xoa_ct.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.xoa_ct.Location = new System.Drawing.Point(198, 191);
            this.xoa_ct.Name = "xoa_ct";
            this.xoa_ct.Padding = new System.Windows.Forms.Padding(23, 0, 0, 0);
            this.xoa_ct.Size = new System.Drawing.Size(110, 40);
            this.xoa_ct.TabIndex = 36;
            this.xoa_ct.Text = "         Xóa";
            this.xoa_ct.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.xoa_ct.UseVisualStyleBackColor = false;
            this.xoa_ct.Click += new System.EventHandler(this.xoa_ct_Click);
            // 
            // them_ct
            // 
            this.them_ct.BackColor = System.Drawing.SystemColors.Info;
            this.them_ct.FlatAppearance.BorderSize = 0;
            this.them_ct.Image = ((System.Drawing.Image)(resources.GetObject("them_ct.Image")));
            this.them_ct.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.them_ct.Location = new System.Drawing.Point(82, 191);
            this.them_ct.Name = "them_ct";
            this.them_ct.Padding = new System.Windows.Forms.Padding(13, 0, 0, 0);
            this.them_ct.Size = new System.Drawing.Size(110, 40);
            this.them_ct.TabIndex = 33;
            this.them_ct.Text = "         Thêm Mới";
            this.them_ct.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.them_ct.UseVisualStyleBackColor = false;
            this.them_ct.Click += new System.EventHandler(this.them_ct_Click);
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
            // txtma_hd_2
            // 
            this.txtma_hd_2.BackColor = System.Drawing.Color.White;
            this.txtma_hd_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtma_hd_2.Location = new System.Drawing.Point(117, 64);
            this.txtma_hd_2.Multiline = true;
            this.txtma_hd_2.Name = "txtma_hd_2";
            this.txtma_hd_2.Size = new System.Drawing.Size(215, 25);
            this.txtma_hd_2.TabIndex = 25;
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
            this.gw_chitiethoadon.Location = new System.Drawing.Point(398, 33);
            this.gw_chitiethoadon.Name = "gw_chitiethoadon";
            this.gw_chitiethoadon.ReadOnly = true;
            this.gw_chitiethoadon.Size = new System.Drawing.Size(600, 246);
            this.gw_chitiethoadon.TabIndex = 23;
            this.gw_chitiethoadon.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.gw_chitiethoadon_RowHeaderMouseClick);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.txtCMND_QLHopDong);
            this.panel3.Controls.Add(this.txtSearch);
            this.panel3.Controls.Add(this.ngaytra);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.ngaythem);
            this.panel3.Controls.Add(this.label12);
            this.panel3.Controls.Add(this.cbbType);
            this.panel3.Controls.Add(this.label13);
            this.panel3.Controls.Add(this.xoa_hd);
            this.panel3.Controls.Add(this.sua_hd);
            this.panel3.Controls.Add(this.button1);
            this.panel3.Controls.Add(this.them_hd);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.gw_hoadon);
            this.panel3.Location = new System.Drawing.Point(13, 20);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1021, 346);
            this.panel3.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label2.Location = new System.Drawing.Point(8, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 16);
            this.label2.TabIndex = 60;
            // 
            // txtCMND_QLHopDong
            // 
            this.txtCMND_QLHopDong.BackColor = System.Drawing.Color.White;
            this.txtCMND_QLHopDong.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCMND_QLHopDong.Location = new System.Drawing.Point(128, 54);
            this.txtCMND_QLHopDong.Multiline = true;
            this.txtCMND_QLHopDong.Name = "txtCMND_QLHopDong";
            this.txtCMND_QLHopDong.Size = new System.Drawing.Size(215, 27);
            this.txtCMND_QLHopDong.TabIndex = 58;
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.Color.White;
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(243, 252);
            this.txtSearch.Multiline = true;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(156, 32);
            this.txtSearch.TabIndex = 57;
            // 
            // ngaytra
            // 
            this.ngaytra.CustomFormat = "dd-MM-yyyy";
            this.ngaytra.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ngaytra.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.ngaytra.Location = new System.Drawing.Point(128, 133);
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
            this.label1.Location = new System.Drawing.Point(14, 143);
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
            this.ngaythem.Location = new System.Drawing.Point(128, 98);
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
            this.label12.Location = new System.Drawing.Point(14, 108);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(78, 16);
            this.label12.TabIndex = 46;
            this.label12.Text = "Ngày Thuê:";
            // 
            // cbbType
            // 
            this.cbbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbType.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbType.FormattingEnabled = true;
            this.cbbType.Items.AddRange(new object[] {
            "SĐT",
            "Tên khách hàng"});
            this.cbbType.Location = new System.Drawing.Point(117, 253);
            this.cbbType.Name = "cbbType";
            this.cbbType.Size = new System.Drawing.Size(120, 33);
            this.cbbType.TabIndex = 44;
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
            // xoa_hd
            // 
            this.xoa_hd.BackColor = System.Drawing.SystemColors.Info;
            this.xoa_hd.FlatAppearance.BorderSize = 0;
            this.xoa_hd.ForeColor = System.Drawing.SystemColors.ControlText;
            this.xoa_hd.Image = ((System.Drawing.Image)(resources.GetObject("xoa_hd.Image")));
            this.xoa_hd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.xoa_hd.Location = new System.Drawing.Point(650, 266);
            this.xoa_hd.Name = "xoa_hd";
            this.xoa_hd.Padding = new System.Windows.Forms.Padding(23, 0, 0, 0);
            this.xoa_hd.Size = new System.Drawing.Size(110, 40);
            this.xoa_hd.TabIndex = 20;
            this.xoa_hd.Text = "         Xóa";
            this.xoa_hd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.xoa_hd.UseVisualStyleBackColor = false;
            this.xoa_hd.Click += new System.EventHandler(this.xoa_hd_Click);
            // 
            // sua_hd
            // 
            this.sua_hd.BackColor = System.Drawing.SystemColors.Info;
            this.sua_hd.FlatAppearance.BorderSize = 0;
            this.sua_hd.Image = ((System.Drawing.Image)(resources.GetObject("sua_hd.Image")));
            this.sua_hd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.sua_hd.Location = new System.Drawing.Point(534, 266);
            this.sua_hd.Name = "sua_hd";
            this.sua_hd.Size = new System.Drawing.Size(110, 40);
            this.sua_hd.TabIndex = 18;
            this.sua_hd.Text = "        Sửa Thông Tin";
            this.sua_hd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.sua_hd.UseVisualStyleBackColor = false;
            this.sua_hd.Click += new System.EventHandler(this.sua_hd_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Info;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(11, 249);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(13, 0, 0, 0);
            this.button1.Size = new System.Drawing.Size(100, 40);
            this.button1.TabIndex = 17;
            this.button1.Text = "         Tìm kiếm";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // them_hd
            // 
            this.them_hd.BackColor = System.Drawing.SystemColors.Info;
            this.them_hd.FlatAppearance.BorderSize = 0;
            this.them_hd.Image = ((System.Drawing.Image)(resources.GetObject("them_hd.Image")));
            this.them_hd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.them_hd.Location = new System.Drawing.Point(418, 266);
            this.them_hd.Name = "them_hd";
            this.them_hd.Padding = new System.Windows.Forms.Padding(13, 0, 0, 0);
            this.them_hd.Size = new System.Drawing.Size(110, 40);
            this.them_hd.TabIndex = 17;
            this.them_hd.Text = "         Thêm Mới";
            this.them_hd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.them_hd.UseVisualStyleBackColor = false;
            this.them_hd.Click += new System.EventHandler(this.them_hd_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label3.Location = new System.Drawing.Point(14, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "CMND Khách";
            // 
            // gw_hoadon
            // 
            this.gw_hoadon.AllowUserToAddRows = false;
            this.gw_hoadon.AllowUserToDeleteRows = false;
            this.gw_hoadon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gw_hoadon.BackgroundColor = System.Drawing.SystemColors.Info;
            this.gw_hoadon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gw_hoadon.Location = new System.Drawing.Point(399, 33);
            this.gw_hoadon.Name = "gw_hoadon";
            this.gw_hoadon.ReadOnly = true;
            this.gw_hoadon.Size = new System.Drawing.Size(600, 211);
            this.gw_hoadon.TabIndex = 0;
            this.gw_hoadon.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.gw_hoadon_RowHeaderMouseClick);
            // 
            // cbbXe
            // 
            this.cbbXe.FormattingEnabled = true;
            this.cbbXe.Location = new System.Drawing.Point(116, 108);
            this.cbbXe.Name = "cbbXe";
            this.cbbXe.Size = new System.Drawing.Size(216, 21);
            this.cbbXe.TabIndex = 44;
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
        private System.Windows.Forms.Panel pn_chitiet;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button xoa_ct;
        private System.Windows.Forms.Button them_ct;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtma_hd_2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView gw_chitiethoadon;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DateTimePicker ngaytra;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker ngaythem;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cbbType;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button xoa_hd;
        private System.Windows.Forms.Button sua_hd;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button them_hd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView gw_hoadon;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.TextBox txtCMND_QLHopDong;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbbXe;
    }
}
