namespace DACNPM
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class DACNPM : DbContext
    {
        // Your context has been configured to use a 'DACNPM' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'DACNPM.DACNPM' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'DACNPM' 
        // connection string in the application configuration file.
        public DACNPM()
            : base("name=DACNPM")
        {
            Database.SetInitializer<DACNPM>(new CreateDB());
        }
        public virtual DbSet<Entities.Account> Accounts { get; set; }
        public virtual DbSet<Entities.Type_Account> Type_Accounts { get; set; }
        public virtual DbSet<Entities.Employee> Employees { get; set; }
        public virtual DbSet<Entities.MN_Salary> MN_Salaries { get; set; }
        public virtual DbSet<Entities.Contract> Contracts { get; set; }

        public virtual DbSet<Entities.Customer> Customers { get; set; }
        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        // public virtual DbSet<MyEntity> MyEntities { get; set; }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}