﻿using System;
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
        public delegate void Mydel();
        public Mydel del { get; set; }
        public string Username { get; set; }
        public QL_HopDong()
        {
            InitializeComponent();
            gw_hoadon.DataSource = BLL.QLHopDong_BLL.Instance.getHopDong_BLL();
            SetView();
            
        }

        public void SetView()
        {
            if(cbbLoaiXe.Items != null)
            {
                cbbLoaiXe.Items.Clear();
            }

            if(cbbXe.Items != null)
            {
                cbbXe.Items.Clear();
                cbbXe.Text = "";
            }

            foreach(Entities.Type_Vehicle item in BLL.QLHopDong_BLL.Instance.getAllTypeVehicle())
            {
                cbbLoaiXe.Items.Add(item);
            }
            if (cbb_HopDong.Items != null)
            {
                cbb_HopDong.Items.Clear();
            }
            foreach(Entities.Customer item in BLL_QLKH.Instance.GetADD_KH())
            {
                cbb_HopDong.Items.Add(item.CMND);
            }
        }
  
        private void them_hd_Click(object sender, EventArgs e)
        {
            if(ngaythem.Value >= ngaytra.Value || DateTime.Now > ngaythem.Value)
            {
                MessageBox.Show("Lỗi ngày thực thi hợp đồng");
            } else
            {
                try
                {
                    int id_customer = (BLL.QLHopDong_BLL.Instance.getCustomerByCMND_BLL(cbb_HopDong.Text)).ID_Customer;
                    BLL.QLHopDong_BLL.Instance.addHopDong_BLL(
                    (BLL.QLHopDong_BLL.Instance.getAcountByUserName_BLL(Entities.AccountLogin.getInstance().User).Employees.ToList())[0].ID_Employee,

                    (BLL.QLHopDong_BLL.Instance.getCustomerByCMND_BLL(cbb_HopDong.SelectedItem.ToString())).ID_Customer,

                //    id_customer,

                    ngaythem.Value,
                    ngaytra.Value,
                    0,
                    true
                    );

                    MessageBox.Show("Them Thanh Cong");

                    gw_hoadon.DataSource = BLL.QLHopDong_BLL.Instance.getHopDongByIDCustomer_BLL((BLL.QLHopDong_BLL.Instance.getCustomerByCMND_BLL(cbb_HopDong.SelectedItem.ToString())).ID_Customer);

                }
                catch
                {
                    MessageBox.Show("Chưa có chứng mình nhân dân");
                }
            }
            

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int index = cbbType.SelectedIndex;
            if(index == 0)
            {
                gw_hoadon.DataSource = BLL.QLHopDong_BLL.Instance.getHopDongBySTD_BLL(txtSearch.Text);
            } else if(index == 2)
            {
                gw_hoadon.DataSource = BLL.QLHopDong_BLL.Instance.getHopDongByName_BLL(txtSearch.Text);
            } else if (index == 1)
            {
                gw_hoadon.DataSource = BLL.QLHopDong_BLL.Instance.getHopDongByCNMD_BLL(txtSearch.Text);
            }
        }

        private void sua_hd_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(gw_hoadon.SelectedRows[0].Cells["ID_Contract"].Value.ToString());
                if(BLL.QLHopDong_BLL.Instance.UpdateHopDong_BLL(id, ngaythem.Value, ngaytra.Value))
                {
                    MessageBox.Show("Sua thanh cong");
                } else
                {
                    MessageBox.Show("Hop dong het han");
                }
                gw_hoadon.DataSource = BLL.QLHopDong_BLL.Instance.getHopDong_BLL();
            }
            catch
            {
                MessageBox.Show("Error");
            }
        }

        private void gw_hoadon_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewSelectedRowCollection data = gw_hoadon.SelectedRows;
            if(data.Count == 1)
            {
                cbb_HopDong.Text = (BLL.QLHopDong_BLL.Instance.getHopDongByID_BLL(Convert.ToInt32(data[0].Cells["ID_Contract"].Value.ToString()))).Customer.CMND;
                ngaythem.Value = Convert.ToDateTime(data[0].Cells["Date_Borrow"].Value.ToString());
                ngaytra.Value = Convert.ToDateTime(data[0].Cells["Date_Return"].Value.ToString());
                txtma_hd_2.Text = data[0].Cells["ID_Contract"].Value.ToString();
                gw_chitiethoadon.DataSource = BLL.QLHopDong_BLL.Instance.getAllDetailHoaDon(Convert.ToInt32(data[0].Cells["ID_Contract"].Value.ToString()));
            }
        }

        private void xoa_hd_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection r = gw_hoadon.SelectedRows;

            if(r.Count > 0)
            {
                string message = "Bạn muốn xóa hợp đồng ?";
                const string caption = "Form Delete";
                var result = MessageBox.Show(message, caption,
                                             MessageBoxButtons.YesNo,
                                             MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        foreach (DataGridViewRow item in r)
                        {
                            int id = Convert.ToInt32(item.Cells["ID_Contract"].Value.ToString());
                            BLL.QLHopDong_BLL.Instance.deleteHopDongByID(id);
                        }
                        MessageBox.Show("Xóa thành công");
                        SetView();
                        gw_hoadon.DataSource = BLL.QLHopDong_BLL.Instance.getHopDong_BLL();
                        gw_chitiethoadon.DataSource = null;
                    }
                    catch
                    {
                        MessageBox.Show("Error");
                    }
                }
            } else
            {
                MessageBox.Show("Vui lòng chọn hợp đồng cần xóa");
            }

        }

        private void them_ct_Click(object sender, EventArgs e)
        {
            try
            {
                int check = BLL.QLHopDong_BLL.Instance.addDetailHopDong_BLL(Convert.ToInt32(txtma_hd_2.Text), ((Entities.Vehicle)cbbXe.SelectedItem).License_Plate);
                if (check == 1)
                {
                    MessageBox.Show("Them xe thanh cong");
                } else if(check == 2)
                {
                    MessageBox.Show("hop dong het han");
                } else if(check == 3)
                {
                    MessageBox.Show("Error");
                }

                SetView();

                gw_chitiethoadon.DataSource = BLL.QLHopDong_BLL.Instance.getAllDetailHoaDon(Convert.ToInt32(txtma_hd_2.Text));
                gw_hoadon.DataSource = BLL.QLHopDong_BLL.Instance.getHopDong_BLL();
            }
            catch
            {
                MessageBox.Show("Error");
            }
        }

        private void xoa_ct_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection data = gw_chitiethoadon.SelectedRows;
            if(data.Count > 0)
            {
                try
                {
                    foreach (DataGridViewRow i in data)
                    {
                        int id = Convert.ToInt32(i.Cells["ID_Detail_Contract"].Value.ToString());
                        BLL.QLHopDong_BLL.Instance.deleteDetailHopDongByBienSo_BLL(id);
                    }
                  
                    gw_chitiethoadon.DataSource = BLL.QLHopDong_BLL.Instance.getAllDetailHoaDon(Convert.ToInt32(txtma_hd_2.Text));
                    gw_hoadon.DataSource = BLL.QLHopDong_BLL.Instance.getHopDong_BLL();
               
                }
                catch
                {
                    MessageBox.Show("Error");
                }
                
            } else
            {
                MessageBox.Show("Error");
            }
        }


        private void cbbLoaiXe_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbbXe.Items != null)
            {
                cbbXe.Items.Clear();
                cbbXe.Text = "";
            }

            Entities.Type_Vehicle type_Vehicle = (Entities.Type_Vehicle)cbbLoaiXe.SelectedItem;

            List<Entities.Vehicle> vehicles = BLL.QLHopDong_BLL.Instance.getVehicleByState_BLL(type_Vehicle.ID_Type_Vehicle);

            if(vehicles.Count == 0)
            {
                MessageBox.Show("Hết xe loại này phục vụ");
            }

            foreach (Entities.Vehicle item in vehicles)
            {
                cbbXe.Items.Add(item);
            }

            try
            {
                cbbXe.SelectedIndex = 0;
            }
            catch
            {

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            del();
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            if(gw_hoadon.Rows.Count == 0)
            {
                MessageBox.Show("Dữ liệu rỗng");
            } else
            {
                List<int> id = new List<int>();

                foreach(DataGridViewRow item in gw_hoadon.Rows)
                {
                    id.Add(Convert.ToInt32(item.Cells["ID_Contract"].Value.ToString()));
                }

                List<Entities.Contract> contracts = BLL.QLHopDong_BLL.Instance.sortDateContract_BLL(id);

                gw_hoadon.DataSource = contracts.Select(p => new { p.ID_Contract, p.Customer.Customer_Name, p.Employee.Name_Employee, p.Date_Borrow, p.Date_Return, p.Total_Bill }).ToList();
            }
        }

        private void ngaytra_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
