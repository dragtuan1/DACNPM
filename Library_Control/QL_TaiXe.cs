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
    public partial class QL_TaiXe : UserControl
    {
        public QL_TaiXe()
        {
            InitializeComponent();
            gw_taixe.DataSource = BLL.QLTaiXe_BLL.Instance.getAllTaiXe_BLL();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            try
            {
                BLL.QLTaiXe_BLL.Instance.addTaiXe(txtDiaChi.Text, txtCMND.Text,
                    txtName.Text, txtSdt.Text, txtBangLai.Text, true);

                gw_taixe.DataSource = BLL.QLTaiXe_BLL.Instance.getAllTaiXe_BLL();
            }
            catch
            {
                MessageBox.Show("Error");
            }

        }

        private void gw_taixe_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewSelectedRowCollection data = gw_taixe.SelectedRows;
            if(data.Count == 1)
            {
                txtIdTaiXe.Text = data[0].Cells["ID_Driver"].Value.ToString();
                txtName.Text = data[0].Cells["Name_Driver"].Value.ToString();
                txtDiaChi.Text = data[0].Cells["Driver_Address"].Value.ToString();
                txtBangLai.Text = data[0].Cells["License"].Value.ToString();
                txtSdt.Text = data[0].Cells["Phone"].Value.ToString();
                txtCMND.Text = data[0].Cells["CMND"].Value.ToString();
            }
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection data = gw_taixe.SelectedRows;
            if(data.Count == 1)
            {
                try
                {
                    BLL.QLTaiXe_BLL.Instance.updateTaiXe_BLL(Convert.ToInt32(txtIdTaiXe.Text),
                            txtDiaChi.Text, txtCMND.Text, txtName.Text, txtSdt.Text,
                            txtBangLai.Text, false);
                    gw_taixe.DataSource = BLL.QLTaiXe_BLL.Instance.getAllTaiXe_BLL();
                }
                catch
                {
                    MessageBox.Show("Error");
                }
            }
            else
            {
                MessageBox.Show("Error");
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection data = gw_taixe.SelectedRows;
            if (data.Count > 0)
            {
                try
                {
                    foreach (DataGridViewRow i in data)
                    {
                        int id = Convert.ToInt32(i.Cells["ID_Driver"].Value.ToString());
                        BLL.QLTaiXe_BLL.Instance.deleteTaiXeByID_BLL(id);
                    }

                    gw_taixe.DataSource = BLL.QLTaiXe_BLL.Instance.getAllTaiXe_BLL();

                }
                catch
                {
                    MessageBox.Show("Error");
                }

            }
            else
            {
                MessageBox.Show("Error");
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            int index = cbbType.SelectedIndex;
            if(index == 0)
            {
                //cmnd
                try
                {
                    gw_taixe.DataSource = BLL.QLTaiXe_BLL.Instance.searchTaiXebyCMND_BLL(txtSearch.Text);
                }
                catch
                {
                    MessageBox.Show("Error");
                }

            } else if(index == 1)
            {
                //ten
                try
                {
                  
                    gw_taixe.DataSource = BLL.QLTaiXe_BLL.Instance.searchTaiXebyName_BLL(txtSearch.Text);
                }
                catch
                {
                    MessageBox.Show("Error");
                }

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string search = txtSearch.Text;
            gw_taixe.DataSource = BLL.QLTaiXe_BLL.Instance.SearchKH_BLL(search);
        }
    }
}
