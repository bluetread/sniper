using Sniper.Common;
using Sniper.Http;
using Sniper.TargetProcess.Routes;
using Xunit;

namespace Sniper.Tests.CRUD.Create.Common.RoleEfforts
{
    public class CreateRoleEffortTests
    { 
        [Fact] 
        public void RoleEffortThrowsError() 
        { 
            var client = new TargetProcessClient 
            { 
                ApiSiteInfo = new ApiSiteInfo(TargetProcessRoutes.Route.RoleEfforts) 
            }; 
            var roleEffort = new RoleEffort 
            { 
            }; 
        } 
    } 
} 
