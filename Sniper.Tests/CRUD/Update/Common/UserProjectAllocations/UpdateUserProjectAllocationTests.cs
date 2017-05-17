using Sniper.Common;
using Sniper.Http;
using Sniper.TargetProcess.Routes;
using Xunit;

namespace Sniper.Tests.CRUD.Update.Common.UserProjectAllocations
{
    public class UpdateUserProjectAllocationTests
    { 
        [Fact] 
        public void UserProjectAllocationThrowsError() 
        { 
            var client = new TargetProcessClient 
            { 
                ApiSiteInfo = new ApiSiteInfo(TargetProcessRoutes.Route.UserProjectAllocations) 
            }; 
            var userProjectAllocation = new UserProjectAllocation 
            { 
            }; 
        } 
    } 
} 
