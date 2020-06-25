using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DACNPM.Entities;


namespace DACNPM
{
    public class BLL_QLNV
    {
        private static BLL_QLNV _Instance;
        public static BLL_QLNV Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new BLL_QLNV();
                }
                return _Instance;
            }
            private set => _Instance = value;
        }
        private BLL_QLNV()
        {
        }
        public bool AddNV_BLL(Employee emp)
        {
            try
            {
                DACNPM DB = new DACNPM();
                DB.Employees.Add(emp);
                DB.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public object GetALL_EPL()
        {
            DACNPM DB = new DACNPM();
            var List = DB.Employees.Select(p => new { p.ID_Employee,p.Name_Employee,p.Email,p.Position,p.Phone,p.MN_Salaries }) ;
            return List.ToList();
        }
        public bool DelNV_BLL(List<int> List_ID)
        {
            try
            {
                DACNPM DB = new DACNPM();
                foreach (Employee i in DB.Employees)
                {
                    foreach (int j in List_ID.ToArray())
                    {
                        if (i.ID_Employee == j)
                        {
                            DB.Employees.Remove(i);
                        }
                    }
                }
                DB.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
