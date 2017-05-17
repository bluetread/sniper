using Sniper.Common;
using Sniper.Http;
using Sniper.TargetProcess.Routes;
using Xunit;

namespace Sniper.Tests.CRUD.Read.Common.Roles
{
    public class ReadRoleTests
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
