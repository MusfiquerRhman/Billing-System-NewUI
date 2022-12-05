using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using Billing_System.BLL;

namespace Billing_System.DAL
{
    class CreateAccountClasses
    {
        static readonly string myconnection = ConfigurationManager.ConnectionStrings["ConnectString"].ConnectionString;

        #region Select all data from users table

        public DataTable Select()
        {
            DataTable dataTable = new DataTable();
            MySqlConnection mySqlConnection = new MySqlConnection(myconnection);

            try
            {
                string sql = "SELECT * FROM users";
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

        #region Insert data into user table

        public bool Insert(CreateAccountBLL c)
        {
            bool isSuccess = false;
            MySqlConnection mySqlConnection = new MySqlConnection(myconnection);

            try
            {
                string sql = "INSERT INTO users (username, userPassword, ContactNo, address, eamil, gender) VALUES (@username, @userPassword, @ContactNo, @address, @eamil, @gender)";
                MySqlCommand mySqlCommand = new MySqlCommand(sql, mySqlConnection);
                mySqlConnection.Open();

                mySqlCommand.Parameters.AddWithValue("@username", c.Username);
                mySqlCommand.Parameters.AddWithValue("@userPassword", c.Password);
                mySqlCommand.Parameters.AddWithValue("@ContactNo", c.ContactNo);
                mySqlCommand.Parameters.AddWithValue("@address", c.Address);
                mySqlCommand.Parameters.AddWithValue("@eamil", c.Email);
                mySqlCommand.Parameters.AddWithValue("@gender", c.Gender);

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

        #region Update data of user table

        public bool Update(CreateAccountBLL c)
        {
            bool isSuccess = false;
            MySqlConnection mySqlConnection = new MySqlConnection(myconnection);

            try
            {
                string sql = "UPDATE users SET  username = @username, userPassword = @userPassword, ContactNo = @ContactNo, address = @address, eamil = @eamil, gender = @gender WHERE ID = @Id";
                MySqlCommand mySqlCommand = new MySqlCommand(sql, mySqlConnection);
                mySqlConnection.Open();

                mySqlCommand.Parameters.AddWithValue("@username", c.Username);
                mySqlCommand.Parameters.AddWithValue("@userPassword", c.Password);
                mySqlCommand.Parameters.AddWithValue("@ContactNo", c.ContactNo);
                mySqlCommand.Parameters.AddWithValue("@address", c.Address);
                mySqlCommand.Parameters.AddWithValue("@eamil", c.Email);
                mySqlCommand.Parameters.AddWithValue("@gender", c.Gender);
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

        #region Delete data from user table

        public bool Delete(CreateAccountBLL c)
        {
            bool isSuccess = false;
            MySqlConnection mySqlConnection = new MySqlConnection(myconnection);

            try
            {
                string sql = "DELETE FROM users WHERE ID = @Id";
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

        #region Select user Id

        public int SelectId(string name, string pass)
        {
            MySqlConnection mySqlConnection = new MySqlConnection(myconnection);
            DataTable dataTable = new DataTable();
            int selectedId = -1;

            try
            {
                string sql = "SELECT ID FROM users WHERE username = @name AND userPassword = @pass";
                MySqlCommand mySqlCommand = new MySqlCommand(sql, mySqlConnection);
                mySqlConnection.Open();
                MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(mySqlCommand);

                mySqlCommand.Parameters.AddWithValue("@name", name);
                mySqlCommand.Parameters.AddWithValue("@pass", pass);

                mySqlDataAdapter.Fill(dataTable);
                int rows = mySqlCommand.ExecuteNonQuery();

                selectedId = Convert.ToInt32(dataTable.Rows[0].ItemArray[0].ToString());

                mySqlCommand.Dispose();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                mySqlConnection.Close();
            }

            return selectedId;
        }

        #endregion

    }
}
