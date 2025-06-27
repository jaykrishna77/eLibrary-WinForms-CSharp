using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library.Properties;
using MySql.Data.MySqlClient;
using MySqlDBOperations;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Library.UserLogin
{
    internal class clsUserLogin
    {
        /*
        private MySqlConnection _mySqlConnection = null;
        ((DbConnection)(object) _mySqlConnection).Open();



        public int ExecuteCRUDCommand(string command)
        {
            //IL_0033: Unknown result type (might be due to invalid IL or missing references)
            //IL_0039: Expected O, but got Unknown
            int num = -1;
            if (_mySqlConnection == null || ((DbConnection)(object)_mySqlConnection).State != ConnectionState.Open)
            {
                OpenConnection();
            }

            MySqlCommand val = new MySqlCommand(command, _mySqlConnection);
            return ((DbCommand)(object)val).ExecuteNonQuery();
        }
        
        UserLogin user = new UserLogin();

        internal void  QueryExceution(string query)
        {
            MySqlDBOperations.Helper mySQLHelper = new MySqlDBOperations.Helper("Server=localhost;Database=library;User ID=root;Password=admin;");
            
            try
            {
                 mySQLHelper.ExecuteCRUDCommand(query);
            }
            catch (Exception ex)
            {
                // Handle exceptions appropriately
                Console.WriteLine($"Error executing query: {ex.Message}");
                
            }
           
        }
        MySqlDBOperations.Helper mySQLHelper = new MySqlDBOperations.Helper("Server=localhost;Database=library;User ID=root;Password=admin;");
        
        */
        MySqlDBOperations.Helper mySQLHelper = new MySqlDBOperations.Helper("Server=localhost;Database=library;User ID=root;Password=admin;");
        public void InsertLoginQuery(string username,string password)
        {
            
            mySQLHelper.ExecuteCRUDCommand($@"INSERT INTO `library`.`userlogindetails` (`Email`,`Password`)   VALUES ('{username}','{password}')");
        }
        public bool loginValid(string Email, string Password)
        {

            string query = $@"SELECT Email FROM userlogindetails 
                      WHERE Email = '{Email}' AND Password = '{Password}'";

            DataTable result = mySQLHelper.ExecuteSelectQuery(query);

            return result.Rows.Count > 0;
        }
        public void InsertAuthorQuery(string author_name,int author_status)
        {

            mySQLHelper.ExecuteSelectQuery($@"INSERT INTO `library`.`authors`
                                (
                                `author_name`,
                                `author_status`)
                                VALUES
                                (
                                '{author_name}',
                                {author_status})");
        }
        public void UpdateAuthorQuery(int iId,string author_name, string author_status)
        {

            mySQLHelper.ExecuteCRUDCommand($@"UPDATE `universitydb`.`colleges` 
                                SET
                                `author_id` = '{iId}',
                                `author_name` ='{author_name}',
                                `author_status` = '{author_status}'
                                WHERE `author_id` = {iId}");
        }
        public void DeleteAuthorQuery(int AuthorId)
        {

            mySQLHelper.ExecuteCRUDCommand($@"DELETE FROM library
                                USING library
                                WHERE authors.author_id = {AuthorId}");
        }

        public DataTable GetAllAuthors()
        { 
            return mySQLHelper.ExecuteSelectQuery("SELECT * FROM `library`.`authors`");
        }
        public void InsertPublisherQuery(string publisher_name, string publisher_status)
        {

            mySQLHelper.ExecuteCRUDCommand($@"INSERT INTO `library`.`publisher`
                                (
                                `publisher_name`,
                                `publisher_status`)
                                VALUES
                                (
                                '{publisher_name}',
                                '{publisher_status}')");
        }
        public DataTable GetAllPublishers()
        {
            return mySQLHelper.ExecuteSelectQuery("SELECT * FROM `library`.`publisher`");
        }
        public void UpdatePublisherQuery(int iId, string publisher_name, string publisher_status)
        {

            mySQLHelper.ExecuteCRUDCommand($@"UPDATE `universitydb`.`colleges` 
                                SET
                                `author_id` = '{iId}',
                                `author_name` ='{publisher_name}',
                                `author_status` = '{publisher_status}'
                                WHERE `author_id` = {iId}");
        }

        public void DeletePublisherQuery(int PublisherId)
        {

            mySQLHelper.ExecuteCRUDCommand($@"DELETE FROM library
                                USING library
                                WHERE publisher.publisher_id = {PublisherId}");
        }



    }
}
