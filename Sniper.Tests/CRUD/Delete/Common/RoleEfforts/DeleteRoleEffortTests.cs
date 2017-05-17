using Sniper.Common;
using Sniper.Http;
using Sniper.TargetProcess.Routes;
using Xunit;

namespace Sniper.Tests.CRUD.Delete.Common.RoleEfforts
{
    public class DeleteRoleEffortTests 
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
