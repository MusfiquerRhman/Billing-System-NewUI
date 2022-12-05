using Billing_System.BLL;
using Billing_System.DAL;
using DGVPrinterHelper;
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
    public partial class SellProduct : Form
    {
        public SellProduct()
        {
            InitializeComponent();
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

        static readonly string myconnection = ConfigurationManager.ConnectionStrings["ConnectString"].ConnectionString;

        readonly ProductsDAL dAL = new ProductsDAL();
        readonly SellDal sellDal = new SellDal();
        readonly HistoryDAL historyDal = new HistoryDAL();
        readonly HistoryBLL historyBLL = new HistoryBLL();
        readonly SellBLL sellBLL = new SellBLL();
        readonly CustomerDAL customer = new CustomerDAL();
        readonly CustomerBLL customerBLL = new CustomerBLL();

        double totalPrice = 0;
        double price = 0;
        int discount = 0;
        int quantity = 1;

        int deleteId;

        private void Clear()
        {
            textBoxProductID.Text = "";
            textBoxProductName.Text = "";
            textBoxPrice.Text = "";
            textBoxQuantity.Text = "";
            textBoxDiscount.Text = "";
        }

        private void ButtonAddToList_Click(object sender, EventArgs e)
        {
            if (textBoxProductID.Text == "")
            {
                MessageBox.Show("Please select a product ID");
                return;
            }
            else
            {
                if (textBoxPrice.Text == "")
                {
                    MessageBox.Show("Enter the price");
                    return;
                }
                else
                {
                    price = Convert.ToDouble(textBoxPrice.Text);
                }

                if (textBoxQuantity.Text == "")
                {
                    MessageBox.Show("Enter Quantity");
                    return;
                }
                else
                {
                    quantity = Convert.ToInt32(textBoxQuantity.Text);
                }

                if (textBoxDiscount.Text == "")
                {
                    discount = 0;
                }
                else
                {
                    discount = Convert.ToInt32(textBoxDiscount.Text);
                }

                double pprice = quantity * price;
                totalPrice = totalPrice + (quantity * price) - (quantity * price) * discount / 100;

                textBoxGrandTotal.Text = totalPrice.ToString();

                sellBLL.ProductID = textBoxProductID.Text;
                sellBLL.Name = textBoxProductName.Text;
                sellBLL.Price = price;
                sellBLL.Quantity = quantity;
                sellBLL.Discount = discount;
                sellBLL.GrandTotal = pprice;

                historyBLL.ProductID = textBoxProductID.Text;
                historyBLL.Name = textBoxProductName.Text;
                historyBLL.Price = price;
                historyBLL.Quantity = quantity;
                historyBLL.Discount = discount;
                historyBLL.GrandTotal = pprice;
                historyBLL.Userid = FormLogIn.loggedInID;

                sellDal.Insert(sellBLL);
                historyDal.Insert(historyBLL);

                DataTable sellTable = sellDal.Select();
                dataGridViewProductList.DataSource = sellTable;

                Clear();
            }
        }

        private void ButtonDelete_Click(object sender, EventArgs e)
        {
            bool success = sellDal.Delete(deleteId);
            bool historyDelete = historyDal.Delete(deleteId);

            if (success == true)
            {
                MessageBox.Show("Entry Deleted!");
                double sub = Convert.ToDouble(textBoxPrice.Text);
                totalPrice -= sub * quantity;
                textBoxGrandTotal.Text = totalPrice.ToString();
            }
            else
            {
                MessageBox.Show("Faild to delete!");
            }

            if (historyDelete == true)
            {
                MessageBox.Show("Faild to delete from history!");
            }

            DataTable sellTable = sellDal.Select();
            dataGridViewProductList.DataSource = sellTable;

            Clear();
        }

        private void ButtonSelectCustomer_Click(object sender, EventArgs e)
        {
            DataTable listed = sellDal.Select();
            int rows = listed.Rows.Count;
            double givenAmount = Convert.ToDouble(textBoxGivenAmount.Text);
            double returnAmount = givenAmount - totalPrice;

            textBoxReturn.Text = returnAmount.ToString();

            if (rows <= 0)
            {
                MessageBox.Show("Add a product first!");
            }
            else
            {
                customerBLL.Contactno = textBoxPhoneNo.Text;

                if (customerBLL.Contactno == "")
                {
                    customerBLL.Contactno = "Not specified";
                }
                else
                {
                    string exist = customer.Search(textBoxPhoneNo.Text);
                    if (exist != customerBLL.Contactno)
                    {
                        customer.Insert(customerBLL);
                    }
                }

                string date = DateTime.Now.ToString("dddd, dd/MM/yyyy hh:mm tt");
                int lastId = historyDal.SelectID();

                for (int index = lastId; rows > 0; index--, rows--)
                {
                    bool added = historyDal.AddDateAndContactNo(date, customerBLL.Contactno, index);
                    if (added == false)
                    {
                        MessageBox.Show("Failed to update at index " + index + "!");
                    }
                }

                buttonPrint.Enabled = true;
                buttonDelete.Enabled = false;
                buttonAddToList.Enabled = false;
            }

            listed.Dispose();
        }

        private void ButtonPrint_Click(object sender, EventArgs e)
        {
            DGVPrinter printer = new DGVPrinter();
            printer.Title = "\r\n Shoping market";
            printer.SubTitle = "Mirpur - 2, Phone no: 0123456789";
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            printer.PageNumbers = true;
            printer.PorportionalColumns = true;
            printer.PageNumberInHeader = false;
            printer.HeaderCellAlignment = StringAlignment.Near;
            printer.Footer = "Discount: " + discount.ToString() + "% \r\n Grand Total: " + totalPrice.ToString() + "\r\n Thanks you";
            printer.FooterSpacing = 15;
            printer.PrintDataGridView(dataGridViewProductList);

            bool truncated = sellDal.Truncate();

            if (!truncated)
            {
                MessageBox.Show("Failed to delete listed items!");
            }
        }

        private void DataGridViewProductAndCustomer_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int index = e.RowIndex;
            textBoxProductID.Text = dataGridViewProductAndCustomer.Rows[index].Cells[0].Value.ToString();
            textBoxProductName.Text = dataGridViewProductAndCustomer.Rows[index].Cells[1].Value.ToString();
            textBoxPrice.Text = dataGridViewProductAndCustomer.Rows[index].Cells[2].Value.ToString();
        }

        private void DataGridViewProductList_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int index = e.RowIndex;
            deleteId = Convert.ToInt32(dataGridViewProductList.Rows[index].Cells[0].Value.ToString());
            textBoxProductID.Text = dataGridViewProductList.Rows[index].Cells[1].Value.ToString();
            textBoxPrice.Text = dataGridViewProductList.Rows[index].Cells[2].Value.ToString();
            textBoxProductName.Text = dataGridViewProductList.Rows[index].Cells[3].Value.ToString();
            textBoxQuantity.Text = dataGridViewProductList.Rows[index].Cells[4].Value.ToString();
            textBoxDiscount.Text = dataGridViewProductList.Rows[index].Cells[5].Value.ToString();
        }

        private void TextBoxSearch_TextChanged(object sender, EventArgs e)
        {
            string keyword = textBoxSearch.Text;
            string sql = "SELECT * FROM products WHERE ID LIKE '%" + keyword + "%'";
            MySqlConnection mySqlConnection = new MySqlConnection(myconnection);
            MySqlCommand mySqlCommand = new MySqlCommand(sql, mySqlConnection);
            MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(mySqlCommand);
            DataTable dataTable = new DataTable();
            mySqlConnection.Open();
            mySqlDataAdapter.Fill(dataTable);
            dataGridViewProductAndCustomer.DataSource = dataTable;
            mySqlDataAdapter.Dispose();
        }

        private void SellProduct_Load(object sender, EventArgs e)
        {
            labelLoggedin.Text = FormLogIn.loggedIn;

            DataTable dataTable = dAL.Select();
            dataGridViewProductAndCustomer.DataSource = dataTable;
            buttonPrint.Enabled = false;
        }

        private void Label1_Click(object sender, EventArgs e)
        {
            this.Close();
            FormLogIn formLogIn = new FormLogIn();
            formLogIn.Show();
        }
    }
}
