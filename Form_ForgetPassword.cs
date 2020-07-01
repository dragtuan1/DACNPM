using DACNPM.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DACNPM
{
    public partial class Form_ForgetPassword : Form
    {
        public Form_ForgetPassword()
        {
            InitializeComponent();
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
        }

        private void textBox1_Click_1(object sender, EventArgs e)
        {
            txt_CauHoi2.Text = null;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            txt_CauHoi1.Text = null;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            Account acc = BLL.BLL_QLTaiKhoan.Instance.GetACC_ByUserName(txt_username.Text);
            
            if(acc == null)
            {
                MessageBox.Show("Không tồn tại tài khoản này");
            }
            else
            {
                if (acc.Question1 == txt_CauHoi1.Text && acc.Question2 == txt_CauHoi2.Text)
                {
                    string newPass;
                    Random rand = new Random();
                    newPass = (rand.Next(999999)).ToString();
                    MessageBox.Show("Mật khẩu mới của bạn là: " + newPass);
                    BLL.BLL_QLTaiKhoan.Instance.UpDatePassWord(txt_username.Text, newPass);
                }
                else MessageBox.Show("Câu trả lời không đúng");
             
            }        
           
        }
    }
}