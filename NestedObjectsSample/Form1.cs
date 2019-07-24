using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NestedObjectsSample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<Instructor> instructors = new List<Instructor>();

            PopulateInstructorTestData(instructors);

            lstInstructors.DataSource = instructors;
            lstInstructors.DisplayMember = nameof(Instructor.FullName);
        }

        private void PopulateInstructorTestData(List<Instructor> instructors)
        {
            //Object initialization style
            Instructor instructorKen = new Instructor()
            {
                Email = "Ken@cptc.edu",
                FullName = "Dr. Kenneth Meerdink"
            };

            List<Course> kenCourses = new List<Course>()
            {
                new Course()
                {
                    Title = "Data Structures",
                    CourseNumber = "CPW 245",
                    Roster = new List<Student>()
                    {
                            new Student("Jim Halpert"),
                            new Student("Pam Halpert")
                    }
                },
                new Course()
                {
                    Title = "Java II",
                    CourseNumber = "CPW 243",
                    Roster = new List<Student>()
                    {
                        new Student("Dwight Schrute"),
                        new Student("Michael Scott")
                    }
                }
            };

            instructorKen.CourseLoad = kenCourses;

            instructors.Add(instructorKen);
        }

        private void lstInstructors_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Pick an instructor
            Instructor currInstructor =
                lstInstructors.SelectedItem as Instructor;

            //Populate second list box with courses
            List<Course> courses = currInstructor.CourseLoad;

            // populates courses with data binding
            lstCourses.DataSource = courses;
            //DisplayMember must be a single property
            lstCourses.DisplayMember = nameof(Course.CourseNumber);
        }

        private void lstCourses_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Checks for no course selected
            if (lstCourses.SelectedIndex < 0)
                return;

            Course selectedCourse = lstCourses.SelectedItem as Course;

            lstStudents.DataSource = selectedCourse.Roster;
            lstStudents.DisplayMember = nameof(Student.FullName);
        }
    }
}
