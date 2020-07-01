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
        private string username { get; set; }
        public QL_ChiPhi(string username)
        {
            this.username = username;
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

          

        

            gw_hoadon.DataSource = BLL.QLChiPhi_BLL.Instance.getVehicles_BLL();
 

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



    

   

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void sua_hd_Click_1(object sender, EventArgs e)
        {
            if (gw_hoadon.SelectedRows.Count == 1)
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

            }
            else
            {
                MessageBox.Show("Vui lòng chọn lại !");
            }
        }

        private void reset_hd_Click(object sender, EventArgs e)
        {
            txtTenTaiXe_QLChiPhi.ResetText();
            cbbLoaiXe_QLChiPhi.SelectedIndex = 0;
            txtDonGia_QLChiPhi.ResetText();
        }
    }
}
