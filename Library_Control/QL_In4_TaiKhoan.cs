using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity.ModelConfiguration.Conventions;
using DACNPM.Entities;

namespace DACNPM.Library_Control
{
    public partial class QL_In4_TaiKhoan : UserControl
    {   
        public string username { get; set; }
        public int ID_NV { get; set; }
        public QL_In4_TaiKhoan(string user , int ID )
        {
            username = user;
            ID_NV = ID;
            InitializeComponent();
            LoadData();
        }

        private void label1_Click(object sender, EventArgs e)
        {
           
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            if (BLL.BLL_QLTaiKhoan.Instance.UpdateIn4_BLL(ID_NV, Txt_Tk.Text, Txt_Ten.Text, Txt_SDT.Text, Txt_Mk.Text, Txt_Email.Text))
                MessageBox.Show("Chỉnh sửa thành công");
            else
                MessageBox.Show("Error Database");
            MessageBox.Show(Entities.AccountLogin.getInstance().Pass);
        }
        public void LoadData()
        {
            Account acc1 = BLL.BLL_QLTaiKhoan.Instance.GetACC_ByUserName(username);
            Employee e1 = BLL.BLL_QLTaiKhoan.Instance.GetNVBY_ID_BLL(ID_NV);
            Txt_ID.Text = e1.ID_Employee.ToString();
            Txt_ID.Enabled = false;
            Txt_Tk.Text = acc1.Username;
            Txt_Ten.Text = e1.Name_Employee;
            Txt_SDT.Text = e1.Phone;
            Txt_Mk.Text = acc1.UserPassword;
            Txt_Email.Text = e1.Email;
        }
    }
}
