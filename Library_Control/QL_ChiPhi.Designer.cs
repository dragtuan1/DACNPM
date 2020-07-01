namespace DACNPM.Library_Control
{
    partial class QL_ChiPhi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QL_ChiPhi));
            this.gw_hoadon = new System.Windows.Forms.DataGridView();
            this.label13 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDonGia_QLChiPhi = new System.Windows.Forms.TextBox();
            this.sua_hd = new System.Windows.Forms.Button();
            this.reset_hd = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.cbbLoaiXe_QLChiPhi = new System.Windows.Forms.ComboBox();
            this.txtTenTaiXe_QLChiPhi = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.gw_hoadon)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // gw_hoadon
            // 
            this.gw_hoadon.AllowUserToAddRows = false;
            this.gw_hoadon.AllowUserToDeleteRows = false;
            this.gw_hoadon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gw_hoadon.BackgroundColor = System.Drawing.SystemColors.Info;
            this.gw_hoadon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gw_hoadon.Location = new System.Drawing.Point(513, 202);
            this.gw_hoadon.Margin = new System.Windows.Forms.Padding(4);
            this.gw_hoadon.Name = "gw_hoadon";
            this.gw_hoadon.ReadOnly = true;
            this.gw_hoadon.RowHeadersWidth = 51;
            this.gw_hoadon.Size = new System.Drawing.Size(940, 369);
            this.gw_hoadon.TabIndex = 0;
            this.gw_hoadon.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.gw_hoadon_RowHeaderMouseClick);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Red;
            this.label13.Location = new System.Drawing.Point(516, 161);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(314, 37);
            this.label13.TabIndex = 41;
            this.label13.Text = "THÔNG TIN CHI PHÍ XE";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtTenTaiXe_QLChiPhi);
            this.panel1.Controls.Add(this.cbbLoaiXe_QLChiPhi);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.reset_hd);
            this.panel1.Controls.Add(this.sua_hd);
            this.panel1.Controls.Add(this.txtDonGia_QLChiPhi);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(3, 202);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(461, 369);
            this.panel1.TabIndex = 47;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label3.Location = new System.Drawing.Point(16, 86);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 20);
            this.label3.TabIndex = 47;
            this.label3.Text = "Tài Xế Quản Lý";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label4.Location = new System.Drawing.Point(21, 134);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 20);
            this.label4.TabIndex = 48;
            this.label4.Text = "Loại Xe:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label5.Location = new System.Drawing.Point(21, 182);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 20);
            this.label5.TabIndex = 49;
            this.label5.Text = "Đơn giá/Ngày:";
            // 
            // txtDonGia_QLChiPhi
            // 
            this.txtDonGia_QLChiPhi.BackColor = System.Drawing.Color.White;
            this.txtDonGia_QLChiPhi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDonGia_QLChiPhi.Location = new System.Drawing.Point(152, 169);
            this.txtDonGia_QLChiPhi.Margin = new System.Windows.Forms.Padding(4);
            this.txtDonGia_QLChiPhi.Multiline = true;
            this.txtDonGia_QLChiPhi.Name = "txtDonGia_QLChiPhi";
            this.txtDonGia_QLChiPhi.Size = new System.Drawing.Size(241, 45);
            this.txtDonGia_QLChiPhi.TabIndex = 50;
            // 
            // sua_hd
            // 
            this.sua_hd.BackColor = System.Drawing.SystemColors.Info;
            this.sua_hd.FlatAppearance.BorderSize = 0;
            this.sua_hd.Image = ((System.Drawing.Image)(resources.GetObject("sua_hd.Image")));
            this.sua_hd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.sua_hd.Location = new System.Drawing.Point(230, 252);
            this.sua_hd.Margin = new System.Windows.Forms.Padding(4);
            this.sua_hd.Name = "sua_hd";
            this.sua_hd.Size = new System.Drawing.Size(163, 49);
            this.sua_hd.TabIndex = 52;
            this.sua_hd.Text = "        Sửa Thông Tin";
            this.sua_hd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.sua_hd.UseVisualStyleBackColor = false;
            this.sua_hd.Click += new System.EventHandler(this.sua_hd_Click_1);
            // 
            // reset_hd
            // 
            this.reset_hd.BackColor = System.Drawing.SystemColors.Info;
            this.reset_hd.FlatAppearance.BorderSize = 0;
            this.reset_hd.Image = ((System.Drawing.Image)(resources.GetObject("reset_hd.Image")));
            this.reset_hd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.reset_hd.Location = new System.Drawing.Point(39, 252);
            this.reset_hd.Margin = new System.Windows.Forms.Padding(4);
            this.reset_hd.Name = "reset_hd";
            this.reset_hd.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.reset_hd.Size = new System.Drawing.Size(151, 49);
            this.reset_hd.TabIndex = 51;
            this.reset_hd.Text = "         Nhập Lại";
            this.reset_hd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.reset_hd.UseVisualStyleBackColor = false;
            this.reset_hd.Click += new System.EventHandler(this.reset_hd_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Red;
            this.label15.Location = new System.Drawing.Point(401, 182);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(54, 28);
            this.label15.TabIndex = 53;
            this.label15.Text = "VNĐ";
            // 
            // cbbLoaiXe_QLChiPhi
            // 
            this.cbbLoaiXe_QLChiPhi.Enabled = false;
            this.cbbLoaiXe_QLChiPhi.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbLoaiXe_QLChiPhi.FormattingEnabled = true;
            this.cbbLoaiXe_QLChiPhi.Location = new System.Drawing.Point(152, 121);
            this.cbbLoaiXe_QLChiPhi.Margin = new System.Windows.Forms.Padding(4);
            this.cbbLoaiXe_QLChiPhi.Name = "cbbLoaiXe_QLChiPhi";
            this.cbbLoaiXe_QLChiPhi.Size = new System.Drawing.Size(241, 40);
            this.cbbLoaiXe_QLChiPhi.TabIndex = 54;
            // 
            // txtTenTaiXe_QLChiPhi
            // 
            this.txtTenTaiXe_QLChiPhi.BackColor = System.Drawing.Color.White;
            this.txtTenTaiXe_QLChiPhi.Enabled = false;
            this.txtTenTaiXe_QLChiPhi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenTaiXe_QLChiPhi.Location = new System.Drawing.Point(152, 68);
            this.txtTenTaiXe_QLChiPhi.Margin = new System.Windows.Forms.Padding(4);
            this.txtTenTaiXe_QLChiPhi.Multiline = true;
            this.txtTenTaiXe_QLChiPhi.Name = "txtTenTaiXe_QLChiPhi";
            this.txtTenTaiXe_QLChiPhi.Size = new System.Drawing.Size(241, 45);
            this.txtTenTaiXe_QLChiPhi.TabIndex = 55;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel1);
            this.panel3.Controls.Add(this.label13);
            this.panel3.Controls.Add(this.gw_hoadon);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1467, 789);
            this.panel3.TabIndex = 8;
            // 
            // QL_ChiPhi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel3);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "QL_ChiPhi";
            this.Size = new System.Drawing.Size(1467, 862);
            ((System.ComponentModel.ISupportInitialize)(this.gw_hoadon)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gw_hoadon;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtTenTaiXe_QLChiPhi;
        private System.Windows.Forms.ComboBox cbbLoaiXe_QLChiPhi;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button reset_hd;
        private System.Windows.Forms.Button sua_hd;
        private System.Windows.Forms.TextBox txtDonGia_QLChiPhi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel3;
    }
}
