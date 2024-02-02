using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Web;

namespace TrojanTeamLaunch
{
    public class DBWorker
    {

        private SQLiteConnection connection;

        public DBWorker(string pathToDB) {
            connection = new SQLiteConnection("Data Source = " + pathToDB);
            connection.Open();


        }

        public bool DisconnetToMyDB() { 
            if (connection != null) {
                if (connection.State == System.Data.ConnectionState.Open) { connection.Dispose(); }
            }
            return true;
        }

        public bool regNewUser(string login, string pswrd) {
            // INSERT INTO MyDB ('login' , 'pswrd' , 'type_of_quest' , 'asnwr_of_quest') VALUES ('Me' , '1337' , '1' , 'BOOK')
            if (connection != null)
            {
                if (connection.State == System.Data.ConnectionState.Open) {
                    try
                    {
                        SQLiteCommand cmd = connection.CreateCommand();
                        cmd.CommandText = "INSERT INTO MyDB VALUES ('" + login + "' , '" + getHash(pswrd) + "' , 'type_of_quest' , 'answr_of_quest')";
                        cmd.ExecuteNonQuery();

                        
                        return true;
                    }
                    catch (Exception exp) { 
                        //MessageBox.Show(exp.Message); 
                        return false;
                    }
                }
                connection.Dispose();
            }
            return false;
        }

        public bool authUser(string login, string pswrd) {
            if (connection != null)
            {
                if (connection.State == System.Data.ConnectionState.Open)
                {
                    try
                    {
                        SQLiteCommand cmd = connection.CreateCommand();
                        cmd.CommandText = "SELECT * FROM MyDB WHERE login = '" + login + "' and pswrd = '" + getHash(pswrd) + "'";
                        object result = cmd.ExecuteScalar();
                        
                        if (result != null) {
                            return true;
                        } else { return false; }

                        
                    }
                    catch (Exception exp) { MessageBox.Show(exp.Message); }
                }
                connection.Dispose();
            }

            return false;
        }

        public string authTypeQuest(string type_of_quest) {
            return type_of_quest;
        }

        private string getHash(string text)
        {
            SHA256 sha256 = SHA256.Create();
            byte[] raw_text = Encoding.Unicode.GetBytes(text);
            byte[] raw_hash = sha256.ComputeHash(raw_text);
            string Hash = Encoding.Unicode.GetString(raw_hash);

            sha256.Clear();

            return Hash;
        }
    }
}
