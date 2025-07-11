using System;
using System.Web;
using System.Web.Mvc;

namespace ElectronicRecyclers.One800Recycling.Web.Helpers.Attributes
{
    public class PremiumUsersOnlyAttribute : AuthorizeAttribute
    {
        protected override bool AuthorizeCore(HttpContextBase httpContext)
        {
            if (httpContext == null)
                throw new ArgumentNullException("httpContext");

            var user = httpContext.User;
            return user.IsInRole("Administrator") || user.IsInRole("Power User");
        }
    }
}