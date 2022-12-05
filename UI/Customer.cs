using Billing_System.BLL;
using Billing_System.DAL;
using MySql.Data.MySqlClient;
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
    public partial class FormCustomerDetails : Form
    {
        public FormCustomerDetails()
        {
            InitializeComponent();
        }

        private void ButtonSell_Click(object sender, EventArgs e)
        {
            SellProduct sellProduct = new SellProduct();
            sellProduct.Show();
            this.Hide();
        }

        private void ButtonSellsPersons_Click(object sender, EventArgs e)
        {
            UserDetail userDetail = new UserDetail();
            userDetail.Show();
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

        readonly CustomerBLL b = new CustomerBLL();
        readonly CustomerDAL d = new CustomerDAL();

        private void Clear()
        {
            textBoxContactNo.Text = "";
        }

        private void FormCustomerDetails_Load(object sender, EventArgs e)
        {
            DataTable dataTable = d.JoinHistory();
            dataGridViewCustomerDetail.DataSource = dataTable;
        }

        private void ButtonDelete_Click(object sender, EventArgs e)
        {
            b.Contactno = textBoxContactNo.Text;

            bool isSuccess = d.Delete(b);

            if (isSuccess == true)
            {
                MessageBox.Show("Customer Successfully Deleted!");
                Clear();
            }
            else
            {
                MessageBox.Show("Failed to Delete customer! Try again later");
            }

            DataTable dataTable = d.JoinHistory();
            dataGridViewCustomerDetail.DataSource = dataTable;
        }

        private void DataGridViewCustomerDetail_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int index = e.RowIndex;

            textBoxContactNo.Text = dataGridViewCustomerDetail.Rows[index].Cells[0].Value.ToString();
        }


        static readonly string myconnection = System.Configuration.ConfigurationManager.ConnectionStrings["ConnectString"].ConnectionString;

        private void TextBoxContactNo_TextChanged(object sender, EventArgs e)
        {
            string keyword = textBoxContactNo.Text;

            if (keyword == "")
            {
                DataTable dataTable = d.JoinHistory();
                dataGridViewCustomerDetail.DataSource = dataTable;
            }
            else
            {
                string sql = "SELECT c.contactno as 'Customer Phone No', h.productName as 'Product Name', h.price as 'Product Price', h.quantity as Quantity, h.totalprice as 'Grand Total', h.date as 'Sold Date' FROM history as h RIGHT OUTER JOIN customer as c ON c.contactno = h.contactno WHERE c.contactno LIKE '%" + keyword + "%'";
                MySqlConnection mySqlConnection = new MySqlConnection(myconnection);
                MySqlCommand mySqlCommand = new MySqlCommand(sql, mySqlConnection);
                MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(mySqlCommand);
                DataTable dataTable = new DataTable();
                mySqlConnection.Open();
                mySqlDataAdapter.Fill(dataTable);
                dataGridViewCustomerDetail.Columns[5].Width = 250;
                dataGridViewCustomerDetail.DataSource = dataTable;
                mySqlDataAdapter.Dispose();
            }
        }

        private void Label3_Click(object sender, EventArgs e)
        {
            this.Close();
            FormLogIn formLogIn = new FormLogIn();
            formLogIn.Show();
        }
    }
}
