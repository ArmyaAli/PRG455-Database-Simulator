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
    public partial class updateForm : Form
    {
        private SQLHandler handler;
        public updateForm(OleDbConnection connection)
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

            if(validInput)
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

        private void update_button_Click(object sender, EventArgs e)
        {
            int tableID;
            int cID;
            decimal cFee;
            string[] tokens = new string[4];
            string tableName = school_radioButton.Checked ? "School table" : "Course table";
            /* if School table : only check if table ID and cID is am integer */
            /* otherwise check if Course ID and the Course Fee is an integer */
            bool validInput = tableName.Equals("School table") 
              ? Int32.TryParse(first_textBox.Text, out tableID) && Int32.TryParse(fifth_textBox.Text, out cID) 
              : Int32.TryParse(first_textBox.Text, out cID) && Decimal.TryParse(fourth_textBox.Text, out cFee);

            if (validInput)
            {
                tokens[0] = "'" + second_textBox.Text + "'";
                tokens[1] = "'" + third_textBox.Text + "'";
                tokens[2] = "'" + fourth_textBox.Text + "'";
                tokens[3] = "'" + fifth_textBox.Text + "'";
                handler.UpdateRecord(tableName, Int32.Parse(first_textBox.Text), tokens);
                MessageBox.Show("Record Updated. Connection closed.");
                this.Close();
            }
            else
            {
                MessageBox.Show("Course ID, School ID must be Integers. Course Fee must be a number type. ");
            }
        }

        private void cancel_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
