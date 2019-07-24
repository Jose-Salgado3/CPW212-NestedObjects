using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NestedObjectsSample
{
    /// <summary>
    /// Represents an individual student
    /// </summary>
    class Student
    {
        /// <summary>
        /// The legal first and last
        /// ex. J Doe
        /// </summary>
        public string FullName { get; set; }

        /// <summary>
        /// The students school provided email address
        /// </summary>
        public string EmailAddress { get; set; }

        /// <summary>
        /// Students mailing address
        /// </summary>
        public string HomeAddress { get; set; }

        /// <summary>
        /// The students home phone number
        /// </summary>
        public String Phone { get; set; }
    }
}
