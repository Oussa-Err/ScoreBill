using scoreBill.Presenters;
using scoreBill.Utils;
using scoreBill.Views;

namespace scoreBill
{
    public partial class LoginForm : Form
    {
        private readonly LoginPresenter _presenter;

        public LoginForm()
        {
            InitializeComponent();
            _presenter = new LoginPresenter();
        }

        private void LoginClick(object sender, EventArgs e)
        {
                if (string.IsNullOrEmpty(LoginBox1.Text) || string.IsNullOrEmpty(PasswordBox1.Text))
                {
                    MessageBox.Show("login et/ou mot de passe vide\n", "Login error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string login = LoginBox1.Text;
                string password = PasswordBox1.Text;

               if (_presenter.ValidateLogin(login, password))
                {
                    GererClasseForm gererClasseForm = new();
                    FormPositionUtil.OpenNewForm(this, gererClasseForm);
                    MessageBox.Show("bienvenue", "Login Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
