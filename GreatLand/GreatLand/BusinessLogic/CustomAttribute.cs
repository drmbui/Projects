using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

using System.Web.Mvc;
using System.Web.Mvc.Filters;


namespace GreatLand.BusinessLogic
{
    public class CustomAttribute: ActionFilterAttribute, IAuthenticationFilter
    {
        public void OnAuthentication(AuthenticationContext filterContext)
        {
            //For demo purpose only. In real life your custom principal might be retrieved via different source. i.e context/request etc.
           // filterContext.Principal = new MyCustomPrincipal(filterContext.HttpContext.User.Identity, new[] { "Admin" }, "Red");
        }
        public void OnAuthenticationChallenge(AuthenticationChallengeContext filterContext)
        {
            //var user = filterContext.HttpContext.User;
            //if(user==null || !user.Identity.IsAuthenticated)
            //{
            //    filterContext.Result = new HttpUnauthorizedResult();
            //}
        }
    }

    internal class MyCustomPrincipal : IPrincipal
    {
        private IIdentity identity;
        private string[] v1;
        private string v2;

        public MyCustomPrincipal(IIdentity identity, string[] v1, string v2)
        {
            this.identity = identity;
            this.v1 = v1;
            this.v2 = v2;
        }

        public IIdentity Identity
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public bool IsInRole(string role)
        {
            throw new NotImplementedException();
        }
    }
}
