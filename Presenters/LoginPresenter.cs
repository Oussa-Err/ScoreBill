using scoreBill.Models;
using scoreBill.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace scoreBill.Presenters
{
    public class LoginPresenter
    {


        public string login { get; set; }
        public string password { get; set; }

        ILogin loginUser;
        public LoginPresenter(ILogin login)
        {
            loginUser = login;
        }


        public void logUser(AdminModel admin)
        {
            admin.Login = loginUser.Login;
            admin.Password = loginUser.Password;
        }

    }
}
