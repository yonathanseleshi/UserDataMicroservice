using Amazon.SimpleSystemsManagement;
using Amazon.SimpleSystemsManagement.Model;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using UserDataMicroserviceAPI.Models;
using UserDataMicroserviceAPI.Repositories;
using UserDataMicroserviceAPI.Repositories.Interfaces;

namespace UserDataMicroserviceAPI
{
    public class Startup
    {
        
        readonly string OpenCorsPolicy = "corsPolicy";
        
        public static string GetDBConnectionString()
        {
 
    
          


            // Using UsWest2
            var ssmClient = new AmazonSimpleSystemsManagementClient(Amazon.RegionEndpoint.USWest1);

        
            var response = ssmClient.GetParameterAsync(new GetParameterRequest
            {
                Name = "somulecodevdbconnectionstring",
                WithDecryption = false
            });

            return response.Result.Parameter.Value;
        }
        
        
        
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            
            //Establish the CORS Policy
            services.AddCors(options =>
            {
                options.AddPolicy(OpenCorsPolicy,
                    builder =>
                    {
                        builder.AllowAnyOrigin()
                            .AllowAnyHeader()
                            .AllowAnyMethod();
                    });
            });
            
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);

            
            services.AddDbContext<UserDbContext>(options =>
                options.UseNpgsql(GetDBConnectionString()));
            
            
            /*
            if (env.IsDevelopment())
            {
                
                services.AddDbContext<UserDbContext>(options =>
                options.UseNpgsql(Configuration.GetConnectionString("DevDatabase")));
            }
            else
            {
                

            }

            */
          
            services.AddSingleton<IUserCrudRepository, UserCrudRepository>();
            services.AddSingleton<IChatRepo, ChatRepo>();
            services.AddSingleton<ICommentRepo, CommentRepo>();
            services.AddSingleton<ICourseRepo, CourseRepo>();
            services.AddSingleton<IEnrollmentRepo, EnrollmentRepo>();
            services.AddSingleton<IFavoriteRepo, FavoriteRepo>();
            services.AddSingleton<IInspirationRepo, InspirationRepo>();
            services.AddSingleton<ILessonRepo, LessonRepo>();
            services.AddSingleton<INotificationRepo, NotificationRepo>();
            services.AddSingleton<PlaylistRepo, PlaylistRepo>();
            services.AddSingleton<IPoolRepo, PoolRepo>();
            services.AddSingleton<IRecommendedCourseRepo, RecommendedCourseRepo>();
            services.AddSingleton<IRecommendedInstructorRepo, RecommendedInstructorRepo>();
            services.AddSingleton<IRecommendedJobRepo, RecommendedJobRepo>();
            services.AddSingleton<IRecommendedPostRepo, RecommendedPostRepo>();
            services.AddSingleton<IRecommendedProjectRepo, RecommendedProjectRepo>();
            services.AddSingleton<IRecommendedSchoolRepo, RecommendedSchoolRepo>();
            services.AddSingleton<IRecommendedUserRepo, RecommendedUserRepo>();
            services.AddSingleton<IRelationshipRepo, RelationshipRepo>();
            services.AddSingleton<IReviewRepo, ReviewRepo>();
            services.AddSingleton<ISocialPostRepo, SocialPostRepo>();
            services.AddSingleton<ISubscriptionRepo, SubscriptionRepo>();
            services.AddSingleton<ITransactionRepo, TransactionRepo>();
            services.AddSingleton<IWalletRepo, WalletRepo>();
            services.AddSingleton<IWishlistRepo, WishlistRepo>();




            services.Configure<PasswordHasherOptions>(option =>
            {
                option.IterationCount = 12000;
                option.CompatibilityMode = PasswordHasherCompatibilityMode.IdentityV3;
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment() || env.IsStaging())
                app.UseDeveloperExceptionPage();
            else
                app.UseHsts();
            
            
            app.UseCors(OpenCorsPolicy); 

            app.UseHttpsRedirection();
            app.UseMvc();
        }
    }
}