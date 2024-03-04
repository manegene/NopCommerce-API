using FirebaseAdmin;
using Google.Apis.Auth.OAuth2;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.IdentityModel.Tokens;
using Nop.RestApi.Service.Models.core;
using Nop.RestApi.Service.Services.Catalogue;
using Nop.RestApi.Service.Services.Core;
using Nop.RestApi.Service.Services.CustomerServices;
using System;
using System.Text.Json.Serialization;

namespace Nop.RestApi.Service
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
            _ = FirebaseApp.Create(new AppOptions
            {
                Credential = GoogleCredential.FromFile(@"./Google/Firebase_key.json")
            });
            _=services.AddScoped<IApiAboutService, ApiAboutService>();
            _ = services.AddScoped<IProductService, ProductService>();
            _ = services.AddScoped<ICartService, CartService>();
            _ = services.AddScoped<ICustomerService, CustomerService>();
            _ = services.AddScoped<IApiMessageService, ApiMessageService>();
            _ = services.AddScoped<Random, Random>();

            _ = services.AddControllers().AddJsonOptions(options =>
            {
                options.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles;
            });
            _ = services.AddDbContext<ApiContext>(opt => opt.UseSqlServer(Configuration.GetConnectionString("AppConnString")));
            _ = services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme).AddJwtBearer(
                options =>
                {
                    options.Authority = Configuration["Jwt:Firebase:ValidIssuer"];

                    options.TokenValidationParameters = new TokenValidationParameters
                    {
                        ValidateIssuer = true,
                        ValidateAudience = true,
                        ValidateLifetime = true,
                        ValidateIssuerSigningKey = true,
                        ValidIssuer = Configuration["Jwt:Firebase:ValidIssuer"],
                        ValidAudience = Configuration["Jwt:Firebase:ValidAudience"]
                    };
                });

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                _ = app.UseDeveloperExceptionPage();
                //app.UseSwagger();
                //app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "API v1"));
            }

            _ = app.UseHttpsRedirection();
            _ = app.UseRouting();
            _ = app.UseAuthentication();

            _ = app.UseAuthorization();

            _ = app.UseEndpoints(endpoints =>
            {
                _ = endpoints.MapControllers();
            });
        }
    }
}
