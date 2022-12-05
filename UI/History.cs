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
    public partial class SellsHistory : Form
    {
        public SellsHistory()
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

        private void ButtonCustomers_Click(object sender, EventArgs e)
        {
            FormCustomerDetails formCustomerDetails = new FormCustomerDetails();
            formCustomerDetails.Show();
            this.Hide();
        }

        private void ButtonProducts_Click(object sender, EventArgs e)
        {
            ProductDetails productDetails = new ProductDetails();
            productDetails.Show();
            this.Hide();
        }

        int low = 0, up = 20;
        readonly HistoryDAL historyDAL = new HistoryDAL();

        private void SellsHistory_Load_1(object sender, EventArgs e)
        {
            DataTable dataTable = historyDAL.PaginationhistoryTable(low, up);

            dataGridViewHistory.DataSource = dataTable;
            dataGridViewHistory.Columns[5].Width = 200;
        }

        private void TextBoxSearch_TextChanged(object sender, EventArgs e)
        {
            string keyword = textBoxSearch.Text;

            if (keyword == "")
            {
                DataTable allDataTable = historyDAL.historyTable();

                dataGridViewHistory.DataSource = allDataTable;
                dataGridViewHistory.Columns[5].Width = 200;
            }
            else
            {
                DataTable dataTable = historyDAL.Search(keyword);

                dataGridViewHistory.DataSource = dataTable;
                dataGridViewHistory.Columns[5].Width = 200;
            }
        }

        private void Label2_Click(object sender, EventArgs e)
        {
            this.Close();
            FormLogIn formLogIn = new FormLogIn();
            formLogIn.Show();
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            if (low > 0)
            {
                low -= 20;
                up -= 20;
            }
            DataTable dataTable = historyDAL.PaginationhistoryTable(low, up);
            dataGridViewHistory.DataSource = dataTable;
        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {
            if (dataGridViewHistory.Rows.Count > 0)
            {
                low += 20;
                up += 20;
            }
            DataTable dataTable = historyDAL.PaginationhistoryTable(low, up);
            dataGridViewHistory.DataSource = dataTable;
        }
    }
}
