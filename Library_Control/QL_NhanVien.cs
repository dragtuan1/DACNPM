using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DACNPM.Entities;

namespace DACNPM.Library_Control
{
    public partial class QL_NhanVien : UserControl
    {
        public QL_NhanVien()
        {
            InitializeComponent();
            DGV_QLNV.DataSource = BLL_QLNV.Instance.GetALL_EPL();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            Employee emp = new Employee
            {
                Name_Employee = txt_NameNV.Text,
                Email = txt_Email.Text,
                Phone = txt_Phone.Text,
                //MN_Salaries = txt_LuongNV.Text;
            };
            BLL_QLNV.Instance.AddNV_BLL(emp);
            DGV_QLNV.DataSource = BLL_QLNV.Instance.GetALL_EPL();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection r = DGV_QLNV.SelectedRows;
            if (r.Count != 0)
            {
                List<int> List_ID = new List<int>();

                foreach (DataGridViewRow j in r)
                {
                    List_ID.Add((int)j.Cells["ID_Customer"].Value);
                }
                BLL_QLNV.Instance.DelNV_BLL(List_ID);
                DGV_QLNV.DataSource = BLL_QLNV.Instance.GetALL_EPL();
            }
            else
            {
                MessageBox.Show("Vui Lòng Chọn Một Đối Tượng cần xóa");
            }
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            txt_NameNV.Text = null;
            txt_Email.Text = null;
            txt_Phone.Text = null;
            txt_LuongNV.Text = null;
        }

        private void DGV_QLNV_Click(object sender, EventArgs e)
        {

        }
    }
}
