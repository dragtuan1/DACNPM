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
using System.Drawing.Design;

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
            BLL_QLKH.Instance.AddNV_BLL(st1);
            DGV_QLKH.DataSource = BLL_QLKH.Instance.GetALL_CTM();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection r = DGV_QLKH.SelectedRows;
            if(r.Count != 0)
            {
                List<int> List_ID = new List<int>();

                foreach (DataGridViewRow j in r)
                {
                    List_ID.Add((int)j.Cells["ID_Customer"].Value);
                }
                BLL_QLKH.Instance.DelNV_BLL(List_ID);
                DGV_QLKH.DataSource = BLL_QLKH.Instance.GetALL_CTM();
            }
            else
            {
                MessageBox.Show("Vui Lòng Chọn Một Đối Tượng cần xóa");
            }
       
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection r = DGV_QLKH.SelectedRows;

            //  Txt_MaKH.Enabled = false;
            //   Txt_MaKH.Text = r[0].Cells["ID_Customer"].Value.ToString();
            Txt_CMND.Text = r[0].Cells["CMND"].Value.ToString();
            Txt_DiaChi.Text = r[0].Cells["Customer_Address"].Value.ToString();
            Txt_Phone.Text = r[0].Cells["Phone"].Value.ToString();
            Txt_TenKH.Text = r[0].Cells["Customer_Name"].Value.ToString();
            //Txt_MaKH.Enabled = false;
           
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            Txt_CMND.Text   = null;
            Txt_DiaChi.Text = null;
         //   Txt_MaKH.Text   = null;
            Txt_Phone.Text  = null;
            Txt_TenKH.Text  = null;
        }

        

        private void DGV_QLKH_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewSelectedRowCollection r = DGV_QLKH.SelectedRows;
          //  Txt_MaKH.Enabled = false;
        //    Txt_MaKH.Text = r[0].Cells["ID_Customer"].Value.ToString();
            Txt_CMND.Text = r[0].Cells["CMND"].Value.ToString();
            Txt_DiaChi.Text = r[0].Cells["Customer_Address"].Value.ToString();
            Txt_Phone.Text = r[0].Cells["Phone"].Value.ToString();
            Txt_TenKH.Text = r[0].Cells["Customer_Name"].Value.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection r = DGV_QLKH.SelectedRows;
            Customer st1 = new Customer
            {
                ID_Customer = Convert.ToInt32(r[0].Cells["ID_Customer"].Value.ToString()),
                CMND = Txt_CMND.Text,
                Customer_Address = Txt_DiaChi.Text,
                Customer_Name = Txt_TenKH.Text,
                Phone = Txt_Phone.Text,
            };
            BLL_QLKH.Instance.UpdateNV_BLL(st1);
            DGV_QLKH.DataSource = BLL_QLKH.Instance.GetALL_CTM();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string StringSeach = TXT_Search.Text;
            DGV_QLKH.DataSource = BLL_QLKH.Instance.SearchKH_BLL(StringSeach);

            
        }
    }
}
