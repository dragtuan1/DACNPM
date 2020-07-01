using DACNPM.Entities;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace DACNPM.Library_Control
{
    public partial class QL_Vehicle : UserControl
    {
        public delegate void Mydel();
        public Mydel del { get; set; }
        public QL_Vehicle()
        {
            InitializeComponent();
            setView();
        }
        public void setView()
        {
            foreach (Type_Vehicle i in BLL.QLXe_BLL.Instance.getTypeVehiCle_BLL())
            {
                cbb_Type_Vehicle.Items.Add(i);
            }
            foreach (Driver i in BLL.QLXe_BLL.Instance.GetDrivers_BLL())
            {
                cbb_Driver.Items.Add(i);
            }

            cbb_Type_Vehicle.SelectedIndex = -1;
            cbb_Driver.SelectedIndex = -1;

            DGV_QLXe.DataSource = BLL.QLXe_BLL.Instance.getVehicles_BLL();
        }

        private void DGV_QLXe_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewSelectedRowCollection data = DGV_QLXe.SelectedRows;
            if (data.Count == 1)
            {
                txt_BS.Text = data[0].Cells["License_Plate"].Value.ToString();
                txt_Gia.Text = data[0].Cells["Price"].Value.ToString();
                int index1 = cbb_Type_Vehicle.Items
                    .IndexOf(BLL.QLXe_BLL.Instance.getVehicleByID_BLL(Convert
                    .ToInt32(data[0].Cells["ID_Vehicle"]
                    .Value.ToString())).Type_Vehicle);
                cbb_Type_Vehicle.SelectedIndex = index1;
                int index2 = cbb_Driver.Items
                    .IndexOf(BLL.QLXe_BLL.Instance.getVehicleByID_BLL(Convert
                    .ToInt32(data[0].Cells["ID_Vehicle"]
                    .Value.ToString())).Driver);
                cbb_Driver.SelectedIndex = index2;
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (txt_BS.Text == "" || txt_Gia.Text == "" || cbb_Driver.SelectedIndex == -1 || cbb_Type_Vehicle.SelectedIndex == -1)
            {
                MessageBox.Show("Vui long nhap day du thong tin");
            }
            else
            {
                Vehicle veh = new Vehicle
                {
                    License_Plate = txt_BS.Text,
                    ID_Type_Vehicle = ((Type_Vehicle)cbb_Type_Vehicle.SelectedItem).ID_Type_Vehicle,
                    ID_Driver = Convert.ToInt32(BLL.QLXe_BLL.Instance.getDriverByID_BLL(((Driver)cbb_Driver.SelectedItem).ID_Driver).ID_Driver),
                    Price = Convert.ToInt32(txt_Gia.Text),
                    Vehicle_State = false
                };
                BLL.QLXe_BLL.Instance.AddVehicle_BLL(veh);
                DGV_QLXe.DataSource = BLL.QLXe_BLL.Instance.getVehicles_BLL();
                Reset();
            }
        }
        private void btn_delete_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection r = DGV_QLXe.SelectedRows;
            if (r.Count != 0)
            {
                List<int> List_ID = new List<int>();

                foreach (DataGridViewRow j in r)
                {
                    List_ID.Add((int)j.Cells["ID_Vehicle"].Value);
                }
                BLL.QLXe_BLL.Instance.DelVehicle_BLL(List_ID);
                DGV_QLXe.DataSource = BLL.QLXe_BLL.Instance.getVehicles_BLL();
                Reset();
            }
            else
            {
                MessageBox.Show("Vui Lòng Chọn Một Đối Tượng cần xóa");
            }
        }

        private void Reset()
        {
            txt_BS.Text = "";
            txt_Gia.Text = "";
            cbb_Type_Vehicle.SelectedIndex = -1;
            cbb_Driver.SelectedIndex = -1;
            txt_Search.Text = "";
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            if (txt_BS.Text == "" || txt_Gia.Text == "" || cbb_Driver.SelectedIndex == -1 || cbb_Type_Vehicle.SelectedIndex == -1)
            {
                MessageBox.Show("Vui long nhap day du thong tin");
            }
            else
            {
                DataGridViewSelectedRowCollection r = DGV_QLXe.SelectedRows;
                if (r.Count == 1)
                {
                    Vehicle veh = new Vehicle
                    {
                        ID_Vehicle = Convert.ToInt32(r[0].Cells["ID_Vehicle"].Value.ToString()),
                        License_Plate = txt_BS.Text,
                        ID_Type_Vehicle = ((Type_Vehicle)cbb_Type_Vehicle.SelectedItem).ID_Type_Vehicle,
                        ID_Driver = Convert.ToInt32(BLL.QLXe_BLL.Instance.getDriverByID_BLL(((Driver)cbb_Driver.SelectedItem).ID_Driver).ID_Driver),
                        Price = Convert.ToInt32(txt_Gia.Text),
                        Vehicle_State = false
                    };
                    if (BLL.QLXe_BLL.Instance.UpdateVehicle_BLL(veh))
                    {
                        MessageBox.Show("Update Thành Công ");
                        DGV_QLXe.DataSource = BLL.QLXe_BLL.Instance.getVehicles_BLL();
                        Reset();
                    }
                    else
                    {
                        MessageBox.Show("Error Data ");
                    };
                }
                else
                {
                    MessageBox.Show("Vui Lòng Chọn Khách Hàng Cần Sửa Thông Tin");
                }
            }
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string search = txt_Search.Text;
            DGV_QLXe.DataSource = BLL.QLXe_BLL.Instance.SearchVehicle_BLL(search);
            Reset();
        }

        private void btn_AddTX_Click(object sender, EventArgs e)
        {
            del();
        }
    }
}
