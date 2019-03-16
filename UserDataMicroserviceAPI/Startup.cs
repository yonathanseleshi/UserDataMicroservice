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

namespace UserDataMicroserviceAPI
{
    public class Startup
    {
        
        readonly string OpenCorsPolicy = "corsPolicy";
        
        public static string GetDBConnectionString()
        {
 
    
          


            // Using UsWest2
            var ssmClient = new AmazonSimpleSystemsManagementClient(Amazon.RegionEndpoint.USWest2);

        
            var response = ssmClient.GetParameterAsync(new GetParameterRequest
            {
                Name = "airespringendpoint",
                WithDecryption = true
            });

            return response.Result.Parameter.Value;
        }
        
        
        
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services, IHostingEnvironment env)
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

            if (env.IsDevelopment())
            {
                services.AddDbContext<UserDbContext>(options =>
                    options.UseNpgsql(Configuration.GetConnectionString("DevDatabase")));
                
            }
            else
            {
                services.AddDbContext<UserDbContext>(options =>
                    options.UseNpgsql(GetDBConnectionString()));

            }

            
          
            services.AddTransient<IUserCrudRepository, UserCrudRepository>();
            
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