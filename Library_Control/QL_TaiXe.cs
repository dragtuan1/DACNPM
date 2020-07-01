using System;
using System.Collections.Generic;
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
            if (txtName.Text == "" || txtDiaChi.Text == "" || txtSdt.Text == "" || txtCMND.Text == "" || txtBangLai.Text == "")
            {
                MessageBox.Show("Vui long nhap day du thong tin");
            }
            else
            {
                Entities.Driver driver = new Entities.Driver
                {
                    Name_Driver = txtName.Text,
                    Driver_Address = txtDiaChi.Text,
                    Phone = txtSdt.Text,
                    CMND = txtCMND.Text,
                    License = txtBangLai.Text,
                    Driver_State = false
                };
                if (BLL.QLTaiXe_BLL.Instance.CheckIn4_TaiXe_BLL(driver))
                {
                    if (BLL.QLTaiXe_BLL.Instance.addTaiXe(driver))
                        MessageBox.Show("Thêm tài xế thành công");
                    gw_taixe.DataSource = BLL.QLTaiXe_BLL.Instance.getAllTaiXe_BLL();
                }
            }
        }

        private void gw_taixe_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewSelectedRowCollection data = gw_taixe.SelectedRows;
            if (data.Count == 1)
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
            if (data.Count == 1)
            {
                if (txtName.Text == "" || txtDiaChi.Text == "" || txtSdt.Text == "" || txtCMND.Text == "" || txtBangLai.Text == "")
                {
                    MessageBox.Show("Vui long nhap day du thong tin");
                }
                else
                {
                    Entities.Driver driver = new Entities.Driver
                    {
                        ID_Driver = Convert.ToInt32(data[0].Cells["ID_Driver"].Value.ToString()),
                        Name_Driver = txtName.Text,
                        Driver_Address = txtDiaChi.Text,
                        Phone = txtSdt.Text,
                        CMND = txtCMND.Text,
                        License = txtBangLai.Text,
                        Driver_State = false
                    };
                    if (BLL.QLTaiXe_BLL.Instance.updateTaiXe_BLL(driver))
                        MessageBox.Show("Cập nhật tài xế thành công");
                    gw_taixe.DataSource = BLL.QLTaiXe_BLL.Instance.getAllTaiXe_BLL();
                }
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection data = gw_taixe.SelectedRows;
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa?", "", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                if (data.Count > 0)
                {
                    List<int> List_ID = new List<int>();
                    foreach (DataGridViewRow j in data)
                    {
                        List_ID.Add((int)j.Cells["ID_Driver"].Value);
                    }
                    BLL.QLTaiXe_BLL.Instance.deleteTaiXeByID_BLL(List_ID);
                    gw_taixe.DataSource = BLL.QLTaiXe_BLL.Instance.getAllTaiXe_BLL();
                }
                else
                {
                    MessageBox.Show("Error");
                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            int index = cbbType.SelectedIndex;
            if (index == 0)
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

            }
            else if (index == 1)
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
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string search = txtSearch.Text;
            gw_taixe.DataSource = BLL.QLTaiXe_BLL.Instance.SearchKH_BLL(search);
        }
    }
}
