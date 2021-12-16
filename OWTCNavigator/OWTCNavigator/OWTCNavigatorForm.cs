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

        private void studentIDTextBox_MouseUp(object sender, MouseEventArgs e)
        {
            // If the textbox's text is the default text, select it
            // so that the user can easily put in their student ID#
            if (studentIDTextBox.Text == "Enter your student ID# here")
            {
                studentIDTextBox.SelectAll();
            }
        }

        private void studentIDTextBox_Leave(object sender, EventArgs e)
        {
            // If the student has not entered an ID#, replace the
            // empty text with the default text
            if (studentIDTextBox.Text == "")
            {
                studentIDTextBox.Text = "Enter your student ID# here";
            }
        }

        private void studentIDSubmitButton_Click(object sender, EventArgs e)
        {
            dueDatesListBox.Items.Clear();
            
            // Checks that provided student ID is in the right format
            if (ValidateStudentID.Validate(studentIDTextBox.Text))
            {
                // Check if student ID is found in the database
            }
            else
            {
                MessageBox.Show("Invalid entry. " +
                    "Please enter a valid student ID#.");

                studentIDTextBox.Focus();
                studentIDTextBox.SelectAll();
            }

            // The below code assumes that the student ID# was valid 
            // and that the ID was found in the database

            // Sample student schedule for testing purposes
            // In future, student's schedule will be pulled from database
            var studentScheduleStub = new Schedule(
                new List<int> { 0, 6, 6, 6, 6, 6, 0 });

            var courseStartTimeStub = new DateTime(2022, 1, 1);

            // Sample course information stored in a CSV,
            // which is then processed appropriately
            List<Module> courseInfoFileStub = CourseFileProcessor
                .ProcessCourseModules(@"C:\Users\macke\OneDrive\Otech" +
                @"\PROG1060\Database Files\Software Technology" +
                @"\Structured Project II.csv");

            // Generates module due dates
            List<ModuleDueDate> moduleDueDatesStub = GenerateModuleDueDates
                .Generate(studentScheduleStub, courseStartTimeStub,
                courseInfoFileStub);

            dueDatesListBox.Items.Add("MODULE DUE DATES");
            dueDatesListBox.Items.Add("");

            // Adds due date information to listbox
            foreach (var dueDate in moduleDueDatesStub)
            {
                dueDatesListBox.Items.Add($"{dueDate.Name}: " +
                    $"{dueDate.GetFormattedDueDate()}");
            }
        }


    }
}
