using Billing_System.BLL;
using Billing_System.DAL;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BillingSystemNewUI.UI
{
    public partial class UserDetail : Form
    {
        public UserDetail()
        {
            InitializeComponent();
        }

        private void ButtonSell_Click(object sender, EventArgs e)
        {
            SellProduct sellProduct = new SellProduct();
            sellProduct.Show();
            this.Hide();
        }

        private void ButtonCustomers_Click(object sender, EventArgs e)
        {
            FormCustomerDetails formCustomerDetails = new FormCustomerDetails();
            formCustomerDetails.Show();
            this.Hide();
        }

        private void ButtonHistory_Click(object sender, EventArgs e)
        {
            SellsHistory sellsHistory = new SellsHistory();
            sellsHistory.Show();
            this.Hide();
        }

        private void ButtonProducts_Click(object sender, EventArgs e)
        {
            ProductDetails productDetails = new ProductDetails();
            productDetails.Show();
            this.Hide();
        }

        readonly CreateAccountBLL bLL = new CreateAccountBLL();
        readonly CreateAccountClasses classes = new CreateAccountClasses();

        private void CLear()
        {
            textBoxUserID.Text = "";
            textBoxUseerName.Text = "";
            textBoxPassword.Text = "";
            textBoxConactNo.Text = "";
            textBoxEmail.Text = "";
            textBoxAddress.Text = "";
            comboBoxGender.Text = "";
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            bLL.Username = textBoxUseerName.Text;
            bLL.Password = textBoxPassword.Text;
            bLL.ContactNo = textBoxConactNo.Text;
            bLL.Email = textBoxEmail.Text;
            bLL.Address = textBoxAddress.Text;
            bLL.Gender = comboBoxGender.Text;

            bool success = classes.Insert(bLL);

            if (success == true)
            {
                MessageBox.Show("Account added successfully!");
                CLear();
            }
            else
            {
                MessageBox.Show("Failed to add account");
            }

            DataTable dataTable = classes.Select();
            dataGridViewUserDetail.DataSource = dataTable;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            bLL.Id = Convert.ToInt32(textBoxUserID.Text);
            bLL.Username = textBoxUseerName.Text;
            bLL.Password = textBoxPassword.Text;
            bLL.ContactNo = textBoxConactNo.Text;
            bLL.Email = textBoxEmail.Text;
            bLL.Address = textBoxEmail.Text;
            bLL.Gender = comboBoxGender.Text;

            bool isSuccess = classes.Update(bLL);

            if (isSuccess == true)
            {
                MessageBox.Show("Updated Successfully");
                CLear();
            }
            else
            {
                MessageBox.Show("Failed to Update, try again later");
            }

            DataTable dataTable = classes.Select();
            dataGridViewUserDetail.DataSource = dataTable;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            bLL.Id = Convert.ToInt32(textBoxUserID.Text);

            bool isSuccess = classes.Delete(bLL);

            if (isSuccess == true)
            {
                MessageBox.Show("User deleted successfully");
                CLear();
            }
            else
            {
                MessageBox.Show("Failed to delete, try again later!");
            }

            DataTable dataTable = classes.Select();
            dataGridViewUserDetail.DataSource = dataTable;
        }

        private void DataGridViewUserDetail_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rows = e.RowIndex;

            textBoxUserID.Text = dataGridViewUserDetail.Rows[rows].Cells[0].Value.ToString();
            textBoxUseerName.Text = dataGridViewUserDetail.Rows[rows].Cells[1].Value.ToString();
            textBoxPassword.Text = dataGridViewUserDetail.Rows[rows].Cells[2].Value.ToString();
            textBoxConactNo.Text = dataGridViewUserDetail.Rows[rows].Cells[3].Value.ToString();
            textBoxEmail.Text = dataGridViewUserDetail.Rows[rows].Cells[4].Value.ToString();
            textBoxAddress.Text = dataGridViewUserDetail.Rows[rows].Cells[5].Value.ToString();
            comboBoxGender.Text = dataGridViewUserDetail.Rows[rows].Cells[6].Value.ToString();
        }

        static readonly string myconnection = ConfigurationManager.ConnectionStrings["ConnectString"].ConnectionString;

        private void TextBoxSearch_TextChanged(object sender, EventArgs e)
        {
            string keyword = textBoxSearch.Text;
            string sql = "SELECT * FROM users WHERE username LIKE '%" + keyword + "%' OR ContactNO LIKE '%" + keyword + "%' OR address LIKE '%" + keyword + "%' OR eamil LIKE '%" + keyword + "%'";
            MySqlConnection mySqlConnection = new MySqlConnection(myconnection);
            MySqlCommand mySqlCommand = new MySqlCommand(sql, mySqlConnection);
            MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(mySqlCommand);
            DataTable dataTable = new DataTable();
            mySqlConnection.Open();
            mySqlDataAdapter.Fill(dataTable);
            dataGridViewUserDetail.DataSource = dataTable;
            mySqlDataAdapter.Dispose();
        }

        private void UserDetail_Load(object sender, EventArgs e)
        {
            DataTable dataTable = classes.Select();
            dataGridViewUserDetail.DataSource = dataTable;
        }

        private void Label8_Click(object sender, EventArgs e)
        {
            this.Close();
            FormLogIn formLogIn = new FormLogIn();
            formLogIn.Show();
        }
    }
}
