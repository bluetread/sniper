using Sniper.Common;
using Sniper.Http;
using Sniper.TargetProcess.Routes;
using Xunit;

namespace Sniper.Tests.CRUD.Read.Common.ProjectMembers
{
    public class ReadProjectMemberTests
    { 
        [Fact] 
        public void ProjectMemberThrowsError() 
        { 
            var client = new TargetProcessClient 
            { 
                ApiSiteInfo = new ApiSiteInfo(TargetProcessRoutes.Route.ProjectMembers) 
            }; 
            var projectMember = new ProjectMember 
            { 
            }; 
        } 
    } 
} 
