using Sniper.Common;
using Sniper.Http;
using Sniper.TargetProcess.Routes;
using Xunit;

namespace Sniper.Tests.CRUD.Update.Common.Roles
{
    public class UpdateRoleTests
    { 
        [Fact] 
        public void RoleThrowsError() 
        { 
            var client = new TargetProcessClient 
            { 
                ApiSiteInfo = new ApiSiteInfo(TargetProcessRoutes.Route.Roles) 
            }; 
            var role = new Role 
            { 
            }; 
        } 
    } 
} 
