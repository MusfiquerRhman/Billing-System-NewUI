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
    class ProductsDAL
    {
        static readonly string myconnection = ConfigurationManager.ConnectionStrings["ConnectString"].ConnectionString;

        #region Select all data from products table

        public DataTable Select()
        {
            DataTable dataTable = new DataTable();
            MySqlConnection mySqlConnection = new MySqlConnection(myconnection);

            try
            {
                string sql = "SELECT * FROM products";
                MySqlCommand mySqlCommand = new MySqlCommand(sql, mySqlConnection);
                MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(mySqlCommand);
                mySqlConnection.Open();
                mySqlDataAdapter.Fill(dataTable);
                mySqlDataAdapter.Dispose();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                mySqlConnection.Close();
            }

            return dataTable;
        }

        #endregion

        #region Insert data into products table

        public bool Insert(ProductsBLL c)
        {
            bool isSuccess = false;
            MySqlConnection mySqlConnection = new MySqlConnection(myconnection);

            try
            {
                string sql = "INSERT INTO products (id, product_name, price, manufacturer, description) VALUES (@Id, @product_name, @price, @manufacturer, @description)";
                MySqlCommand mySqlCommand = new MySqlCommand(sql, mySqlConnection);
                mySqlConnection.Open();

                mySqlCommand.Parameters.AddWithValue("@Id", c.Id);
                mySqlCommand.Parameters.AddWithValue("@product_name", c.ProductName);
                mySqlCommand.Parameters.AddWithValue("@price", c.Price);
                mySqlCommand.Parameters.AddWithValue("@manufacturer", c.Manufacturer);
                mySqlCommand.Parameters.AddWithValue("@description", c.Description);

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
                mySqlConnection.Close();
            }


            return isSuccess;
        }

        #endregion

        #region Update data of products table

        public bool Update(ProductsBLL c)
        {
            bool isSuccess = false;
            MySqlConnection mySqlConnection = new MySqlConnection(myconnection);

            try
            {
                string sql = "UPDATE products SET  product_name = @product_name, price = @price, manufacturer = @manufacturer, description = @description WHERE ID = @Id";
                MySqlCommand mySqlCommand = new MySqlCommand(sql, mySqlConnection);
                mySqlConnection.Open();

                mySqlCommand.Parameters.AddWithValue("@product_name", c.ProductName);
                mySqlCommand.Parameters.AddWithValue("@price", c.Price);
                mySqlCommand.Parameters.AddWithValue("@manufacturer", c.Manufacturer);
                mySqlCommand.Parameters.AddWithValue("@description", c.Description);
                mySqlCommand.Parameters.AddWithValue("@Id", c.Id);

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
                mySqlConnection.Close();
            }


            return isSuccess;
        }

        #endregion

        #region Delete data from products table

        public bool Delete(ProductsBLL c)
        {
            bool isSuccess = false;
            MySqlConnection mySqlConnection = new MySqlConnection(myconnection);

            try
            {
                string sql = "DELETE FROM products WHERE ID = @Id";
                MySqlCommand mySqlCommand = new MySqlCommand(sql, mySqlConnection);
                mySqlConnection.Open();

                mySqlCommand.Parameters.AddWithValue("@Id", c.Id);

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
                mySqlConnection.Close();
            }


            return isSuccess;
        }

        #endregion

    }
}