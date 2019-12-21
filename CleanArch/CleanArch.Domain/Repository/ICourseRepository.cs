using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArch.Domain.Repository
{
   public interface ICourseRepository
    {
        IEnumerable<Course> GetCourses();
    }

}
