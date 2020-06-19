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
    public partial class QL_NhanVien : UserControl
    {
        public QL_NhanVien()
        {
            InitializeComponent();
            GetAllEmployee();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
        public void GetAllEmployee()
        {
            dataGridView1.DataSource = BLL.BLL_QLNV.Instance.GetAllEmployee_BLL();
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            DACNPM db = new DACNPM();
            DataGridViewSelectedRowCollection r = dataGridView1.SelectedRows;
            if(r.Count == 1)
            {
                int ID_Employee = Convert.ToInt32(r[0].Cells["ID_Employee"].Value);
                Entities.Employee emp = db.Employees.Where(p => p.ID_Employee == ID_Employee).FirstOrDefault();
                ma_nhan_vien.Text = emp.ID_Employee.ToString();
                ten_tk.Text = emp.Account.Username;
                ho_ten.Text = emp.Name_Employee;
                phone.Text = emp.Phone;
                luong_nv.Text = emp.Account.Type_Account.Salary.ToString();
                dia_chi.Text = emp.Email;             
            }
        }
        public void showRole()
        {
            BLL.BLL_QLNV.Instance.showRole_BLL(quyen_nv);
        }
    }
}
