using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContosoUniversity.Models
{
    public class Student
    {
        // properties
        public int ID { get; set; } // primary key for student
        public string LastName { get; set; }
        public string FirstMidName { get; set; }
        public DateTime EnrollmentDate { get; set; }

        // navigation properties
        public ICollection<Enrollment> Enrollments { get; set; }
    }
}
