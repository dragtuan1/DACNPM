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
    public partial class TK_HopDong : UserControl
    {
        public TK_HopDong()
        {
            InitializeComponent();
        }

        private void TK_HopDong_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime DayStart = Ngay_BD.Value;
            DateTime DayEnd = Ngay_KT.Value;
            if(DayStart > DayEnd)
            {
                MessageBox.Show("Vui lòng nhập ngày đúng khoảng thời gian");

            }
            else if(DayStart > DateTime.Now || DayEnd > DateTime.Now)
            {
                MessageBox.Show("Ngày làm hợp đồng không thể quá ngày hiện tại");
            }    
            else
            {
                dataGridView1.DataSource = BLL_TK_HopDong.Instance.GetContract_ByTime(DayStart, DayEnd);
             //   textBox1.Text = BLL_TK_HopDong.Instance.GetContract_ByTime(DayStart, DayEnd);
            }

           

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
