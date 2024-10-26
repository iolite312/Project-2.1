using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Model.Enums;
using System.Net;

namespace Api.Identity
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method)]
    public class RequiresClaimAttribute : Attribute, IAuthorizationFilter
    {
        private readonly string _claimName;
        private readonly ERole[] _claimValues;

        public RequiresClaimAttribute(string claimName, params ERole[] claimValues)
        {
            _claimName = claimName;
            _claimValues = claimValues;
        }

        public void OnAuthorization(AuthorizationFilterContext context)
        {
            bool hasValidClaim = _claimValues.Any(role =>
                context.HttpContext.User.HasClaim(_claimName, role.ToString()));

            if (!hasValidClaim)
            {
                context.Result = new ForbidResult(); // Forbid if no valid claim is found
            }
        }
    }
}
