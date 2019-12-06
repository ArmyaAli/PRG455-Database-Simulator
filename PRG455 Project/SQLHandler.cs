using System;
using System.Data;
using System.Data.OleDb;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace PRG455_Project
{
    /* Abstraction created to handle SQL commands with functionaility to Insert a record, Update a record, and Delete a record and Query our DB */

    /* 
       sql str formatting guide
       query1 += "INSERT INTO [School Table] (sName, sAddress, sPhone, cID (INT)) VALUES ('Seneca', 'Finch ', '6471291111', 3);"; 
       query2 += "INSERT INTO [Course Table] (cName, cCode, cFee (INT) , cLocation) VALUES ('Microcontrollers', 'MCO455', 500, Toronto);";
    */
    struct SQLHandler
    {
        private OleDbCommand command;
       
        // creates a command and sets our connection to the connection opened by main
        public SQLHandler(OleDbConnection connection)
        {
            command = new OleDbCommand();
            command.Connection = connection;
        }

        public string[] GetRecord(string tableName, int table_id)
        {
            string[] tokens = new string[4];
            string gQuery;
            if (tableName.Equals("School table"))
                gQuery = "SELECT * FROM [School Table] WHERE sID=" + table_id.ToString() + ";";
            else 
                gQuery = "SELECT * FROM [Course Table] WHERE cID=" + table_id.ToString() + ";";

            command.CommandText = gQuery;
            OleDbDataReader reader = command.ExecuteReader();
            try
            {
                if (tableName.Equals("School table"))
                {
                    while (reader.Read())
                    {
                        // if null just print nothing
                        tokens[0] = reader.IsDBNull(1) ? "" : reader.GetString(1);
                        tokens[1] = reader.IsDBNull(2) ? "" : reader.GetString(2);
                        tokens[2] = reader.IsDBNull(3) ? "" : reader.GetString(3);
                        tokens[3] = reader.IsDBNull(4) ? "" : reader.GetInt32(4).ToString();
                    }
                }
                else if (tableName.Equals("Course table"))
                {
                    while (reader.Read())
                    {
                        // if null just print nothing
                        tokens[0] = reader.IsDBNull(1) ? "" : reader.GetString(1);
                        tokens[1] = reader.IsDBNull(2) ? "" : reader.GetString(2);
                        tokens[2] = reader.IsDBNull(3) ? "" : reader.GetDecimal(3).ToString();
                        tokens[3] = reader.IsDBNull(4) ? "" : reader.GetString(4);
                    }
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
            reader.Close();
            return tokens;
        }
        public void InsertRecord(string tableName, string[] values)
        {
            string iQuery = "";

            if (tableName.Equals("School table"))
                iQuery += "INSERT INTO [School table] (sName, sAddress, sPhone, cID) VALUES ('";
            if (tableName.Equals("Course table"))
                iQuery += "INSERT INTO [Course table] (cName, cCode, cFee , cLocation) VALUES ('";

            iQuery += values[0] 
                + "','" + values[1] 
                + "','"+ values[2] 
                + "','" + values[3] 
                + "');";

            command.CommandText = iQuery;

            try
            {
                command.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        

        public void UpdateRecord(string tableName, int recordID, string[] tokens)
        {
            string uQuery;
            if (tableName.Equals("School table"))
                uQuery = "UPDATE [School Table] SET sName= " 
                    + tokens[0] + ", sAddress= " 
                    + tokens[1] + ", sPhone= " 
                    + tokens[2] + ", cID= " 
                    + tokens[3] +"WHERE sID=" + recordID.ToString() + ";";
            else
                uQuery = "UPDATE [Course Table] SET cName= "
                    + tokens[0] + ", cCode= "
                    + tokens[1] + ", cFee= "
                    + tokens[2] + ", cLocation= "
                    + tokens[3] + "WHERE cID=" + recordID.ToString() + ";";

            command.CommandText = uQuery;

            try
            {
                command.ExecuteNonQuery();
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        public void DeleteRecord(string tableName, int tableID)
        {
            string dQuery = "";
            if (tableName.Equals("School table"))
                dQuery += "DELETE FROM [School table] WHERE sID=" + tableID.ToString() + ";";
            if (tableName.Equals("Course table"))
                dQuery += "DELETE FROM [Course table] WHERE cID=" + tableID.ToString() + ";";
            command.CommandText = dQuery;

            try
            {
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
