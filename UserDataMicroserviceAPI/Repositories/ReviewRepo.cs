using System;
using System.Linq;
using System.Collections.Generic;
using UserDataMicroserviceAPI.Models;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using UserDataMicroserviceAPI.Repositories.Interfaces;


namespace UserDataMicroserviceAPI.Repositories
{
    public class ReviewRepo : IReviewRepo
    {
        public ReviewRepo()
        {
        }

        public void DeleteReview(Review review)
        {
            throw new NotImplementedException();
        }

        public Task<ActionResult<IQueryable<Review>>> GetCourseReviews(string courseId)
        {
            throw new NotImplementedException();
        }

        public Task<ActionResult<IQueryable<Review>>> GetProjectReviews(string projectId)
        {
            throw new NotImplementedException();
        }

        public Task<ActionResult<Review>> GetReview(string reviewId)
        {
            throw new NotImplementedException();
        }

        public Task<ActionResult<IQueryable<Review>>> GetUserReviews(string userId)
        {
            throw new NotImplementedException();
        }

        public Task<ActionResult<Review>> PostReview(Review review)
        {
            throw new NotImplementedException();
        }

        public Task<ActionResult<Review>> UpdateReview(Review review)
        {
            throw new NotImplementedException();
        }
    }
}
