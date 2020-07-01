using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlTypes;
using DACNPM.Entities;

namespace DACNPM.Library_Control
{
    public partial class TK_DoanhThu : UserControl
    {
        public TK_DoanhThu()
        {
            InitializeComponent();
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {             
            DateTime Year = Doanh_Thu.Value;
            if (BLL_TK_DoanhThu.Instance.BLL_FindYear(Year))
            {
                Entities.TK_DoanhThu tk1 = new Entities.TK_DoanhThu();
                tk1 = BLL_TK_DoanhThu.Instance.GetLuong12Thang(Year);
                foreach (var series in Bieu_Do.Series)
                {
                    series.Points.Clear();
                }
                Bieu_Do.ChartAreas["ChartArea1"].AxisX.Title = "Tháng";
                Bieu_Do.ChartAreas["ChartArea1"].AxisY.Title = "Doanh thu(VND)";
                Bieu_Do.Series["Doanh Thu"].Points.AddXY("1", tk1.Thang1);
                Bieu_Do.Series["Doanh Thu"].Points.AddXY("2", tk1.Thang2);
                Bieu_Do.Series["Doanh Thu"].Points.AddXY("3", tk1.Thang3);
                Bieu_Do.Series["Doanh Thu"].Points.AddXY("4", tk1.Thang4);
                Bieu_Do.Series["Doanh Thu"].Points.AddXY("5", tk1.Thang5);
                Bieu_Do.Series["Doanh Thu"].Points.AddXY("6", tk1.Thang6);
                Bieu_Do.Series["Doanh Thu"].Points.AddXY("7", tk1.Thang7);
                Bieu_Do.Series["Doanh Thu"].Points.AddXY("8", tk1.Thang8);
                Bieu_Do.Series["Doanh Thu"].Points.AddXY("9", tk1.Thang9);
                Bieu_Do.Series["Doanh Thu"].Points.AddXY("10", tk1.Thang10);
                Bieu_Do.Series["Doanh Thu"].Points.AddXY("11", tk1.Thang11);
                Bieu_Do.Series["Doanh Thu"].Points.AddXY("12", tk1.Thang12);
                Bieu_Do.ChartAreas["ChartArea1"].AxisX.Interval = 1;
                tongtien.Text = tk1.TinhTong().ToString();
            }
            else MessageBox.Show("Không tồn tại hợp đồng nào trong năm này");
        }
        private void Doanh_Thu_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
