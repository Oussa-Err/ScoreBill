using Microsoft.VisualBasic;
using scoreBill.Models;
using scoreBill.Views;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.CompilerServices;

namespace scoreBill.Presenters
{
    public class LoginPresenter
    {
        public DbConnection db = new();
        public bool ValidateLogin(string login, string password)
        {
            try
            {
                SqlCommand cmd = new()
                {
                    CommandType = CommandType.Text,
                    CommandText = "use espegic; SELECT COUNT(*) FROM Admin WHERE Login = @login AND Password = @password"
                };
                cmd.Parameters.AddWithValue("@login", login);
                cmd.Parameters.AddWithValue("@password", password);

                int count = (int)db.ExecScalar(cmd);
                bool isLoggedIn = count > 0;
                if (count == 0) {
                    MessageBox.Show("login et / ou mot de passe incorrecte\n", "Login error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                return isLoggedIn;
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message, "Login error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
    }
}
