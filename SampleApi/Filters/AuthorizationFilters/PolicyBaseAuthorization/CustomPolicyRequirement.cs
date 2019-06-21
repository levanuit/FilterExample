using Microsoft.AspNetCore.Authorization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SampleApi.Filters.AuthorizationFilters.PolicyBaseAuthorization
{
    public class CustomPolicyRequirement : IAuthorizationRequirement
    {
        public int MinimumAge { get; }

        public CustomPolicyRequirement(int minimumAge)
        {
            this.MinimumAge = minimumAge;
        }
    }
}
