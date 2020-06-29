using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using DACNPM.Entities;

namespace DACNPM
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }
        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg,int wparam, int lparam);

        private void txtUser_Enter(object sender, EventArgs e)
        {
            if(txtUser.Text == "USERNAME")
            {
                txtUser.Text = "";
                txtUser.ForeColor = Color.Silver;
            }
        }
        private void txtUser_Leave(object sender, EventArgs e)
        {
            if (txtUser.Text == "")
            {
                txtUser.Text = "USERNAME";
                txtUser.ForeColor = Color.Silver;
            }
        }
        private void txtPass_Enter(object sender, EventArgs e)
        {
            if (txtPass.Text == "PASSWORD")
            {
                txtPass.Text = "";
                txtPass.ForeColor = Color.Silver;
                txtPass.UseSystemPasswordChar = true;
            }
        }

        private void txtPass_Leave(object sender, EventArgs e)
        {
            if (txtPass.Text == "")
            {
                txtPass.Text = "PASSWORD";
                txtPass.ForeColor = Color.Silver;
                txtPass.UseSystemPasswordChar = false;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are you sure to close the application?", "Warning",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void msgError(string msg)
        {
            lblMessageError.Text = msg;
            lblMessageError.Visible = true;
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUser.Text != "USERNAME" && txtUser.TextLength > 2)
            {
                if (txtPass.Text != "PASSWORD")
                {
                    List<Account> list = BLL_QLTaiKhoan.Instance.GetACC_ByUserNameandPass(txtUser.Text, txtPass.Text);

                    if (list.ToList().Count != 0)
                    {
                        this.Hide();
                        FormWellcome wellcome = new FormWellcome();
                        wellcome.ShowDialog();
                        Entities.AccountLogin.setInstance(new Entities.AccountLogin(txtUser.Text, txtPass.Text));
                        MainForm mainForm = new MainForm(txtUser.Text);
                        mainForm.Show();
                        mainForm.FormClosed += Logout;
                    }
                    else
                    {
                        msgError("Incorrect username or password entered. \n   Please try again.");
                        txtPass.Text = "PASSWORD";
                        txtPass.UseSystemPasswordChar = false;
                        txtUser.Focus();
                    }
                }
                else msgError("Please enter password.");
            }
            else
            {
                msgError("Please enter username.");
                txtPass.Text = "PASSWORD";
                txtPass.UseSystemPasswordChar = false;
                txtUser.Focus();
            }
        }
        public void Logout(object sender, FormClosedEventArgs e)
        {
            txtUser.Text = "USERNAME";
            txtPass.Text = "PASSWORD";
            lblMessageError.Visible = false;
            txtPass.UseSystemPasswordChar = false;
            this.Show();
            txtUser.Focus();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Form_ForgetPassword form = new Form_ForgetPassword();
            form.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
