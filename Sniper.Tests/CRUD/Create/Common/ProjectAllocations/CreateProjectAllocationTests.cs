using Sniper.Common;
using Sniper.Http;
using Sniper.TargetProcess.Routes;
using Xunit;

namespace Sniper.Tests.CRUD.Create.Common.ProjectAllocations 
{ 
    public class ProjectAllocationTests 
     { 
        [Fact] 
        public void ProjectAllocationThrowsError() 
        { 
            var client = new TargetProcessClient 
            { 
                ApiSiteInfo = new ApiSiteInfo(TargetProcessRoutes.Route.ProjectAllocations) 
            }; 
            var projectAllocation = new ProjectAllocation 
            { 
            }; 
        } 
    } 
} 
