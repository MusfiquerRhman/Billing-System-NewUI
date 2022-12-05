using Billing_System.BLL;
using Billing_System.DAL;
using BillingSystemNewUI.UI;
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

namespace BillingSystemNewUI
{
    public partial class ProductDetails : Form
    {
        public ProductDetails()
        {
            InitializeComponent();
        }

        private void Label8_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataTable dataTable = dAL.Select();
            dataGridViewProductDetail.DataSource = dataTable;
            dataGridViewProductDetail.Columns[4].Width = 200;
        }

        private void ButtonSellsPersons_Click(object sender, EventArgs e)
        {
            UserDetail userDetail = new UserDetail();
            userDetail.Show();
            this.Hide();
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

        readonly ProductsBLL bLL = new ProductsBLL();
        readonly ProductsDAL dAL = new ProductsDAL();

        private void Clear()
        {
            textBoxProductID.Text = "";
            textBoxProductName.Text = "";
            textBoxPrice.Text = "";
            textBoxManufacturer.Text = "";
            textBoxDescription.Text = "";
        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            bLL.Id = textBoxProductID.Text;
            bLL.ProductName = textBoxProductName.Text;
            bLL.Price = Convert.ToDouble(textBoxPrice.Text);
            bLL.Manufacturer = textBoxManufacturer.Text;
            bLL.Description = textBoxDescription.Text;

            bool isSuccess = dAL.Insert(bLL);

            if (isSuccess == true)
            {
                MessageBox.Show("Product Details added succesfully");
                Clear();
            }
            else
            {
                MessageBox.Show("Failed to add products, please try agin!");
            }

            DataTable dataTable = dAL.Select();
            dataGridViewProductDetail.DataSource = dataTable;
        }

        private void ButtonUpdate_Click(object sender, EventArgs e)
        {
            bLL.Id = textBoxProductID.Text;
            bLL.ProductName = textBoxProductName.Text;
            bLL.Price = Convert.ToDouble(textBoxPrice.Text);
            bLL.Manufacturer = textBoxManufacturer.Text;
            bLL.Description = textBoxDescription.Text;

            bool isSuccess = dAL.Update(bLL);

            if (isSuccess == true)
            {
                MessageBox.Show("Product Details Updated succesfully");
                Clear();
            }
            else
            {
                MessageBox.Show("Failed to Update products, please try agin!");
            }

            DataTable dataTable = dAL.Select();
            dataGridViewProductDetail.DataSource = dataTable;
            dataGridViewProductDetail.Columns[4].Width = 250;
        }

        private void ButtonDelete_Click(object sender, EventArgs e)
        {
            bLL.Id = textBoxProductID.Text;

            bool isSuccess = dAL.Delete(bLL);

            if (isSuccess == true)
            {
                MessageBox.Show("Product successfully deleted");
                Clear();
            }
            else
            {
                MessageBox.Show("Failed to delete! try again");
            }

            DataTable dataTable = dAL.Select();
            dataGridViewProductDetail.DataSource = dataTable;
        }

        private void DataGridViewProductDetail_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int index = e.RowIndex;

            textBoxProductID.Text = dataGridViewProductDetail.Rows[index].Cells[0].Value.ToString();
            textBoxProductName.Text = dataGridViewProductDetail.Rows[index].Cells[1].Value.ToString();
            textBoxPrice.Text = dataGridViewProductDetail.Rows[index].Cells[2].Value.ToString();
            textBoxManufacturer.Text = dataGridViewProductDetail.Rows[index].Cells[3].Value.ToString();
            textBoxDescription.Text = dataGridViewProductDetail.Rows[index].Cells[4].Value.ToString();
        }

        static readonly string myconnection = ConfigurationManager.ConnectionStrings["ConnectString"].ConnectionString;

        private void TextBoxSearch_TextChanged(object sender, EventArgs e)
        {
            string keyword = textBoxSearch.Text;
            string sql = "SELECT * FROM products WHERE ID LIKE '%" + keyword + "%' OR product_name LIKE '%" + keyword + "%' OR manufacturer LIKE '%" + keyword + "%' OR description LIKE '%" + keyword + "%'";
            MySqlConnection mySqlConnection = new MySqlConnection(myconnection);
            MySqlCommand mySqlCommand = new MySqlCommand(sql, mySqlConnection);
            MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(mySqlCommand);
            DataTable dataTable = new DataTable();
            mySqlConnection.Open();
            mySqlDataAdapter.Fill(dataTable);
            dataGridViewProductDetail.DataSource = dataTable;
            mySqlDataAdapter.Dispose();
        }

        private void Label2_Click(object sender, EventArgs e)
        {
            this.Close();
            FormLogIn formLogIn = new FormLogIn();
            formLogIn.Show();
        }
    }
}
