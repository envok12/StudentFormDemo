using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentFormDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            Student student = BuildStudent();
            string summary = BuildSummary(student);
            summaryTextBox.Text = summary;
        }

        private Student BuildStudent()
        {
            Student student = new Student();
            student.FirstName = firstNameTextBox.Text;
            student.LastName = lastNameTextBox.Text;
            student.StudentNumber = studnetIDTextBox.Text;
            student.Major = this.SelectedMajor;
            student.Courses = this.SelectedCourses; //needs these to get info from props/meths below
            student.Scores = this.SelectedScores;
            return student;
        }

        private string BuildSummary(Student student)
        {
            string summary =
                "Student's ID number is " + student.StudentNumber +
                "\r\nStudent's Major is " + student.Major +
                "\r\nStudent's First Name is " + student.FirstName +
                "\r\nStudent's Last Name is " + student.LastName +
                "\r\nStudent's Average is " + student.Average +
                "\r\r\nCourses: ";

            if (student.Courses != null)
            {
                foreach (string course in student.Courses)
                {
                    summary += "\r\n" + course;
                }
            }
            return summary;
        }

        private string SelectedMajor //prop
        {
            get
            {
                if (programmingRadioButton.Checked)
                {
                    return "Programming";
                }
                else if (webDesignRadioButton.Checked)
                {
                    return "Web Design";
                }
                else if (ITRadioButton.Checked)
                {
                    return "IT";
                }
                else
                {
                    return "Undeclared";
                }
            }
        }

        private string[] SelectedCourses
        {
            get
            {
                List<string> coursesList = new List<string>();
                if (cis101CheckBox.Checked)
                {
                    coursesList.Add("CIS 101");
                }
                if (cis102CheckBox.Checked)
                {
                    coursesList.Add("CIS 102");
                }
                if (cis103CheckBox.Checked)
                {
                    coursesList.Add("CIS 103");
                }
                if (cis104CheckBox.Checked)
                {
                    coursesList.Add("CIS 104");
                }
                string[] coursesArray = coursesList.ToArray();
                return coursesArray;
            }
        }

        private int[] SelectedScores
        {
            get
            {
                List<string> scoresStrings = new List<string>();
                if (cis101CheckBox.Checked)
                {
                    scoresStrings.Add(score101TextBox.Text);
                }
                if (cis102CheckBox.Checked)
                {
                    scoresStrings.Add(score102TextBox.Text);
                }
                if (cis103CheckBox.Checked)
                {
                    scoresStrings.Add(score103TextBox.Text);
                }
                if (cis104CheckBox.Checked)
                {
                    scoresStrings.Add(score104TextBox.Text);
                }
                List<int> scoreInts = new List<int>();
                foreach (string scoreString in scoresStrings)
                {
                    int scoreInt = Convert.ToInt32(scoreString);
                    scoreInts.Add(scoreInt);
                }
                int[] scoreIntArray = scoreInts.ToArray();
                return scoreIntArray;
            }
        }

        private void cis101CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if(cis101CheckBox.Checked)
            {
                score101TextBox.Visible = true;
            }
        }

        private void cis102CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (cis102CheckBox.Checked)
            {
                score102TextBox.Visible = true;
            }
         
        }

        private void cis103CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (cis103CheckBox.Checked)
            {
                score103TextBox.Visible = true;
            }
           
        }

        private void cis104CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (cis104CheckBox.Checked)
            {
                score104TextBox.Visible = true;
            }
        }
    }
}
