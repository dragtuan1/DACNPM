using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DACNPM.Entities
{
    public class AccountLogin
    {
        public String User { get; set; }
        public String Pass { get; set; }

        private static AccountLogin instance;

        public static AccountLogin getInstance()
        {
            if (instance == null)
            {
                instance = new AccountLogin();
            }

            return instance;
        }

        public static void setInstance(AccountLogin instance)
        {
            AccountLogin.instance = instance;
        }

        public AccountLogin()
        {

        }

        public AccountLogin(String user, String pass)
        {
            this.User = user;
            this.Pass = pass;
        }
    }
    //Aádasdasd
}
