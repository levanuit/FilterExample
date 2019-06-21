using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SampleApi.Filters.AuthorizationFilters.PolicyBaseAuthorization
{
    public class CustomPolicyHandler : AuthorizationHandler<CustomPolicyRequirement>
    {
        protected override Task HandleRequirementAsync(AuthorizationHandlerContext context, CustomPolicyRequirement requirement)
        {
            // Accessing MVC request context in handlers
            if (context.Resource is AuthorizationFilterContext mvcContext)
            {
                // Examine MVC-specific things like HttpContext data.

                //if (!context.User.HasClaim(c => c.Type == "Age"))
                //{
                //    return Task.CompletedTask;
                //}

                //int age = Convert.ToInt32(context.User.FindFirst(c => c.Type == "Age").Value);

                //if (age >= requirement.MinimumAge)
                //{
                //    context.Succeed(requirement);
                //}

                if (!mvcContext.HttpContext.Items.ContainsKey("Age"))
                {
                    context.Fail();
                    return Task.CompletedTask;
                }

                int age = Convert.ToInt32(mvcContext.HttpContext.Items["Age"]);

                if(age >= requirement.MinimumAge)
                {
                    context.Succeed(requirement);
                }
            }

            return Task.CompletedTask;

            // Note: this implement for specific policy requirement, we can handle multi requirements just by implement IAuthorizationHandler
        }
    }
}
