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
                ID_Type_Account = 1,
                Question1 = "Dog",
                Question2 = "Yet"

            });
            context.Accounts.Add(new Entities.Account
            {
                ID_Account = 2,
                Username = "quangtruong",
                UserPassword = "123456",
                ID_Type_Account = 2,
                Question1 = "Cat",
                Question2 = "Alone"
            });
            context.Accounts.Add(new Entities.Account
            {
                ID_Account = 3,
                Username = "truongsanh",
                UserPassword = "123456",
                ID_Type_Account = 3,
                Question1 = "Dog",
                Question2 = "Yet"
            });
            context.Customers.Add(new Entities.Customer
            {
                ID_Customer = 1,
                Customer_Address = "Hue",
                CMND = "192201493",
                Phone = "081759009",   
                Customer_Name = "Truong"
            });
            context.Customers.Add(new Entities.Customer
            {
                ID_Customer = 2,
                Customer_Address = "Quang Binh",
                CMND = "192201494",
                Phone = "081759008",
                Customer_Name = "Tuan"
            });
            context.Customers.Add(new Entities.Customer
            {
                ID_Customer = 3,
                Customer_Address = "Quang Nam",
                CMND = "192201493",
                Phone = "081759007",
                Customer_Name = "Sanh"
            });
            context.Drivers.Add(new Entities.Driver
            {
                ID_Driver = 1,
                Name_Driver = "Nguyen Van B",
                Phone = "123456654",
                CMND = "0124751234",
                Driver_Address = "Quang Binh",
                License = "123025778",
                Driver_State = false
            });
            context.Drivers.Add(new Entities.Driver
            {
                ID_Driver = 2,
                Name_Driver = "Nguyen Van C",
                Phone = "0817590009",
                CMND = "192201492",
                Driver_Address = "Hue",
                License = "1233654778",
                Driver_State = false
            });
            context.Drivers.Add(new Entities.Driver
            {
                ID_Driver = 3,
                Name_Driver = "Nguyen Van A",
                Phone = "123414789",
                CMND = "192201493",
                Driver_Address = "Quang Nam",
                License = "123361758",
                Driver_State = false
            });
            context.Vehicles.Add(new Entities.Vehicle { 
                ID_Vehicle = 1,
                License_Plate = "75M 20712",
                ID_Type_Vehicle = 1,
                ID_Driver = 1,
                Price = 80000,
                Vehicle_State = false
            });
            context.Vehicles.Add(new Entities.Vehicle
            {
                ID_Vehicle = 2,
                License_Plate = "97M 57712",
                ID_Type_Vehicle = 2,
                ID_Driver = 2,
                Price = 90000,
                Vehicle_State = true
            });
            context.Vehicles.Add(new Entities.Vehicle
            {
                ID_Vehicle = 3,
                License_Plate = "92M 57712",
                ID_Type_Vehicle = 3,
                ID_Driver = 3,
                Price = 100000,
                Vehicle_State = false
            });
            context.Type_Vehicles.Add(new Entities.Type_Vehicle
            {
                ID_Type_Vehicle = 1,
                Name_Type = "Xe Máy",
                Amount_Seat = 1,
            });
            context.Type_Vehicles.Add(new Entities.Type_Vehicle
            {
                ID_Type_Vehicle = 2,
                Name_Type = "Xe Oto",
                Amount_Seat = 4,
            });
            context.Type_Vehicles.Add(new Entities.Type_Vehicle
            {
                ID_Type_Vehicle = 3,
                Name_Type = "Xe Oto",
                Amount_Seat = 8,
            });
            context.Type_Vehicles.Add(new Entities.Type_Vehicle
            {
                ID_Type_Vehicle = 4,
                Name_Type = "Xe Oto",
                Amount_Seat = 16,
            });
            context.Type_Vehicles.Add(new Entities.Type_Vehicle
            {
                ID_Type_Vehicle = 5,
                Name_Type = "Xe Du Lich",
                Amount_Seat = 4,
            });
            context.Type_Vehicles.Add(new Entities.Type_Vehicle
            {
                ID_Type_Vehicle = 6,
                Name_Type = "Xe Du Lich",
                Amount_Seat = 8,
            });
            context.Type_Vehicles.Add(new Entities.Type_Vehicle
            {
                ID_Type_Vehicle = 7,
                Name_Type = "Xe Du Lich",
                Amount_Seat = 16,
            });
            context.Employees.Add(new Entities.Employee
            {
                ID_Employee = 1,
                Name_Employee = "Nguyen Quang Truong",
                Email = "nqtruong2510@gmail.com",
                ID_Account = 2,
                Phone = "0817590009"
            });
            context.Employees.Add(new Entities.Employee
            {
                ID_Employee = 2,
                Name_Employee = "Le Truong Sanh",
                Email = "sanh@gmail.com",
                ID_Account = 3,
                Phone = "0817590004"
            });
            context.Employees.Add(new Entities.Employee
            {
                ID_Employee = 3,
                Name_Employee = "Phan Anh Tuan",
                Email = "tuanphan@gmail.com",
                ID_Account = 1,
                Phone = "0817590005"
            });
            context.Contracts.Add(new Entities.Contract
            {
                ID_Contract = 1,
                ID_Employee = 1,
                ID_Customer = 1,
                Date_Borrow = DateTime.Now,
                Date_Return = DateTime.Now,
                Total_Bill = 150000,
                Contract_State = true,
            });
            context.Contracts.Add(new Entities.Contract
            {
                ID_Contract = 2,
                ID_Employee = 2,
                ID_Customer = 2,
                Date_Borrow = DateTime.Now,
                Date_Return = DateTime.Now,
                Total_Bill = 200000,
                Contract_State = false,
            });
            context.Contracts.Add(new Entities.Contract
            {
                ID_Contract = 3,
                ID_Employee = 3,
                ID_Customer = 3,
                Date_Borrow = DateTime.Now,
                Date_Return = DateTime.Now,
                Total_Bill = 400000,
                Contract_State = false
            });
            context.Detail_Contracts.Add(new Entities.Detail_Contract
            {
                ID_Detail_Contract = 1,
                ID_Contract = 1,
                ID_Vehicle = 1,
                Total_Price = 300000,
                Date_Make_Contract = DateTime.Now
            });
            context.Detail_Contracts.Add(new Entities.Detail_Contract
            {
                ID_Detail_Contract = 2,
                ID_Contract = 1,
                ID_Vehicle = 2,
                Total_Price = 100000,
                Date_Make_Contract = DateTime.Now
            });
            context.Detail_Contracts.Add(new Entities.Detail_Contract
            {
                ID_Detail_Contract = 3,
                ID_Contract = 2,
                ID_Vehicle = 3,
                Total_Price = 300000,
                Date_Make_Contract = DateTime.Now
            });
            context.Detail_Contracts.Add(new Entities.Detail_Contract
            {
                ID_Detail_Contract = 4,
                ID_Contract = 3,
                ID_Vehicle = 2,
                Total_Price = 300000,
                Date_Make_Contract = DateTime.Now
            });
            context.MN_Salaries.Add(new Entities.MN_Salary
            {
                ID_Salary = 1,
                ID_Employee = 1,
                Total_Time = 3,
                Month_Work = DateTime.Now,
                Salary = 5000000,
                Total_Contract = 3
            });
            context.MN_Salaries.Add(new Entities.MN_Salary
            {
                ID_Salary = 2,
                ID_Employee = 2,
                Total_Time = 34,
                Month_Work = DateTime.Now,
                Salary = 5000000,
                Total_Contract = 23
            });
            context.MN_Salaries.Add(new Entities.MN_Salary
            {
                ID_Salary = 3,
                ID_Employee = 3,
                Total_Time = 10,
                Month_Work = DateTime.Now,
                Salary = 2000000,
                Total_Contract = 10
            });
        }
    }
}
