using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using Billing_System.BLL;
using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;

namespace Billing_System.DAL
{
    class LoginDAL
    {
        static readonly string myconnection = ConfigurationManager.ConnectionStrings["ConnectString"].ConnectionString;

        #region Select all data from user table where username matches the corresponding password, used for login
        public bool Login(LoginBLL l)
        {
            bool isSuccess = false;
            MySqlConnection connection = new MySqlConnection(myconnection);

            try
            {
                string sql = "SELECT * FROM users WHERE username = @username AND userPassword = @Password";
                DataTable dataTable = new DataTable();
                MySqlCommand mySqlCommand = new MySqlCommand(sql, connection);
                connection.Open();

                mySqlCommand.Parameters.AddWithValue("@username", l.Username);
                mySqlCommand.Parameters.AddWithValue("@Password", l.Password);

                MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(mySqlCommand);
                mySqlDataAdapter.Fill(dataTable);
                mySqlDataAdapter.Dispose();
                if (dataTable.Rows.Count > 0)
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

        #region Select logged in users ID from database by taking username as parameter (COMMENTED)
        /*
        public LoginBLL SelectID(string username)
        {
            LoginBLL loginBLL = new LoginBLL();
            MySqlConnection mySqlConnection = new MySqlConnection(myconnection);
            DataTable dataTable = new DataTable();

            try
            {
                string sql = "SELECT ID FROM users WHERE ID = '%" + username + "%'";
                MySqlCommand mySqlCommand = new MySqlCommand(sql, mySqlConnection);
                mySqlConnection.Open();
                MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(mySqlCommand);
                mySqlDataAdapter.Fill(dataTable);
                mySqlDataAdapter.Dispose();
                if (dataTable.Rows.Count > 0)
                {
                    loginBLL.Id = int.Parse(dataTable.Rows[0]["ID"].ToString());
                }
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                mySqlConnection.Close();
                dataTable.Dispose();
            }
            return loginBLL;
        } 
        */
        #endregion
    }
}
