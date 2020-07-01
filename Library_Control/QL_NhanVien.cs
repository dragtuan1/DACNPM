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
using DACNPM.BLL;

namespace DACNPM.Library_Control
{
    public partial class QL_NhanVien : UserControl
    {
        private string username { get; set; }
        public QL_NhanVien(string Username)
        {
            this.username = Username;
            InitializeComponent();
            setview();
        }

        public void setview()

        {                         
            foreach (Type_Account i in BLL.QLNhanVien_BLL.Instance.getTypeAcounts_BLL())
            {
                if (BLL_QLTaiKhoan.Instance.GetACC_ByUserName(username).Type_Account.Name_Type == "QuanLy" && i.Name_Type == "NhanVien")
                    cbb_roleNV.Items.Add(i);
                if (BLL_QLTaiKhoan.Instance.GetACC_ByUserName(username).Type_Account.Name_Type == "Admin") cbb_roleNV.Items.Add(i);
            }
            cbb_roleNV.SelectedIndex = -1;
            if(BLL.BLL_QLTaiKhoan.Instance.GetACC_ByUserName(username).Type_Account.Name_Type == "QuanLy")
                DGV_QLNV.DataSource = BLL.QLNhanVien_BLL.Instance.getEmployees_BLL();
            else
                DGV_QLNV.DataSource = BLL.QLNhanVien_BLL.Instance.getAllEmployees_BLL();
        }
        private void btn_delete_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection r = DGV_QLNV.SelectedRows;
            if (r.Count != 0)
            {
                List<int> List_ID = new List<int>();

                foreach (DataGridViewRow j in r)
                {
                    List_ID.Add((int)j.Cells["ID_Employee"].Value);
                }
                BLL.QLNhanVien_BLL.Instance.DelNV_BLL(List_ID);
                if (BLL.BLL_QLTaiKhoan.Instance.GetACC_ByUserName(username).Type_Account.Name_Type == "QuanLy")
                    DGV_QLNV.DataSource = BLL.QLNhanVien_BLL.Instance.getEmployees_BLL();
                else
                    DGV_QLNV.DataSource = BLL.QLNhanVien_BLL.Instance.getAllEmployees_BLL();
                Reset();
            }
            else
            {
                MessageBox.Show("Vui Lòng Chọn Một Đối Tượng cần xóa");
            }
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void DGV_QLNV_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewSelectedRowCollection data = DGV_QLNV.SelectedRows;
            if (data.Count == 1)
            {
                txt_NameTK.Enabled = false;
                txt_NameTK.Text = data[0].Cells["Username"].Value.ToString();
                txt_NameNV.Text = data[0].Cells["Name_Employee"].Value.ToString();
                txt_Email.Text = data[0].Cells["Email"].Value.ToString();
                txt_Phone.Text = data[0].Cells["Phone"].Value.ToString();
                int index = cbb_roleNV.Items
                   .IndexOf((BLL.QLNhanVien_BLL.Instance.getNhanVienByID_BLL(Convert
                   .ToInt32(data[0].Cells["ID_Employee"]
                   .Value.ToString()))).Account.Type_Account);
                cbb_roleNV.SelectedIndex = index;
                txt_LuongNV.Text = data[0].Cells["Salary"].Value.ToString();
            }
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection r = DGV_QLNV.SelectedRows;
            if (r.Count == 1)
            {
                if (txt_Password.Text == "" || txt_NameNV.Text == "" || txt_Email.Text == "" ||
                txt_Phone.Text == "" || cbb_roleNV.SelectedIndex == -1)
                {
                    MessageBox.Show("Vui long nhap day du thong tin");
                }
                else
                {
                    Account acc = new Account
                    {
                        Username = txt_NameTK.Text,
                        UserPassword = BLL.BLL_QLTaiKhoan.Instance.hashPassMD5(txt_Password.Text),
                        ID_Type_Account = ((Type_Account)cbb_roleNV.SelectedItem).ID_Type_Account
                    };
                    Employee emp = new Employee
                    {
                        ID_Employee = Convert.ToInt32(r[0].Cells["ID_Employee"].Value.ToString()),
                        Name_Employee = txt_NameNV.Text,
                        Email = txt_Email.Text,
                        Phone = txt_Phone.Text
                    };                                  
                        BLL.QLNhanVien_BLL.Instance.UpdateNV_BLL(acc, emp);
                        MessageBox.Show("Update Thành Công ");
                        if (BLL_QLTaiKhoan.Instance.GetACC_ByUserName(username).Type_Account.Name_Type == "QuanLy")
                            DGV_QLNV.DataSource = BLL.QLNhanVien_BLL.Instance.getEmployees_BLL();
                        else
                            DGV_QLNV.DataSource = BLL.QLNhanVien_BLL.Instance.getAllEmployees_BLL();
                        Reset();
                                    
                   
                }

            }
            else MessageBox.Show("Vui lòng chọn nhân viên cần sửa thông tin");
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            
        }
        private void Reset()
        {
            txt_NameTK.Enabled = true;
            txt_NameTK.Text = null;
            txt_Password.Text = null;
            txt_NameNV.Text = null;
            txt_Email.Text = null;
            txt_Phone.Text = null;
            cbb_roleNV.SelectedIndex = -1;
            txt_LuongNV.Text = null;
            txtSearch.Text = null;
        }

        private void txt_Email_TextChanged(object sender, EventArgs e)
        {

        }

        private void DGV_QLNV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_Add_Click_1(object sender, EventArgs e)
        {
            txt_NameTK.Enabled = true;
            if (txt_Email.Text != "" && txt_LuongNV.Text != "" && txt_NameTK.Text != "" && txt_NameNV.Text != ""
                && txt_Password.Text != "" && txt_Phone.Text != "" )
            {

                Account acc = new Account
                {
                    Username = txt_NameTK.Text,
                    UserPassword = txt_Password.Text,
                    ID_Type_Account = ((Type_Account)cbb_roleNV.SelectedItem).ID_Type_Account
                };
                Employee emp = new Employee
                {
                    Name_Employee = txt_NameNV.Text,
                    Email = txt_Email.Text,
                    ID_Account = acc.ID_Account,
                    Phone = txt_Phone.Text
                };
                if (BLL.QLNhanVien_BLL.Instance.Check_ACC_NV_BLL(acc, emp))
                {
                    BLL.QLNhanVien_BLL.Instance.AddNV_BLL(acc, emp);
                    MessageBox.Show("Thêm thành công nhân viên");                   
                    if (BLL_QLTaiKhoan.Instance.GetACC_ByUserName(username).Type_Account.Name_Type == "QuanLy")
                        DGV_QLNV.DataSource = BLL.QLNhanVien_BLL.Instance.getEmployees_BLL();
                    else
                        DGV_QLNV.DataSource = BLL.QLNhanVien_BLL.Instance.getAllEmployees_BLL();
                    Reset();
                }
                else MessageBox.Show("Thêm thất bại");
            }
            else MessageBox.Show("Vui lòng nhập đầy đủ thông tin");

               
               
            
        }

        private void cbb_roleNV_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string search = txtSearch.Text;
            DGV_QLNV.DataSource = BLL.QLNhanVien_BLL.Instance.SearchNV_BLL(search);
            Reset();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
