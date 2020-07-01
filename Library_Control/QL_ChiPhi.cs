using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DACNPM.Library_Control
{
    public partial class QL_ChiPhi : UserControl
    {
        public QL_ChiPhi()
        {
            InitializeComponent();
            setView();
        }

        public void setView()
        {
            List<Entities.Type_Vehicle> typeVehicles = BLL.QLChiPhi_BLL.Instance.getTypeVehiCle_BLL();
            for(int i = 0; i < typeVehicles.Count; i++)
            {
                cbbLoaiXe_QLChiPhi.Items.Add(typeVehicles[i]);
            }

            foreach(Entities.Type_Account i in BLL.QLChiPhi_BLL.Instance.getTypeAcounts_BLL())
            {
                cbbChucVu_QLChiPhi.Items.Add(i);
            }

            cbbLoaiXe_QLChiPhi.SelectedIndex = 0;
            cbbChucVu_QLChiPhi.SelectedIndex = 0;

            gw_hoadon.DataSource = BLL.QLChiPhi_BLL.Instance.getVehicles_BLL();
            gw_chitiethoadon.DataSource = BLL.QLChiPhi_BLL.Instance.getNhanVien_BLL();
        }

        private void reset_hd_Click(object sender, EventArgs e)
        {
            txtTenTaiXe_QLChiPhi.ResetText();
            cbbLoaiXe_QLChiPhi.SelectedIndex = 0;
            txtDonGia_QLChiPhi.ResetText();

        }

        private void gw_hoadon_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewSelectedRowCollection data = gw_hoadon.SelectedRows;
            if(data.Count == 1)
            {
                txtDonGia_QLChiPhi.Text = data[0].Cells["Price"].Value.ToString();
                txtTenTaiXe_QLChiPhi.Text = data[0].Cells["Name_Driver"].Value.ToString();
                int index = cbbLoaiXe_QLChiPhi.Items
                    .IndexOf((BLL.QLChiPhi_BLL.Instance.getVehicleByID_BLL(Convert
                    .ToInt32(data[0].Cells["ID_Vehicle"]
                    .Value.ToString()))).Type_Vehicle);
                cbbLoaiXe_QLChiPhi.SelectedIndex = index;
            }
        }

        private void sua_hd_Click(object sender, EventArgs e)
        {
            if(gw_hoadon.SelectedRows.Count == 1)
            {
                try
                {
                    int Price = Convert.ToInt32(txtDonGia_QLChiPhi.Text.ToString());
                    int id = Convert.ToInt32(gw_hoadon.SelectedRows[0].Cells["ID_Vehicle"].Value.ToString());
                    if (BLL.QLChiPhi_BLL.Instance.UpdatePhiXeByIDXe_BLL(id, Price))
                    {
                        MessageBox.Show("Success!");
                        setView();
                    }
                    else
                    {
                        MessageBox.Show("Fail!");
                    }
                }
                catch
                {
                    MessageBox.Show("Error");
                }

            } else
            {
                MessageBox.Show("Vui lòng chọn lại !");
            }
        }

        private void gw_chitiethoadon_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewSelectedRowCollection data = gw_chitiethoadon.SelectedRows;
            if(data.Count == 1)
            {
                txtName_QLChiPhi.Text = data[0].Cells["Name_Employee"].Value.ToString();
                int index = cbbChucVu_QLChiPhi.Items
                    .IndexOf((BLL.QLChiPhi_BLL.Instance.getNhanVienByID_BLL(Convert
                    .ToInt32(data[0].Cells["ID_Employee"]
                    .Value.ToString()))).Account.Type_Account);
                cbbChucVu_QLChiPhi.SelectedIndex = index;
                txtLuong_QLChiPhi.Text = data[0].Cells["Salary"].Value.ToString();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if(gw_chitiethoadon.SelectedRows.Count == 1)
            {
                txtTongLuong_QLChiPhi.Text = BLL.QLChiPhi_BLL.Instance.TongTienByIDNhanVien_BLL(Convert.ToInt32(gw_chitiethoadon.SelectedRows[0].Cells["ID_Employee"].Value.ToString())).ToString();
            } else
            {
                MessageBox.Show("Error");
            }
        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
