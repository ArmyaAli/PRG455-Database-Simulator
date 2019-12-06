namespace PRG455_Project
{
    partial class deleteForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.fifth_textBox = new System.Windows.Forms.TextBox();
            this.fourth_textBox = new System.Windows.Forms.TextBox();
            this.third_textBox = new System.Windows.Forms.TextBox();
            this.second_textBox = new System.Windows.Forms.TextBox();
            this.first_textBox = new System.Windows.Forms.TextBox();
            this.fifth_label = new System.Windows.Forms.Label();
            this.fourth_label = new System.Windows.Forms.Label();
            this.third_label = new System.Windows.Forms.Label();
            this.second_label = new System.Windows.Forms.Label();
            this.first_label = new System.Windows.Forms.Label();
            this.cancel_button = new System.Windows.Forms.Button();
            this.delete_button = new System.Windows.Forms.Button();
            this.clear_button = new System.Windows.Forms.Button();
            this.refresh_button = new System.Windows.Forms.Button();
            this.table_groupBox = new System.Windows.Forms.GroupBox();
            this.course_radioButton = new System.Windows.Forms.RadioButton();
            this.school_radioButton = new System.Windows.Forms.RadioButton();
            this.table_groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // fifth_textBox
            // 
            this.fifth_textBox.Location = new System.Drawing.Point(98, 172);
            this.fifth_textBox.Name = "fifth_textBox";
            this.fifth_textBox.ReadOnly = true;
            this.fifth_textBox.Size = new System.Drawing.Size(196, 20);
            this.fifth_textBox.TabIndex = 24;
            // 
            // fourth_textBox
            // 
            this.fourth_textBox.Location = new System.Drawing.Point(98, 146);
            this.fourth_textBox.Name = "fourth_textBox";
            this.fourth_textBox.ReadOnly = true;
            this.fourth_textBox.Size = new System.Drawing.Size(196, 20);
            this.fourth_textBox.TabIndex = 23;
            // 
            // third_textBox
            // 
            this.third_textBox.Location = new System.Drawing.Point(98, 120);
            this.third_textBox.Name = "third_textBox";
            this.third_textBox.ReadOnly = true;
            this.third_textBox.Size = new System.Drawing.Size(196, 20);
            this.third_textBox.TabIndex = 22;
            // 
            // second_textBox
            // 
            this.second_textBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.second_textBox.Location = new System.Drawing.Point(98, 93);
            this.second_textBox.Name = "second_textBox";
            this.second_textBox.ReadOnly = true;
            this.second_textBox.Size = new System.Drawing.Size(196, 20);
            this.second_textBox.TabIndex = 21;
            // 
            // first_textBox
            // 
            this.first_textBox.Location = new System.Drawing.Point(98, 65);
            this.first_textBox.Name = "first_textBox";
            this.first_textBox.Size = new System.Drawing.Size(196, 20);
            this.first_textBox.TabIndex = 20;
            // 
            // fifth_label
            // 
            this.fifth_label.AutoSize = true;
            this.fifth_label.Location = new System.Drawing.Point(12, 179);
            this.fifth_label.Name = "fifth_label";
            this.fifth_label.Size = new System.Drawing.Size(54, 13);
            this.fifth_label.TabIndex = 19;
            this.fifth_label.Text = "Course ID";
            // 
            // fourth_label
            // 
            this.fourth_label.AutoSize = true;
            this.fourth_label.Location = new System.Drawing.Point(11, 153);
            this.fourth_label.Name = "fourth_label";
            this.fourth_label.Size = new System.Drawing.Size(74, 13);
            this.fourth_label.TabIndex = 18;
            this.fourth_label.Text = "School Phone";
            // 
            // third_label
            // 
            this.third_label.AutoSize = true;
            this.third_label.Location = new System.Drawing.Point(11, 123);
            this.third_label.Name = "third_label";
            this.third_label.Size = new System.Drawing.Size(81, 13);
            this.third_label.TabIndex = 17;
            this.third_label.Text = "School Address";
            // 
            // second_label
            // 
            this.second_label.AutoSize = true;
            this.second_label.Location = new System.Drawing.Point(12, 93);
            this.second_label.Name = "second_label";
            this.second_label.Size = new System.Drawing.Size(71, 13);
            this.second_label.TabIndex = 16;
            this.second_label.Text = "School Name";
            // 
            // first_label
            // 
            this.first_label.AutoSize = true;
            this.first_label.Location = new System.Drawing.Point(12, 65);
            this.first_label.Name = "first_label";
            this.first_label.Size = new System.Drawing.Size(54, 13);
            this.first_label.TabIndex = 15;
            this.first_label.Text = "School ID";
            // 
            // cancel_button
            // 
            this.cancel_button.Location = new System.Drawing.Point(336, 174);
            this.cancel_button.Name = "cancel_button";
            this.cancel_button.Size = new System.Drawing.Size(75, 23);
            this.cancel_button.TabIndex = 28;
            this.cancel_button.Text = "Cancel";
            this.cancel_button.UseVisualStyleBackColor = true;
            this.cancel_button.Click += new System.EventHandler(this.cancel_button_Click);
            // 
            // delete_button
            // 
            this.delete_button.Location = new System.Drawing.Point(336, 143);
            this.delete_button.Name = "delete_button";
            this.delete_button.Size = new System.Drawing.Size(75, 23);
            this.delete_button.TabIndex = 27;
            this.delete_button.Text = "Delete";
            this.delete_button.UseVisualStyleBackColor = true;
            this.delete_button.Click += new System.EventHandler(this.delete_button_Click);
            // 
            // clear_button
            // 
            this.clear_button.Location = new System.Drawing.Point(336, 84);
            this.clear_button.Name = "clear_button";
            this.clear_button.Size = new System.Drawing.Size(75, 23);
            this.clear_button.TabIndex = 26;
            this.clear_button.Text = "Clear";
            this.clear_button.UseVisualStyleBackColor = true;
            this.clear_button.Click += new System.EventHandler(this.clear_button_Click);
            // 
            // refresh_button
            // 
            this.refresh_button.Location = new System.Drawing.Point(336, 55);
            this.refresh_button.Name = "refresh_button";
            this.refresh_button.Size = new System.Drawing.Size(75, 23);
            this.refresh_button.TabIndex = 25;
            this.refresh_button.Text = "Refresh";
            this.refresh_button.UseVisualStyleBackColor = true;
            this.refresh_button.Click += new System.EventHandler(this.refresh_button_Click);
            // 
            // table_groupBox
            // 
            this.table_groupBox.Controls.Add(this.course_radioButton);
            this.table_groupBox.Controls.Add(this.school_radioButton);
            this.table_groupBox.Location = new System.Drawing.Point(15, 9);
            this.table_groupBox.Name = "table_groupBox";
            this.table_groupBox.Size = new System.Drawing.Size(236, 50);
            this.table_groupBox.TabIndex = 29;
            this.table_groupBox.TabStop = false;
            this.table_groupBox.Text = "Table";
            // 
            // course_radioButton
            // 
            this.course_radioButton.AutoSize = true;
            this.course_radioButton.Location = new System.Drawing.Point(119, 20);
            this.course_radioButton.Name = "course_radioButton";
            this.course_radioButton.Size = new System.Drawing.Size(58, 17);
            this.course_radioButton.TabIndex = 1;
            this.course_radioButton.Text = "Course";
            this.course_radioButton.UseVisualStyleBackColor = true;
            this.course_radioButton.CheckedChanged += new System.EventHandler(this.course_radioButton_CheckedChanged);
            // 
            // school_radioButton
            // 
            this.school_radioButton.AutoSize = true;
            this.school_radioButton.Checked = true;
            this.school_radioButton.Location = new System.Drawing.Point(27, 20);
            this.school_radioButton.Name = "school_radioButton";
            this.school_radioButton.Size = new System.Drawing.Size(58, 17);
            this.school_radioButton.TabIndex = 0;
            this.school_radioButton.TabStop = true;
            this.school_radioButton.Text = "School";
            this.school_radioButton.UseVisualStyleBackColor = true;
            // 
            // deleteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 219);
            this.Controls.Add(this.table_groupBox);
            this.Controls.Add(this.cancel_button);
            this.Controls.Add(this.delete_button);
            this.Controls.Add(this.clear_button);
            this.Controls.Add(this.refresh_button);
            this.Controls.Add(this.fifth_textBox);
            this.Controls.Add(this.fourth_textBox);
            this.Controls.Add(this.third_textBox);
            this.Controls.Add(this.second_textBox);
            this.Controls.Add(this.first_textBox);
            this.Controls.Add(this.fifth_label);
            this.Controls.Add(this.fourth_label);
            this.Controls.Add(this.third_label);
            this.Controls.Add(this.second_label);
            this.Controls.Add(this.first_label);
            this.Name = "deleteForm";
            this.Text = "Delete";
            this.table_groupBox.ResumeLayout(false);
            this.table_groupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox fifth_textBox;
        private System.Windows.Forms.TextBox fourth_textBox;
        private System.Windows.Forms.TextBox third_textBox;
        private System.Windows.Forms.TextBox second_textBox;
        private System.Windows.Forms.TextBox first_textBox;
        private System.Windows.Forms.Label fifth_label;
        private System.Windows.Forms.Label fourth_label;
        private System.Windows.Forms.Label third_label;
        private System.Windows.Forms.Label second_label;
        private System.Windows.Forms.Label first_label;
        private System.Windows.Forms.Button cancel_button;
        private System.Windows.Forms.Button delete_button;
        private System.Windows.Forms.Button clear_button;
        private System.Windows.Forms.Button refresh_button;
        private System.Windows.Forms.GroupBox table_groupBox;
        private System.Windows.Forms.RadioButton course_radioButton;
        private System.Windows.Forms.RadioButton school_radioButton;
    }
}