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
    public partial class QL_HopDong : UserControl
    {
        public string Username { get; set; }
        public QL_HopDong()
        {
            InitializeComponent();
            gw_hoadon.DataSource = BLL.QLHopDong_BLL.Instance.getHopDong_BLL();
        }

  
        private void them_hd_Click(object sender, EventArgs e)
        {
            try
            {
                BLL.QLHopDong_BLL.Instance.addHopDong_BLL(
                (BLL.QLHopDong_BLL.Instance.getAcountByUserName_BLL(Entities.AccountLogin.getInstance().User).Employees.ToList())[0].ID_Employee,
                (BLL.QLHopDong_BLL.Instance.getCustomerByCMND_BLL(txtCMND_QLHopDong.Text)).ID_Customer,
                ngaythem.Value,
                ngaytra.Value,
                0,
                true
                );

                gw_hoadon.DataSource = BLL.QLHopDong_BLL.Instance.getHopDong_BLL();
                  
            }
            catch
            {
                MessageBox.Show("Error");
            }

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int index = cbbType.SelectedIndex;
            if(index == 0)
            {
                gw_hoadon.DataSource = BLL.QLHopDong_BLL.Instance.getHopDongBySTD_BLL(txtSearch.Text);
            } else if(index == 1)
            {

            }
        }
    }
}
