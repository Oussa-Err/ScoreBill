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
        ILogin loginUser;
        public LoginPresenter(ILogin login)
        {
            loginUser = login;
        }


        public void logUser(AdminModel admin)
        {
            admin.Login1 = loginUser.Login;
            admin.Password1 = loginUser.Password;
        }

    }
}
