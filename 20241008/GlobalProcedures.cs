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

        public MySqlDataReader fncRegister(string firstname, string lastname, string username, string email, string password, string phone)
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
                MySqlDataReader reader = cmd.ExecuteReader();
                return reader;
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }

            return null;
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

        public bool fncUpdateUserById(int userId, string firstname, string lastname, string username, string email, string phone, string votersId)
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
                cmd.Parameters.AddWithValue("@p_voters_id", votersId);
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

        public MySqlDataReader fncCreateRoom(int userId)
        {
            try
            {
                string sql = "procCreateRoom";
                MySqlCommand cmd = new(sql, database);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@p_name", "New Room");
                cmd.Parameters.AddWithValue("@p_author", userId);
                Random random = new();
                string roomCode = random.Next(10000, 99999).ToString();
                cmd.Parameters.AddWithValue("@p_code", roomCode);
                MySqlDataReader reader = cmd.ExecuteReader();
                return reader;
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }

            return null;
        }

        public MySqlDataReader fncGetRoomsByUserId(int userId)
        {
            try
            {
                string sql = "procSelectRoomsByUserId";
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

        public MySqlDataReader fncGetRoomsByAuthor(int userId)
        {
            try
            {
                string sql = "procSelectRoomsByAuthor";
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

        public MySqlDataReader fncGetRoomById(int roomId)
        {
            try
            {
                string sql = "procSelectRoomById";
                MySqlCommand cmd = new(sql, database);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@p_room_id", roomId);
                MySqlDataReader reader = cmd.ExecuteReader();
                return reader;
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }

            return null;
        }

        public MySqlDataReader fncJoinRoomByCode(int userId, string roomCode)
        {
            try
            {
                string sql = "procJoinRoomByCode";
                MySqlCommand cmd = new(sql, database);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@p_user_id", userId);
                cmd.Parameters.AddWithValue("@p_code", roomCode);
                MySqlDataReader reader = cmd.ExecuteReader();
                return reader;
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }

            return null;
        }

        public bool fncLeaveRoom(int userId, int roomId)
        {
            try
            {
                string sql = "procLeaveRoom";
                MySqlCommand cmd = new(sql, database);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@p_user_id", userId);
                cmd.Parameters.AddWithValue("@p_room_id", roomId);
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

        public MySqlDataReader fncGetUsersByRoomId(int roomId)
        {
            try
            {
                string sql = "procSelectUsersByRoomId";
                MySqlCommand cmd = new(sql, database);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@p_room_id", roomId);
                MySqlDataReader reader = cmd.ExecuteReader();
                return reader;
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }

            return null;
        }

        public bool fncUpdateRoomById(int roomId, string name, string code)
        {
            try
            {
                string sql = "procUpdateRoomById";
                MySqlCommand cmd = new(sql, database);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@p_room_id", roomId);
                cmd.Parameters.AddWithValue("@p_name", name);
                cmd.Parameters.AddWithValue("@p_code", code);
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

        public MySqlDataReader fncGetRolesByRoomId(int roomId)
        {
            try
            {
                string sql = "procSelectRolesByRoomId";
                MySqlCommand cmd = new(sql, database);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@p_room_id", roomId);
                MySqlDataReader reader = cmd.ExecuteReader();
                return reader;
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }

            return null;
        }

        public MySqlDataReader fncGetPartylistsByRoomId(int roomId)
        {
            try
            {
                string sql = "procSelectPartylistsByRoomId";
                MySqlCommand cmd = new(sql, database);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@p_room_id", roomId);
                MySqlDataReader reader = cmd.ExecuteReader();
                return reader;
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }

            return null;
        }

        public MySqlDataReader fncGetModeratorsByRoomId(int roomId)
        {
            try
            {
                string sql = "procSelectModeratorsByRoomId";
                MySqlCommand cmd = new(sql, database);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@p_room_id", roomId);
                MySqlDataReader reader = cmd.ExecuteReader();
                return reader;
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }

            return null;
        }

        public bool fncSetModerator(int userId, int roomId, bool isModerator)
        {
            try
            {
                string sql = "procSetModerator";
                MySqlCommand cmd = new(sql, database);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@p_user_id", userId);
                cmd.Parameters.AddWithValue("@p_room_id", roomId);
                cmd.Parameters.AddWithValue("@p_is_moderator", isModerator);
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

        public bool fncDeleteRoleById(int roleId)
        {
            try
            {
                string sql = "procDeleteRoleById";
                MySqlCommand cmd = new(sql, database);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@p_role_id", roleId);
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

        public bool fncInsertRole(string title, int roomId)
        {
            try
            {
                string sql = "procInsertRole";
                MySqlCommand cmd = new(sql, database);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@p_title", title);
                cmd.Parameters.AddWithValue("@p_room_id", roomId);
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

        public bool fncDeletePartylistById(int partylistId)
        {
            try
            {
                string sql = "procDeletePartylistById";
                MySqlCommand cmd = new(sql, database);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@p_partylist_id", partylistId);
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

        public bool fncInsertPartylist(string name, int roomId)
        {
            try
            {
                string sql = "procInsertPartylist";
                MySqlCommand cmd = new(sql, database);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@p_name", name);
                cmd.Parameters.AddWithValue("@p_room_id", roomId);
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

        public MySqlDataReader fncGetUserCandidatesByRoomId(int roomId)
        {
            try
            {
                string sql = "procSelectUserCandidatesByRoomId";
                MySqlCommand cmd = new(sql, database);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@p_room_id", roomId);
                MySqlDataReader reader = cmd.ExecuteReader();
                return reader;
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }

            return null;
        }

        public bool fncDeleteCandidateById(int candidateId)
        {
            try
            {
                string sql = "procDeleteCandidateById";
                MySqlCommand cmd = new(sql, database);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@p_candidate_id", candidateId);
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

        public bool fncInsertCandidate(int userId, int roomId, int roleId, int partylistId)
        {
            try
            {
                string sql = "procInsertCandidate";
                MySqlCommand cmd = new(sql, database);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@p_user_id", userId);
                cmd.Parameters.AddWithValue("@p_room_id", roomId);
                cmd.Parameters.AddWithValue("@p_role_id", roleId);
                cmd.Parameters.AddWithValue("@p_partylist_id", partylistId);
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

        public MySqlDataReader fncGetCandidateById(int candidateId)
        {
            try
            {
                string sql = "procSelectCandidateById";
                MySqlCommand cmd = new(sql, database);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@p_candidate_id", candidateId);
                MySqlDataReader reader = cmd.ExecuteReader();
                return reader;
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }

            return null;
        }

        public bool fncUpdateCandidateById(int candidateId, int roleId, int partylistId)
        {
            try
            {
                string sql = "procUpdateCandidateById";
                MySqlCommand cmd = new(sql, database);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@p_candidate_id", candidateId);
                cmd.Parameters.AddWithValue("@p_role_id", roleId);
                cmd.Parameters.AddWithValue("@p_partylist_id", partylistId);
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

        public MySqlDataReader fncGetCandidatesByRoomIdRoleIdAndPartylistId(int roomId, int roleId, int partylistId)
        {
            try
            {
                string sql = "procSelectCandidatesByRoomIdRoleIdAndPartylistId";
                MySqlCommand cmd = new(sql, database);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@p_room_id", roomId);
                cmd.Parameters.AddWithValue("@p_role_id", roleId);
                cmd.Parameters.AddWithValue("@p_partylist_id", partylistId);
                MySqlDataReader reader = cmd.ExecuteReader();
                return reader;
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }

            return null;
        }

        public bool fncVote(int userId, int candidateId)
        {
            try
            {
                string sql = "procVote";
                MySqlCommand cmd = new(sql, database);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@p_user_id", userId);
                cmd.Parameters.AddWithValue("@p_candidate_id", candidateId);
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

        public MySqlDataReader fncGetUserVotes(int userId, int roomId)
        {
            try
            {
                string sql = "procSelectUserVotes";
                MySqlCommand cmd = new(sql, database);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@p_user_id", userId);
                cmd.Parameters.AddWithValue("@p_room_id", roomId);
                MySqlDataReader reader = cmd.ExecuteReader();
                return reader;
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }

            return null;
        }

        public bool fncFinalizeVote(int userId, int roomId)
        {
            try
            {
                string sql = "procFinalizeVote";
                MySqlCommand cmd = new(sql, database);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@p_user_id", userId);
                cmd.Parameters.AddWithValue("@p_room_id", roomId);
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

        public bool fncClearVotes(int userId, int roomId)
        {
            try
            {
                string sql = "procClearVotes";
                MySqlCommand cmd = new(sql, database);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@p_user_id", userId);
                cmd.Parameters.AddWithValue("@p_room_id", roomId);
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

        public MySqlDataReader fncPrintResults(int roomId)
        {
            try
            {
                string sql = "procPrintResults";
                MySqlCommand cmd = new(sql, database);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@p_room_id", roomId);
                MySqlDataReader reader = cmd.ExecuteReader();
                return reader;
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }

            return null;
        }

        public bool fncDeleteRoomById(int roomId)
        {
            try
            {
                string sql = "procDeleteRoomById";
                MySqlCommand cmd = new(sql, database);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@p_room_id", roomId);
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
