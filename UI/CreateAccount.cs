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
    public partial class CreateAccountForm : Form
    {
        public CreateAccountForm()
        {
            InitializeComponent();
        }

        CreateAccountBLL BLL = new CreateAccountBLL();
        CreateAccountClasses classes = new CreateAccountClasses();

        private void ButtonCreateAccount_Click(object sender, EventArgs e)
        {
            BLL.Username = textBoxUseerName.Text;
            BLL.Password = textBoxPassword.Text;
            BLL.ContactNo = textBoxConactNo.Text;
            BLL.Email = textBoxEmail.Text;
            BLL.Address = textBoxAddress.Text;
            BLL.Gender = comboBoxGender.Text;

            bool success = classes.Insert(BLL);

            if (success == true)
            {
                MessageBox.Show("Account Created successfully, now login with your new account!");
                this.Hide();
                FormLogIn formLogIn = new FormLogIn();
                formLogIn.Show();
            }
            else
            {
                MessageBox.Show("Failed to create account");
            }
        }

        private void Label7_Click(object sender, EventArgs e)
        {
            this.Close();
            FormLogIn formLogIn = new FormLogIn();
            formLogIn.Show();
        }
    }
}
