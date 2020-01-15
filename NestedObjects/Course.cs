using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NestedObjects
{
    /// <summary>
    /// Represents a individual course 
    /// </summary>
    public class Course
    {
        /// <summary>
        /// Full Title of the course EX: CPW = Computer Programming
        /// </summary>
        public string CourseTitle { get; set; }

        /// <summary>
        /// A short description of class and prereqs
        /// </summary>
        public string CourseDescription { get; set; }

        /// <summary>
        /// Primary/Unique Course ID
        /// Auto Implements 
        /// </summary>
        public int CourseID { get; set; }

        /// <summary>
        /// College Credits earned upon completion of the course
        /// </summary>
        public byte Credits { get; set; }
    }
}
