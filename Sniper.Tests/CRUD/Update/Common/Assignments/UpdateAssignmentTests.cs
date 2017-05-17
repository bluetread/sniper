using Sniper.Common;
using Sniper.Http;
using Sniper.TargetProcess.Routes;
using Xunit;

namespace Sniper.Tests.CRUD.Update.Common.Assignments
{
    public class UpdateAssignmentTests
    { 
        [Fact] 
        public void AssignmentThrowsError() 
        { 
            var client = new TargetProcessClient 
            { 
                ApiSiteInfo = new ApiSiteInfo(TargetProcessRoutes.Route.Assignments) 
            }; 
            var assignment = new Assignment 
            { 
            }; 
        } 
    } 
} 
