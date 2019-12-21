using CleanArch.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArch.Application.ViewModel
{
   public class CourseViewModel
    {
        IEnumerable<Course> Courses { get; set; }
    }
}
