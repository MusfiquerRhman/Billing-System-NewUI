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
    class CustomerDAL
    {
        static readonly string myconnection = ConfigurationManager.ConnectionStrings["ConnectString"].ConnectionString;

        #region Select all data from customer table

        public DataTable Select()
        {
            DataTable dataTable = new DataTable();
            MySqlConnection mySqlConnection = new MySqlConnection(myconnection);

            try
            {
                string sql = "SELECT * FROM customer";
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

        #region Insert data into customer table

        public bool Insert(CustomerBLL c)
        {
            bool isSuccess = false;
            MySqlConnection mySqlConnection = new MySqlConnection(myconnection);

            try
            {
                string sql = "INSERT INTO customer (contactno) VALUES (@contactno)";
                MySqlCommand mySqlCommand = new MySqlCommand(sql, mySqlConnection);
                mySqlConnection.Open();

                mySqlCommand.Parameters.AddWithValue("@contactno", c.Contactno);

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

        #region Update data of customer table (COMMENTED)
        /*
        public bool Update(CustomerBLL c)
        {
            bool isSuccess = false;
            MySqlConnection mySqlConnection = new MySqlConnection(myconnection);

            try
            {
                string sql = "UPDATE customer SET contactno = @contactno WHERE contactno = @contactno";
                MySqlCommand mySqlCommand = new MySqlCommand(sql, mySqlConnection);
                mySqlConnection.Open();

                mySqlCommand.Parameters.AddWithValue("@contactno", c.Contactno);

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
        */
        #endregion

        #region Delete data from customer table

        public bool Delete(CustomerBLL c)
        {
            bool isSuccess = false;
            MySqlConnection mySqlConnection = new MySqlConnection(myconnection);

            try
            {
                string sql = "DELETE FROM customer WHERE contactno = @contactno";
                MySqlCommand mySqlCommand = new MySqlCommand(sql, mySqlConnection);
                mySqlConnection.Open();

                mySqlCommand.Parameters.AddWithValue("@contactno", c.Contactno);

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

        #region Search a contact no in the customer table;

        public string Search(string contact_no)
        {
            string contactno;
            string sql = "SELECT contactno FROM customer WHERE contactno = @contactno";
            MySqlConnection mySqlConnection = new MySqlConnection(myconnection);
            MySqlCommand mySqlCommand = new MySqlCommand(sql, mySqlConnection);
            mySqlCommand.Parameters.AddWithValue("@contactno", contact_no);
            mySqlConnection.Open();
            mySqlCommand.ExecuteNonQuery();
            MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(mySqlCommand);
            DataTable dataTable = new DataTable();
            mySqlDataAdapter.Fill(dataTable);
            if (dataTable.Rows.Count > 0)
            {
                contactno = dataTable.Rows[0].ItemArray[0].ToString();
            }
            else
            {
                contactno = "";
            }
            mySqlDataAdapter.Dispose();
            return contactno;
        }

        #endregion

        #region join history and contact

        public DataTable JoinHistory()
        {
            DataTable dataTable = new DataTable();
            MySqlConnection mySqlConnection = new MySqlConnection(myconnection);

            try
            {
                string sql = "SELECT c.contactno as 'Customer Phone No', h.productName as 'Product Name', h.price as 'Product Price', h.quantity as Quantity, h.totalprice as 'Grand Total', h.date as 'Sold Date' FROM history as h RIGHT OUTER JOIN customer as c ON c.contactno = h.contactno";
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
    }
}
