using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NestedObjects
{
    /// <summary>
    /// Represents a individual Student
    /// </summary>
    public class Student
    {
        /// <summary>
        /// Primary/Unique key for students
        /// Number is generated/Auto increment
        /// </summary>
        public int StudentId { get; set; }

        /// <summary>
        /// First and Last Name of the Student (EX: John Doe)
        /// </summary>
        public string FullName { get; set; }

        /// <summary>
        /// Option Date of the Students Birth
        /// Time is ignored
        /// </summary>
        public DateTime? DateofBirth { get; set; }
    }
}
