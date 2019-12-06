using System;
using System.Text.RegularExpressions;
using System.Data.OleDb;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRG455_Project
{
    public partial class insertForm : Form
    {
        private SQLHandler handler;
        public insertForm(OleDbConnection connection)
        {
            InitializeComponent();
            handler = new SQLHandler(connection);
        }

        private void course_radioButton_CheckedChanged(object sender, EventArgs e)
        {
            if(school_radioButton.Checked)
            {
                first_label.Text = "School Name";
                second_label.Text = "School Address";
                third_label.Text = "School Phone";
                fourth_label.Text = "Course ID";
            }
            else if(course_radioButton.Checked)
            {
                first_label.Text = "Course Name";
                second_label.Text = "Course Code";
                third_label.Text = "Course Fee";
                fourth_label.Text = "Course Location";
            }
        }

        private void clear_button_Click(object sender, EventArgs e)
        {
            first_textBox.Clear();
            second_textBox.Clear();
            third_textBox.Clear();
            fourth_textBox.Clear();
        }

        private void save_button_Click(object sender, EventArgs e)
        {
            string[] valTokens = { first_textBox.Text, second_textBox.Text , third_textBox.Text , fourth_textBox.Text };
            int tempINT;
            decimal tempDECIMAL;
            string tableName = school_radioButton.Checked ? "School table" : "Course table";
            
            bool validateTokens = tableName.Equals("School table") 
                ? Int32.TryParse(fourth_textBox.Text, out tempINT) 
                : Decimal.TryParse(third_textBox.Text, out tempDECIMAL);
            if (validateTokens)
            {
                handler.InsertRecord(tableName, valTokens);
                main_Form.connectionFlag = false; // ends connection when updated
                MessageBox.Show("Record inserted. Connection closed.");
                this.Close();
                
            }else
            {
                MessageBox.Show("Course ID must be an Integer or Course Fee must be a number!");
            }
        }

        private void cancel_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
