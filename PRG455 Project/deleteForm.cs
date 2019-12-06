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

namespace PRG455_Project
{
    public partial class deleteForm : Form
    {
        private SQLHandler handler;
        public deleteForm(OleDbConnection connection)
        {
            InitializeComponent();
            handler = new SQLHandler(connection);
        }

        private void course_radioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (school_radioButton.Checked)
            {
                first_label.Text = "School ID";
                second_label.Text = "School Name";
                third_label.Text = "School Address";
                fourth_label.Text = "School Phone";
                fifth_label.Text = "Course ID";
            }
            else if (course_radioButton.Checked)
            {
                first_label.Text = "Course ID";
                second_label.Text = "Course Name";
                third_label.Text = "Course Code";
                fourth_label.Text = "Course Fee";
                fifth_label.Text = "Course Location";
            }
        }

        private void refresh_button_Click(object sender, EventArgs e)
        {
            //check if number
            int tableID;
            bool validInput = Int32.TryParse(first_textBox.Text, out tableID);
            string tableName = school_radioButton.Checked ? "School table" : "Course table";
            string[] tokens;

            if (validInput)
            {
                // need to query
                tokens = handler.GetRecord(tableName, tableID);
                // print to textboxes
                if (tokens.Length == 0)
                    MessageBox.Show("That ID does not exist! Please try again");
                else
                {
                    second_textBox.Text = tokens[0];
                    third_textBox.Text = tokens[1];
                    fourth_textBox.Text = tokens[2];
                    fifth_textBox.Text = tokens[3];
                }

            }
            else
            {
                MessageBox.Show("Please enter an Integer!");
            }
        }

        private void clear_button_Click(object sender, EventArgs e)
        {
            first_textBox.Clear();
            second_textBox.Clear();
            third_textBox.Clear();
            fourth_textBox.Clear();
            fifth_textBox.Clear();
        }
        private void delete_button_Click(object sender, EventArgs e)
        {
            int tableID;
            string tableName = school_radioButton.Checked ? "School table" : "Course table";
            /* if School table : only check if table ID and cID is am integer */
            /* otherwise check if Course ID and the Course Fee is an integer */
            bool validInput = Int32.TryParse(first_textBox.Text, out tableID);

            if (validInput)
            {
                handler.DeleteRecord(tableName, tableID);
                MessageBox.Show("Record Deleted. Connection closed.");
                main_Form.connectionFlag = false;
                this.Close();
            }
            else
            {
                MessageBox.Show("Course ID, School ID must be Integers.");
            }
        }
        private void cancel_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
