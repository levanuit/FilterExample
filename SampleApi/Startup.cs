using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using SampleApi.Filters.AuthorizationFilters.PolicyBaseAuthorization;
using SampleApi.Filters.CustomOrder;
using SampleApi.Filters.DealWithDI.ServiceFilterAttribute;
using SampleApi.Filters.Scopes;

namespace SampleApi
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
            // Add filter as service
            services.AddScoped<DIAuthorizationWithServiceFilter>();

            services.AddMvc(option => {
                // Add global filters by instance
                // option.Filters.Add(new GlobalAuthorizationFilter());
                // option.Filters.Add(new GlobalResourceFilter());
                option.Filters.Add(new GlobalCustomOrderFilter());
            }).SetCompatibilityVersion(CompatibilityVersion.Version_2_2);

            //services.AddAuthorization(options =>
            //{
            //    options.AddPolicy("AtLeast18", policy =>
            //    {
            //        //policy.AuthenticationSchemes.Add(JwtBearerDefaults.AuthenticationScheme);
            //        //policy.RequireAuthenticatedUser();
            //        policy.Requirements.Add(new CustomPolicyRequirement(18));
            //    });
            //    options.InvokeHandlersAfterFailure = false;
            //});

            // services.AddSingleton<IAuthorizationHandler, CustomPolicyHandler>();
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
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseMvc();
        }
    }
}
