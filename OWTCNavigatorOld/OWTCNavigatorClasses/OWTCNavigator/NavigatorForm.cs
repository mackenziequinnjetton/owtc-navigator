using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace OWTCNavigator
{
    public partial class NavigatorForm : Form
    {
        public NavigatorForm()
        {
            InitializeComponent();
        }

        private void IDTextBox_Leave(object sender, EventArgs e)
        {
            if (IDTextBox.Text == "")
            {
                IDTextBox.Text = "Student ID#";
            }
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            // Validating student ID# and checking database
            // for student information goes here

            // The below code assumes that the student ID# was valid 
            // and that the ID was found in the database

            // var stubStudentSchedule = new 

            dueDatesListBox.Items.Add("MODULE DUE DATES");
            dueDatesListBox.Items.Add("");
        }
    }
}
