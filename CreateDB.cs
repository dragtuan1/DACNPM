using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DACNPM
{
    class CreateDB : CreateDatabaseIfNotExists<DACNPM> 
    {
        protected override void Seed(DACNPM context)
        {
            context.Type_Accounts.Add(new Entities.Type_Account
            {
                ID_Type_Account = 1,
                Name_Type = "Admin",
                Day_Update = DateTime.Now,
                Salary = 100
            });
            context.Type_Accounts.Add(new Entities.Type_Account
            {
                ID_Type_Account = 2,
                Name_Type = "NhanVien",
                Day_Update = DateTime.Now,
                Salary = 20
            });
            context.Type_Accounts.Add(new Entities.Type_Account
            {
                ID_Type_Account = 3,
                Name_Type = "QuanLy",
                Day_Update = DateTime.Now,
                Salary = 50
            });
            context.Accounts.Add(new Entities.Account
            {
                ID_Account = 1,
                Username = "anhtuan",
                UserPassword = "123456",
                ID_Type_Account = 1
            });
            context.Accounts.Add(new Entities.Account
            {
                ID_Account = 2,
                Username = "quangtruong",
                UserPassword = "123456",
                ID_Type_Account = 2
            });
            context.Accounts.Add(new Entities.Account
            {
                ID_Account = 3,
                Username = "truongsanh",
                UserPassword = "123456",
                ID_Type_Account = 3
            });
        }
    }
}
