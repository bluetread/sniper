using Sniper.Common;
using Sniper.Http;
using Sniper.TargetProcess.Routes;
using Xunit;

namespace Sniper.Tests.CRUD.Create.Common.Roles 
{ 
    public class RoleTests 
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
