using scoreBill.Presenters;
using scoreBill.Views;

namespace scoreBill
{
    public partial class LoginForm : Form, ILogin
    {
        string ILogin.Login { get => LoginBox1.Text; set => LoginBox1.Text = value; }

        string ILogin.Password { get => PasswordBox1.Text; set => PasswordBox1.Text = value; }

        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginClick(object sender, EventArgs e)
        {
            if (PasswordBox1.Text == "" || LoginBox1.Text == "")
            {
                MessageBox.Show("login et/ou mot de passe vide\n", "Login error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                LoginPresenter presenter = new();
                presenter.logUser(this);

                // montrer GererClasseForm et 
                GererClasseForm classesForm = new();
                classesForm.Show();
                this.Visible = false;
            }

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
