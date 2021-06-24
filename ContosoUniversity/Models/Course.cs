﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ContosoUniversity.Models
{
    public class Course
    {
        // properties
        [DatabaseGenerated(DatabaseGeneratedOption.None)] // this attribute allows entering the PK for the course rather than having the database generate it
        public int CourseID { get; set; }
        public string Title { get; set; }
        public int Credits { get; set; }

        // navigation properties
        public ICollection<Enrollment> Enrollments { get; set; }
    }
}
