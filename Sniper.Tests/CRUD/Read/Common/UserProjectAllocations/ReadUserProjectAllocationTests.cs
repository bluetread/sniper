using Sniper.Common;
using Sniper.Http;
using Sniper.TargetProcess.Routes;
using Xunit;

namespace Sniper.Tests.CRUD.Read.Common.UserProjectAllocations
{
    public class ReadUserProjectAllocationTests
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
