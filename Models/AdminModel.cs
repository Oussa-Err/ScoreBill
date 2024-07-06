using Microsoft.VisualBasic;
using scoreBill.Presenters;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace scoreBill.Models
{
    public class AdminModel
    {
        private string login;
        private string password;
        public string Login { get => login; set => login = value; }
        public string Password { get => password; set => password = value; }        
    }
}
