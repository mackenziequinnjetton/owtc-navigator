using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OWTCNavigatorClasses;

namespace OWTCNavigator
{
    public partial class OWTCNavigatorForm : Form
    {
        public OWTCNavigatorForm()
        {
            InitializeComponent();
        }

        private void studentIDTextBox_Leave(object sender, EventArgs e)
        {
            if (studentIDTextBox.Text == "")
            {
                studentIDTextBox.Text = "Enter your student ID# here";
            }
        }

        private void studentIDSubmitButton_Click(object sender, EventArgs e)
        {
            // Validating student ID# and checking database
            // for student information goes here

            // The below code assumes that the student ID# was valid 
            // and that the ID was found in the database

            var studentScheduleStub = new Schedule(new List<int> { 0, 6, 6, 6, 6, 6, 0 });
        }
    }
}
