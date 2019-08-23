using System;
using System.Linq;
using System.Collections.Generic;
using UserDataMicroserviceAPI.Models;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using UserDataMicroserviceAPI.Repositories.Interfaces;


namespace UserDataMicroserviceAPI.Repositories
{
    public class CourseRepo : ICourseRepo
    {
        public CourseRepo()
        {
        }

        public void DeleteCourse(Course course)
        {
            throw new NotImplementedException();
        }

        public Task<ActionResult<Course>> GetCourse(string courseId)
        {
            throw new NotImplementedException();
        }

        public Task<ActionResult<IQueryable<Course>>> GetCourses()
        {
            throw new NotImplementedException();
        }

        public Task<ActionResult<Course>> PostCourse(Course course)
        {
            throw new NotImplementedException();
        }

        public Task<ActionResult<Course>> UpdateCourse(Course user)
        {
            throw new NotImplementedException();
        }
    }
}
