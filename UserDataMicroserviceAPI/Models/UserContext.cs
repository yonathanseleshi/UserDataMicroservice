using Microsoft.EntityFrameworkCore;

namespace UserDataMicroserviceAPI.Models
{
    public class UserDbContext : DbContext
    {
        public UserDbContext(DbContextOptions<UserDbContext> options) : base(options)
        {
        }


        public DbSet<User> Users { get; set; }

        public DbSet<Chat> Chats { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }
        public DbSet<Favorite> Favorites { get; set; }
        public DbSet<Inspiration> Inspirations { get; set; }

        public DbSet<Transaction> Transactions { get; set; }

        public DbSet<SocialPost> SocialPosts { get; set; }

        public DbSet<InstructorSubscription> InstructorSubscriptions { get; set; }

        public DbSet<Lesson> Lessons { get; set; }

        public DbSet<Notification> Notifications { get; set; }

        public DbSet<Playlist> Playlists { get; set; }

        public DbSet<Pool> Pools { get; set; }

        public DbSet<Relationship> Relationships { get; set; }

        public DbSet<Review> Reviews { get; set; }

        public DbSet<Wallet> Wallets { get; set; }

        public DbSet<Wishlist> Wishlists { get; set; }

        public DbSet<Subscription> Subscriptions { get; set; }

        public DbSet<RecommendedCourse> RecommendedCourses { get; set; }

        public DbSet<RecommendedInstructor> RecommendedInstructors { get; set; }


        public DbSet<RecommendedJob> RecommendedJobs { get; set; }

        public DbSet<RecommendedLesson> RecommendedLessons { get; set; }

        public DbSet<RecommendedPost> RecommendedPosts { get; set; }

        public DbSet<RecommendedProject> RecommendedProjects { get; set; }

        public DbSet<RecommendedSchool> RecommendedSchools { get; set; }

        public DbSet<RecommendedUser> RecommendedUsers { get; set; }

        



    }
}