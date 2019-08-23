using System;
using System.Linq;
using System.Collections.Generic;
using UserDataMicroserviceAPI.Models;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using UserDataMicroserviceAPI.Repositories.Interfaces;

namespace UserDataMicroserviceAPI.Repositories
{
    public class LessonRepo : ILessonRepo
    {
        public LessonRepo()
        {
        }

        public void DeleteLesson(Lesson lesson)
        {
            throw new NotImplementedException();
        }

        public Task<ActionResult<Lesson>> GetLesson(string lessonId)
        {
            throw new NotImplementedException();
        }

        public Task<ActionResult<IQueryable<Lesson>>> GetUserLessons(string userId)
        {
            throw new NotImplementedException();
        }

        public Task<ActionResult<Lesson>> PostLesson(Lesson lesson)
        {
            throw new NotImplementedException();
        }

        public Task<ActionResult<Lesson>> UpdateLesson(Lesson lesson)
        {
            throw new NotImplementedException();
        }
    }
}
