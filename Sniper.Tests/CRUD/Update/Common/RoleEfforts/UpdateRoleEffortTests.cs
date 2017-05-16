using Sniper.Common;
using Sniper.Http;
using Sniper.TargetProcess.Routes;
using Xunit;

namespace Sniper.Tests.CRUD.Update.Common.RoleEfforts
{
    public class UpdateRoleEffortTests
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
