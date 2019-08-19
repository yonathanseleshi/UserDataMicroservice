using System;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;


namespace UserDataMicroserviceAPI.Models
{
    public class Course
    {


        [Key]
        private ulong courseId;

        [Required]
        private string courseName;

        [Required]
        private Guid ownerId;

        private string description;

        [Required]
        private DateTime createdDate;

        private string primarySubject;

        public ulong CourseId { get => courseId; set => courseId = value; }
        public string CourseName { get => courseName; set => courseName = value; }
        public Guid OwnerId { get => ownerId; set => ownerId = value; }
        public string Description { get => description; set => description = value; }
        public DateTime CreatedDate { get => createdDate; set => createdDate = value; }
        public string PrimarySubject { get => primarySubject; set => primarySubject = value; }
    }
}
