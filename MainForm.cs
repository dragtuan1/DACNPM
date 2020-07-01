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

namespace DACNPM
{
    public partial class MainForm : Form
    {
        public string Username { get; set; }
        public int ID_NV { get; set; }
        public MainForm(string username)
        {
            InitializeComponent();
            Username = username;
            loadUserData();
            customDesign();
            btnTK_LNV.Visible = false;
        //    btnMaximum.Visible = false;
            RoleLoad();
            BLL.InitForm_BLL.Instance.ReloadState();
        }

        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void loadUserData()
        {
            Entities.Account acc = BLL.QLNhanVien_BLL.Instance.getAccountByUsername_BLL(Username);        
            Lb_ChucVu.Text = acc.Type_Account.Name_Type;
            ID_NV = acc.ID_Account;
            Entities.Employee emp = BLL.QLNhanVien_BLL.Instance.getNhanVienByID_BLL(ID_NV);
            lb_Name.Text = emp.Name_Employee;
        }
        private void customDesign()
        {
            panelQuanLySubmenu.Visible = false;
            panelThongKeSubmenu.Visible = false;
        }
        private void HideSubmenu()
        {
          //  if (panelQuanLySubmenu.Visible == true)
         //       panelQuanLySubmenu.Visible = false;
         //   if (panelThongKeSubmenu.Visible == true)
         //     panelThongKeSubmenu.Visible = false;
        }
        private void showSubmenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                HideSubmenu();
                subMenu.Visible = true;
            }
            else subMenu.Visible = false;
        }
        private void btnSlide_Click(object sender, EventArgs e)
        {
            if (panelMenu.Width == 200)
            {
                panelMenu.Width = 70;
            }
            else panelMenu.Width = 200;
        }

        private void panelToolbar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure to close the application?", "Warning",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnMaximum_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnMaximum.Visible = false;
            btnResize.Visible = true;
        }

        private void btnResize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnMaximum.Visible = true;
            btnResize.Visible = false;
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure to close the application?", "Warning",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                this.Close();
            }
        }
        private void btnQL_Car_Click(object sender, EventArgs e)
        {
            panelMain.Controls.Clear();
            panelMain.Controls.Add(new Library_Control.QL_Vehicle());
        }
        private void btnQL_ChiPhi_Click(object sender, EventArgs e)
        {
            panelMain.Controls.Clear();
            panelMain.Controls.Add(new Library_Control.QL_ChiPhi());
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            panelMain.Controls.Clear();
            panelMain.Controls.Add(panel);
        }

        private void btnQL_NhanVien_Click(object sender, EventArgs e)
        {
            panelMain.Controls.Clear();
            panelMain.Controls.Add(new Library_Control.QL_NhanVien(Username));
        }

        private void btnQL_TaiXe_Click(object sender, EventArgs e)
        {
            panelMain.Controls.Clear();
            panelMain.Controls.Add(new Library_Control.QL_TaiXe());
        }
        private void btnQL_KH_Click(object sender, EventArgs e)
        {
            panelMain.Controls.Clear();
            panelMain.Controls.Add(new Library_Control.QL_KhachHang());
        }

        private void btnQL_TK_Click(object sender, EventArgs e)
        {
            panelMain.Controls.Clear();
            panelMain.Controls.Add(new Library_Control.QL_In4_TaiKhoan(Username,ID_NV));

            
        }

        private void btnQL_HD_Click(object sender, EventArgs e)
        {
            panelMain.Controls.Clear();
            Library_Control.QL_HopDong ql = new Library_Control.QL_HopDong();
            ql.del += new Library_Control.QL_HopDong.Mydel(showKhachHang);
            panelMain.Controls.Add(ql);
        }

        private void btnTK_DT_Click(object sender, EventArgs e)
        {
            panelMain.Controls.Clear();
            panelMain.Controls.Add(new Library_Control.TK_DoanhThu());


        }

        private void btnTK_HD_Click(object sender, EventArgs e)
        {
            panelMain.Controls.Clear();
            panelMain.Controls.Add(new Library_Control.TK_HopDong());
        }

        private void btnTK_LNV_Click(object sender, EventArgs e)
        {
            panelMain.Controls.Clear();
            panelMain.Controls.Add(new Library_Control.TK_LuongNV());
        }
        private void btnQuanLy_Click(object sender, EventArgs e)
        {
            showSubmenu(panelQuanLySubmenu);
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            showSubmenu(panelThongKeSubmenu);
        } 
        

        private void lbName_Click(object sender, EventArgs e)
        {

        }

        private void BtnQL_Car_Click(object sender, EventArgs e)
        {

        }
        private void RoleLoad()
        {
            Entities.Account acc = BLL.QLNhanVien_BLL.Instance.getAccountByUsername_BLL(Username);
            if (acc.ID_Type_Account == 1) 
            {

            }
            if (acc.ID_Type_Account == 2) 
            {
                btnQL_TK.Visible = false;
                btnQL_ChiPhi.Visible = false;
                btnQL_NhanVien.Visible = false;
                btnTK_DT.Visible = false;
                btnTK_HD.Visible = false;
                btnTK_LNV.Visible = false;
                panelQuanLySubmenu.Height = 200;
                panelThongKeSubmenu.Height = 0;
            }
            if (acc.ID_Type_Account == 3) 
            {

            }
        }
        public void showKhachHang()
        {
            panelMain.Controls.Clear();
            panelMain.Controls.Add(new Library_Control.QL_KhachHang());
        }
    }
}
