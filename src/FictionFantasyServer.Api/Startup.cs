using System.Reflection;
using AutoMapper;
using FictionFantasyServer.Data;
using FictionFantasyServer.Models;
using FictionFantasyServer.Services;
using FictionFantasyServer.Services.Interfaces;
using IdentityServer4.AccessTokenValidation;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace FictionFantasyServer.Api
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<FFDbContext>(options => options.UseNpgsql("Host=localhost;Database=FictionFantasy;"));
            services.AddScoped<IBookService, BookService>();
            services.AddScoped<IBookCharacterService, BookCharacterService>();
            services.AddScoped<ICharacterService, CharacterService>();
            services.AddScoped<IUserBookService, UserBookService>();
            services.AddScoped<IUserService, UserService>();
            services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddAutoMapper(Assembly.GetAssembly(typeof(Book)));
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("1.0", new Swashbuckle.AspNetCore.Swagger.Info { Title = "Fiction Fantasy API", Version = "1.0"});
            });
            services.AddCors();
            services.AddAuthentication(IdentityServerAuthenticationDefaults.AuthenticationScheme)
                .AddIdentityServerAuthentication(options =>
                {
                    options.Authority = Configuration["AuthorityUrl"];
                    options.ApiName = "ffs";
                    options.RequireHttpsMetadata = false;
                });
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseHsts();
            }

            app.UseHttpsRedirection();

            app.UseSwagger();

            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/1.0/swagger.json", "FF API V1");
            });
            
            app.UseCors(configurePolicy =>
            {
                configurePolicy.AllowAnyHeader();
                configurePolicy.AllowAnyMethod();
                configurePolicy.AllowAnyOrigin();
            });

            app.UseAuthentication();

            app.UseMvc();
        }
    }
}
