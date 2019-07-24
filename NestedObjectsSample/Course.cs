using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NestedObjectsSample
{
    /// <summary>
    /// Represents a single college course
    /// </summary>
    class Course
    {
        /// <summary>
        /// Constructor creates a course object with an empty 
        /// student roster(Initializes)
        /// </summary>
        public Course()
        {
            Roster = new List<Student>();
        }
        /// <summary>
        /// The unique course number
        /// ex. CPW 212
        /// </summary>
        public string CourseNumber { get; set; }

        /// <summary>
        /// The official course title
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Number of credits for successful completion of course
        /// </summary>
        public byte NumberOfCredits { get; set; }

        /// <summary>
        /// The official course description
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// The students currently enrolled in the course
        /// </summary>
        public List<Student> Roster { get; set; }
    }
}
