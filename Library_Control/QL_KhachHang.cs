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
    public partial class QL_KhachHang : UserControl
    {   

        public QL_KhachHang()
        {
            InitializeComponent();
        }
        private void btn_add_Click(object sender, EventArgs e)
        {           
            Customer st1 = new Customer{ 
                CMND = Txt_CMND.Text,
                Customer_Address = Txt_DiaChi.Text,
                Customer_Name = Txt_TenKH.Text,
                Phone = Txt_Phone.Text,
            };
            BLL_QLKH.Instance.AddNV_DAL(st1);
            DGV_QLKH.DataSource = BLL_QLKH.Instance.GetALL_CTM();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection r = DGV_QLKH.SelectedRows;
            List<int> List_ID = new List<int>();
            foreach (DataGridViewRow j in r)
            {
                List_ID.Add((int)j.Cells["ID_Customer"].Value);
            }


        }
    }
}
