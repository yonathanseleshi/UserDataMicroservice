using System;
using System.Linq;
using System.Collections.Generic;
using UserDataMicroserviceAPI.Models;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;


namespace UserDataMicroserviceAPI.Repositories.Interfaces
{
    public interface IReviewRepo
    {



        Task<ActionResult<Review>> GetReview(string reviewId);

        Task<ActionResult<IQueryable<Review>>> GetUserReviews(string userId);

        Task<ActionResult<IQueryable<Review>>> GetCourseReviews(string courseId);

        Task<ActionResult<IQueryable<Review>>> GetProjectReviews(string projectId);
     
        Task<ActionResult<Review>> PostReview(Review review);

        Task<ActionResult<Review>> UpdateReview(Review review);

        void DeleteReview(Review review);
    }
}
