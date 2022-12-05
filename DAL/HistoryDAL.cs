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
    class HistoryDAL
    {
        //    readonly LoginDAL loginDAL = new LoginDAL();

        static readonly string myconnection = ConfigurationManager.ConnectionStrings["ConnectString"].ConnectionString;

        #region Select all data from history table
        public DataTable Select()
        {
            DataTable dataTable = new DataTable();
            MySqlConnection mySqlConnection = new MySqlConnection(myconnection);

            try
            {
                string sql = "SELECT * FROM history";
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

        #region Insert data directly in history except Contact no and date

        public bool Insert(HistoryBLL b)
        {
            bool isSuccess = false;
            MySqlConnection mySqlConnection = new MySqlConnection(myconnection);

            try
            {
                string sql = "INSERT INTO history (productName, price, quantity, totalprice, soldby) VALUES (@productName, @price, @quantity, @totalprice, @soldby)";
                MySqlCommand mySqlCommand = new MySqlCommand(sql, mySqlConnection);
                MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(mySqlCommand);
                mySqlConnection.Open();

                mySqlCommand.Parameters.AddWithValue("@productName", b.ProductID);
                mySqlCommand.Parameters.AddWithValue("@price", b.Price);
                mySqlCommand.Parameters.AddWithValue("@quantity", b.Quantity);
                mySqlCommand.Parameters.AddWithValue("@totalprice", b.GrandTotal);
                mySqlCommand.Parameters.AddWithValue("@soldby", b.Userid);

                int success = mySqlCommand.ExecuteNonQuery();
                if (success > 0)
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

        #region Add date and contactno to history table

        public bool AddDateAndContactNo(string date, string contactno, int index)
        {
            bool success = false;

            MySqlConnection mySqlConnection = new MySqlConnection(myconnection);

            try
            {
                string sql = "UPDATE history SET date = @date, contactno = @contactno WHERE id = @index";
                MySqlCommand mySqlCommand = new MySqlCommand(sql, mySqlConnection);
                mySqlConnection.Open();

                mySqlCommand.Parameters.AddWithValue("@date", date);
                mySqlCommand.Parameters.AddWithValue("@contactno", contactno);
                mySqlCommand.Parameters.AddWithValue("@index", index);

                int row = mySqlCommand.ExecuteNonQuery();
                mySqlCommand.Dispose();
                if (row > 0)
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

        #region Select last id of history table 

        public int SelectID()
        {
            MySqlConnection mySqlConnection = new MySqlConnection(myconnection);
            int lastRow = -1;

            try
            {
                string sql = "SELECT id FROM history ORDER BY id DESC LIMIT 1";
                MySqlCommand mySqlCommand = new MySqlCommand(sql, mySqlConnection);
                MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(mySqlCommand);
                mySqlConnection.Open();
                DataTable dataTable = new DataTable();
                mySqlDataAdapter.Fill(dataTable);
                lastRow = Convert.ToInt32(dataTable.Rows[0].ItemArray[0].ToString());
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

            return lastRow;
        }

        #endregion

        #region Delete from history table
        public bool Delete(int sell_id)
        {
            bool isSuccess = false;
            MySqlConnection connection = new MySqlConnection(myconnection);

            try
            {
                string sql = "DELETE from history Where id = @sell_id";

                MySqlCommand mySqlCommand = new MySqlCommand(sql, connection);

                mySqlCommand.Parameters.AddWithValue("@sell_id", sell_id);

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

        #region Combine History and user

        public DataTable historyTable()
        {
            DataTable dataTable = new DataTable();
            MySqlConnection mySqlConnection = new MySqlConnection(myconnection);

            try
            {
                string sql = "SELECT h.productName as 'Product Name', h.price as 'Product Price', h.quantity as 'Quantity Sold', h.totalprice as 'Grand Total', h.contactno as 'Customer Phone No', h.date as 'Sold Date', u.username as 'Sold By' FROM history as h, users as u WHERE u.ID = h.soldby";
                MySqlCommand mySqlCommand = new MySqlCommand(sql, mySqlConnection);
                MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(mySqlCommand);
                mySqlDataAdapter.Fill(dataTable);
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

        #region Search history

        public DataTable Search(string keyword)
        {
            DataTable dataTable = new DataTable();
            MySqlConnection mySqlConnection = new MySqlConnection(myconnection);

            try
            {
                string sql = "SELECT h.productName as 'Product Name', h.price as 'Product Price', h.quantity as 'Quantity Sold', h.totalprice as 'Grand Total', h.contactno as 'Customer Phone No', h.date as 'Sold Date', u.username as 'Sold By' FROM history as h, users as u WHERE u.ID = h.soldby AND (h.productName LIKE '%" + keyword + "%' OR h.date LIKE '%" + keyword + "%' OR h.contactno LIKE '%" + keyword + "%' OR u.username LIKE '%" + keyword + "%')";
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

        #region pagination Combine History and user

        public DataTable PaginationhistoryTable(int lowerlimite, int uperlimite)
        {
            DataTable dataTable = new DataTable();
            MySqlConnection mySqlConnection = new MySqlConnection(myconnection);

            try
            {
                string sql = "SELECT h.productName as 'Product Name', h.price as 'Product Price', h.quantity as 'Quantity Sold', h.totalprice as 'Grand Total', h.contactno as 'Customer Phone No', h.date as 'Sold Date', u.username as 'Sold By' FROM history as h, users as u WHERE u.ID = h.soldby ORDER BY h.id DESC LIMIT " + lowerlimite + "," + uperlimite;
                MySqlCommand mySqlCommand = new MySqlCommand(sql, mySqlConnection);
                MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(mySqlCommand);
                mySqlDataAdapter.Fill(dataTable);
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
