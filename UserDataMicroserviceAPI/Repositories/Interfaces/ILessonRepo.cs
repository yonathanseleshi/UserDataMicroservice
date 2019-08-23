using System;
using System.Linq;
using System.Collections.Generic;
using UserDataMicroserviceAPI.Models;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace UserDataMicroserviceAPI.Repositories.Interfaces
{
    public interface ILessonRepo
    {



        Task<ActionResult<Lesson>> GetLesson(string lessonId);

        Task<ActionResult<IQueryable<Lesson>>> GetUserLessons(string userId);

        Task<ActionResult<Lesson>> PostLesson(Lesson lesson);

        Task<ActionResult<Lesson>> UpdateLesson(Lesson lesson);

        void DeleteLesson(Lesson lesson);

    }
}
