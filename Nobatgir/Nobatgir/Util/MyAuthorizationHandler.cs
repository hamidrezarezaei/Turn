using Microsoft.AspNetCore.Authorization;
using System;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Nobatgir.Model;
using Nobatgir.Services;

namespace Nobatgir.Util
{
    public class MyRequirement : IAuthorizationRequirement
    {
        public MyRequirement()
        {
        }
    }

    public class MyAuthorizationHandler : AuthorizationHandler<MyRequirement>
    {
        public Repository Repository;
        private readonly UserManager<User> _usermanager;

        public MyAuthorizationHandler(Repository repository, UserManager<User> usermanager)
        {
            this.Repository = repository;
            this._usermanager = usermanager;
        }

        protected override Task HandleRequirementAsync(AuthorizationHandlerContext context,
            MyRequirement requirement)
        {
            // if user not logged in
            if (!context.User.Identity.IsAuthenticated)
                return Task.CompletedTask;

            if (Repository.UserLevelID == 1)
            {
                context.Succeed(requirement);

                return Task.CompletedTask;
            }

            // if level is low
            if (Repository.UserLevelID > Repository.CurrentLevel)
                return Task.CompletedTask;

            var usersiteid = this._usermanager.GetUserAsync(context.User).Result.SiteID;

            // if user is not for this site
            if (Repository.SiteID != usersiteid)
                return Task.CompletedTask;

            var userrootid = this._usermanager.GetUserAsync(context.User).Result.RootID;

            if (Repository.UserLevelID == 2)
            {
                context.Succeed(requirement);

                return Task.CompletedTask;
            }

            // if UserLevelID > 2 and is not for this site
            if (Repository.CategoryID != userrootid)
                return Task.CompletedTask;

            if (Repository.UserLevelID == 3)
            {
                context.Succeed(requirement);

                return Task.CompletedTask;
            }

            // if UserLevelID > 3 and is not for this site
            if (Repository.ExpertID != userrootid)
                return Task.CompletedTask;

            context.Succeed(requirement);

            return Task.CompletedTask;
        }
    }
}
