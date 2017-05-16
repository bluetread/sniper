using Sniper.Common;
using Sniper.Http;
using Sniper.TargetProcess.Routes;
using Xunit;

namespace Sniper.Tests.CRUD.Read.Common.ReleaseProjects
{
    public class ReadReleaseProjectTests
    { 
        [Fact] 
        public void ReleaseProjectThrowsError() 
        { 
            var client = new TargetProcessClient 
            { 
                ApiSiteInfo = new ApiSiteInfo(TargetProcessRoutes.Route.ReleaseProjects) 
            }; 
            var releaseProject = new ReleaseProject 
            { 
            }; 
        } 
    } 
} 
