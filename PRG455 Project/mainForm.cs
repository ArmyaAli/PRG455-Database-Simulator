using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/***
 *  NAME: ALI UMAR
 *  DATE: 19/11/2019
 *  Description: Database simulator with functionality to connect to an access DB, query it,
 *  add records, update records and delete records.
 *  
 *  Design Notes: There is only one instance of OLEDB connection throughout the program.
 *  A reference to OLEDB connection is passed to each form & our SQL Handler from the main form (this)
 *  
 *  A struct SQLHandler was created to make life easier with getting a specific record, insertion, update, and deletion
 *  SQLHandler requires a reference to an OLEDB connection;
 *  
 *  
 * */
namespace PRG455_Project
{
    public partial class main_Form : Form
    {
        private OleDbConnection connection; 
        private OleDbDataAdapter dataAdapter;
        private DataTable virtualTable;
        private string sqlStr;
        public static bool connectionFlag = false; // no connection initially
        public static string connstr = "Provider=Microsoft.ACE.OLEDB.12.0;" // GLOBAL
                                      + "Data Source=records.accdb";
        
        public main_Form()
        {
            InitializeComponent();
        }

        // EXIT BUTTON PRESSED
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //CONNECT TO DB
        private void connectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            connection = new OleDbConnection(connstr);
            try
            {
                if(!connectionFlag)
                {
                    connection.Open();
                    MessageBox.Show("Connection Successful! \nServerVersion: " + connection.ServerVersion
                        + "\nDataSource: " + connection.DataSource);
                    connectionFlag = true;
                }
                else
                {
                    MessageBox.Show("An open connection already exists!");
                }
            }
            catch (Exception ex)
            {
                connectionFlag = false;
                MessageBox.Show(ex.Message);
            }
        }
        //DISCONNECT FROM DB
        private void disconnectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Close();
                MessageBox.Show("Connection successfuly closed!");
                connectionFlag = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cannot close a non existant connection!");
            }
        }
        // runs a query on our tables
        private void runQueryF5ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(connectionFlag)
            {
                sqlStr = qBox_textBox.Text;
                virtualTable = new DataTable();
                try
                {
                    dataAdapter = new OleDbDataAdapter(sqlStr, connstr);
                    dataAdapter.Fill(virtualTable);
                    dataGridView.DataSource = virtualTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                dataAdapter.Dispose();
            }
            else
            {
                MessageBox.Show("Open a connection before performing actions on the Database.");
            }
        }
        // insert a record into DB
        private void insertRecordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(connectionFlag)
            {
                // create a new form
                insertForm iForm = new insertForm(connection);
                iForm.Show();
            }
            else
            {
                MessageBox.Show("Open a connection before performing actions on the Database.");
            }

        }
        // update a record into the DB
        private void updateRecordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (connectionFlag)
            {
                // create a new form
                updateForm uForm = new updateForm(connection);
                uForm.Show();
            }
            else
            {
                MessageBox.Show("Open a connection before performing actions on the Database.");
            }

            
        }
        // delete a record from the DB
        private void deleteRecordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (connectionFlag)
            {
                // create a new form
                deleteForm dForm = new deleteForm(connection);
                dForm.Show();
            }
            else
            {
                MessageBox.Show("Open a connection before performing actions on the Database.");
            }

        }
        // handle key presses
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            bool Handled = false;
            switch (keyData)
            {
                case Keys.F5:
                    runQueryF5ToolStripMenuItem.PerformClick();
                    Handled = true;
                    break;
                case Keys.F6:
                    insertRecordToolStripMenuItem.PerformClick();
                    Handled = true;
                    break;
                case Keys.F7:
                    updateRecordToolStripMenuItem.PerformClick();
                    Handled = true;
                    break;
                case Keys.F8:
                    deleteRecordToolStripMenuItem.PerformClick();
                    Handled = true;
                    break;
                default:
                    Handled = base.ProcessCmdKey(ref msg, keyData);
                    break;

            }
            return Handled;
        }
    }

}
