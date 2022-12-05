using Billing_System.BLL;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Billing_System.DAL
{
    class SellDal
    {
        static readonly string myconnection = ConfigurationManager.ConnectionStrings["ConnectString"].ConnectionString;

        #region Select all data from listed_products table
        public DataTable Select()
        {
            DataTable dataTable = new DataTable();
            MySqlConnection connection = new MySqlConnection(myconnection);

            try
            {
                string sql = "SELECT l.serial_no, p.product_name, l.price, l.quantity, l.discount, l.total_price FROM listed_products as l, products as p where l.product_id = p.ID;";
                MySqlCommand mySqlCommand = new MySqlCommand(sql, connection);
                MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(mySqlCommand);
                connection.Open();
                mySqlDataAdapter.Fill(dataTable);
                mySqlDataAdapter.Dispose();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                connection.Close();
            }

            return dataTable;
        }
        #endregion

        #region Inserts data into listed_products table
        public bool Insert(SellBLL b)
        {
            bool isSuccess = false;
            MySqlConnection connection = new MySqlConnection(myconnection);

            try
            {
                string sql = "INSERT INTO listed_products (product_id, price, quantity, discount, total_price) VALUES (@product_id, @price,  @quantity, @discount, @total_price) ";

                MySqlCommand mySqlCommand = new MySqlCommand(sql, connection);

                mySqlCommand.Parameters.AddWithValue("@product_id", b.ProductID);
                mySqlCommand.Parameters.AddWithValue("@price", b.Price);
                mySqlCommand.Parameters.AddWithValue("@quantity", b.Quantity);
                mySqlCommand.Parameters.AddWithValue("@discount", b.Discount);
                mySqlCommand.Parameters.AddWithValue("@total_price", b.GrandTotal);

                connection.Open();

                int rows = mySqlCommand.ExecuteNonQuery();
                mySqlCommand.Dispose();
                if (rows > 0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                connection.Close();
            }

            return isSuccess;
        }
        #endregion

        #region Search from customer table using contactno
        public DataTable Search(string keyword)
        {
            MySqlConnection connection = new MySqlConnection(myconnection);
            DataTable dataTable = new DataTable();

            try
            {
                string sql = "SELECT * From customer WHERE contactno = '%" + keyword + "%'";
                MySqlCommand mySqlCommand = new MySqlCommand(sql, connection);
                MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(mySqlCommand);
                connection.Open();
                mySqlDataAdapter.Fill(dataTable);
                mySqlDataAdapter.Dispose();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                connection.Close();
            }
            return dataTable;
        }
        #endregion

        #region Delete from listed_products table

        public bool Delete(int id)
        {
            bool isSuccess = false;
            MySqlConnection connection = new MySqlConnection(myconnection);

            try
            {
                string sql = "DELETE from listed_products Where serial_no = @id";

                MySqlCommand mySqlCommand = new MySqlCommand(sql, connection);

                mySqlCommand.Parameters.AddWithValue("@id", id);

                connection.Open();

                int rows = mySqlCommand.ExecuteNonQuery();
                mySqlCommand.Dispose();

                if (rows > 0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                connection.Close();
            }

            return isSuccess;
        }
        #endregion

        #region TRUNCATE listed product

        public bool Truncate()
        {
            bool success = false;
            MySqlConnection mySqlConnection = new MySqlConnection(myconnection);

            try
            {
                string sql = "TRUNCATE TABLE listed_products";
                MySqlCommand mySqlCommand = new MySqlCommand(sql, mySqlConnection);
                mySqlConnection.Open();
                int executed = mySqlCommand.ExecuteNonQuery();
                mySqlCommand.Dispose();

                if (executed == 0)
                {
                    success = true;
                }
                else
                {
                    success = false;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                mySqlConnection.Close();
            }

            return success;
        }

        #endregion
    }
}
