﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PracticalTest.Models
{
    public class Student_CourseModel
    {
        public int Student_CourseId { get; set; }
        public int StudentId { get; set; }
        public int CourseId { get; set; }

        public StudentModel Student { get; set; }
        public CourseModel Course { get; set; }
    }
}
