using System;
using System.Linq;
using System.Collections.Generic;
using UserDataMicroserviceAPI.Models;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using UserDataMicroserviceAPI.Repositories.Interfaces;


namespace UserDataMicroserviceAPI.Repositories
{
    public class EnrollmentRepo : IEnrollmentRepo
    {
        public EnrollmentRepo()
        {
        }

        public void DeleteEnrollment(Enrollment enrollment)
        {
            throw new NotImplementedException();
        }

        public Task<ActionResult<Enrollment>> GetEnrollment(string enrollmentId)
        {
            throw new NotImplementedException();
        }

        public Task<ActionResult<IQueryable<Enrollment>>> GetUserEnrollments(string userId)
        {
            throw new NotImplementedException();
        }

        public Task<ActionResult<Enrollment>> PostEnrollment(Enrollment enrollment)
        {
            throw new NotImplementedException();
        }

        public Task<ActionResult<Enrollment>> UpdateEnrollmemnt(Enrollment enrollment)
        {
            throw new NotImplementedException();
        }

        public Task<ActionResult<Enrollment>> UpdateUser(Enrollment user)
        {
            throw new NotImplementedException();
        }
    }
}
