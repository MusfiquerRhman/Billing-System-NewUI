using Billing_System.BLL;
using Billing_System.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BillingSystemNewUI.UI
{
    public partial class FormLogIn : Form
    {
        public FormLogIn()
        {
            InitializeComponent();
        }

        readonly LoginBLL BLL = new LoginBLL();
        readonly LoginDAL DAL = new LoginDAL();
        readonly CreateAccountClasses classes = new CreateAccountClasses();

        public static string loggedIn;
        public static int loggedInID;

        private void ButtonLogIn_Click(object sender, EventArgs e)
        {
            BLL.Username = textBoxUserName.Text.Trim();
            BLL.Password = textBoxPassword.Text.Trim();

            bool isSuccess = DAL.Login(BLL);

            if (isSuccess == true)
            {
                this.Hide();
                loggedIn = BLL.Username;
                loggedInID = classes.SelectId(BLL.Username, BLL.Password);
                SellProduct mainMenu = new SellProduct();
                mainMenu.Show();
            }
            else
            {
                MessageBox.Show("Login Failed! try again.");
            }
        }

        private void ButtonCreateAccount_Click(object sender, EventArgs e)
        {
            this.Hide();
            CreateAccountForm createAccountForm = new CreateAccountForm();
            createAccountForm.Show();
        }

        private void Label3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
