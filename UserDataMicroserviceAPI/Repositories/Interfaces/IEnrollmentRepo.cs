using System;
using System.Linq;
using System.Collections.Generic;
using UserDataMicroserviceAPI.Models;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace UserDataMicroserviceAPI.Repositories.Interfaces
{
    public interface IEnrollmentRepo
    {

        Task<ActionResult<Enrollment>> GetEnrollment(string enrollmentId);

        Task<ActionResult<IQueryable<Enrollment>>> GetUserEnrollments(string userId);

        Task<ActionResult<Enrollment>> PostEnrollment(Enrollment enrollment);

        Task<ActionResult<Enrollment>> UpdateEnrollmemnt(Enrollment enrollment);

        Task<ActionResult<Enrollment>> UpdateUser(Enrollment user);

        void DeleteEnrollment(Enrollment enrollment);
    }
}
