using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using UserDataMicroserviceAPI.Models;

namespace UserDataMicroserviceAPI.Repositories.Interfaces
{
    public interface ICourseRepo
    {


        Task<ActionResult<Course>> GetCourse(string courseId);

        Task<ActionResult<IQueryable<Course>>> GetCourses();

        Task<ActionResult<Course>> PostCourse(Course course);

       

        Task<ActionResult<Course>> UpdateCourse(Course user);

        void DeleteCourse(Course course);
    }
}
