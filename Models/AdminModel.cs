using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace scoreBill.Models
{
    public class AdminModel
    {
        private string login;
        private string password;

        // propreties and validation
        public string Login { get => login; set => login = value; }
        public string Password { get => password; set => password = value; }
    }
}
