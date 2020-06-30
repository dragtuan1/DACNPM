using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DACNPM.BLL
{
    public class InitForm_BLL
    {
        public void ReloadState()
        {
            DACNPM db = new DACNPM();

            List<Entities.Contract> contracts = db.Contracts.Where(p => p.Date_Return > DateTime.Now).ToList();
            
            foreach(Entities.Contract item in contracts)
            {
                item.Contract_State = true;
                foreach(Entities.Detail_Contract i in item.Detail_Contracts)
                {
                    i.Vehicle.Vehicle_State = true;
                    i.Vehicle.Driver.Driver_State = true;
                }
            }

            List<Entities.Contract> contracts2 = db.Contracts.Where(p => p.Date_Return < DateTime.Now).ToList();

            foreach (Entities.Contract item in contracts2)
            {
                item.Contract_State = false;
                foreach (Entities.Detail_Contract i in item.Detail_Contracts)
                {
                    i.Vehicle.Vehicle_State = false;
                    i.Vehicle.Driver.Driver_State = false;
                }
            }
            db.SaveChanges();
        }
    }
}
