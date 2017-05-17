using Sniper.Common;
using Sniper.Http;
using Sniper.TargetProcess.Routes;
using Xunit;

namespace Sniper.Tests.CRUD.Create.Common.Releases
{
    public class CreateReleaseTests
    { 
        [Fact] 
        public void ReleaseThrowsError() 
        { 
            var client = new TargetProcessClient 
            { 
                ApiSiteInfo = new ApiSiteInfo(TargetProcessRoutes.Route.Releases) 
            }; 
            var release = new Release 
            { 
            }; 
        } 
    } 
} 
