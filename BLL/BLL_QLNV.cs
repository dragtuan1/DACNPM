using DACNPM.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DACNPM.BLL
{
    
    public class BLL_QLNV
    {
        private static BLL_QLNV _Instance;
        public static BLL_QLNV Instance
        {
            get
            {
                if (_Instance == null)
                    _Instance = new BLL_QLNV();
                return _Instance;
            }
            private set => _Instance = value;
        }
        public object GetAllEmployee_BLL()
        {
            DACNPM db = new DACNPM();
            var list = db.Employees.Select(p => new { p.ID_Employee, p.Name_Employee,p.Email,p.Position,p.Phone,p.Account.Username});
            return list.ToList();
        }
        public void showRole_BLL(ComboBox cbb)
        {
            DACNPM db = new DACNPM();
            if (cbb.Items.Count != 0)
            {
                cbb.Items.Clear();
            }
            else
            {
                foreach (Entities.Employee i in db.Employees)
                {
                    cbb.Items.Add(new CBBItem
                    {
                        Text = i.Account.Type_Account.Name_Type,
                        Value = i.Account.Type_Account.ID_Type_Account
                    });
                }
            }
        }
    }
}
