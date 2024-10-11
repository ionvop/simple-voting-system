#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace _20241008
{
    public class GlobalProcedures
    {
        public string servername = "localhost";
        public string databasename = "voting_system";
        public string username = "root";
        public string password = "";
        public string port = "3306";
        public MySqlConnection database = new();

        public bool fncDatabaseConnection()
        {
            try
            {
                string connection = "Server=" + servername + ";" +
                    "Database=" + databasename + ";" +
                    "User=" + username + ";" +
                    "Password=" + password + ";" +
                    "Port=" + port + ";" +
                    "Convert Zero Datetime=True";

                database = new MySqlConnection(connection);
                database.Open();
                return true;
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }

            return false;
        }

        public bool fncRegister(string firstname, string lastname, string username, string email, string password, string phone)
        {
            try
            {
                string sql = "procRegister";
                MySqlCommand cmd = new(sql, database);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@p_firstname", firstname);
                cmd.Parameters.AddWithValue("@p_lastname", lastname);
                cmd.Parameters.AddWithValue("@p_username", username);
                cmd.Parameters.AddWithValue("@p_email", email);
                cmd.Parameters.AddWithValue("@p_password", password);
                cmd.Parameters.AddWithValue("@p_phone", phone);
                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    return true;
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }

            return false;
        }

        public MySqlDataReader fncLogin(string username, string password)
        {
            try
            {
                string sql = "procLogin";
                MySqlCommand cmd = new(sql, database);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@p_username", username);
                cmd.Parameters.AddWithValue("@p_password", password);
                MySqlDataReader reader = cmd.ExecuteReader();
                return reader;
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }

            return null;
        }

        public MySqlDataReader fncGetUserById(int userId)
        {
            try
            {
                string sql = "procSelectUserById";
                MySqlCommand cmd = new(sql, database);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@p_user_id", userId);
                MySqlDataReader reader = cmd.ExecuteReader();
                return reader;
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }

            return null;
        }

        public bool fncUpdateUserById(int userId, string firstname, string lastname, string username, string email, string phone)
        {
            try
            {
                string sql = "procUpdateUserById";
                MySqlCommand cmd = new(sql, database);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@p_user_id", userId);
                cmd.Parameters.AddWithValue("@p_firstname", firstname);
                cmd.Parameters.AddWithValue("@p_lastname", lastname);
                cmd.Parameters.AddWithValue("@p_username", username);
                cmd.Parameters.AddWithValue("@p_email", email);
                cmd.Parameters.AddWithValue("@p_phone", phone);
                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    return true;
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }

            return false;
        }

        public bool fncUpdateUserPasswordById(int userId, string password)
        {
            try
            {
                string sql = "procUpdateUserPasswordById";
                MySqlCommand cmd = new(sql, database);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@p_user_id", userId);
                cmd.Parameters.AddWithValue("@p_password", password);
                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    return true;
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }

            return false;
        }
    }
}
