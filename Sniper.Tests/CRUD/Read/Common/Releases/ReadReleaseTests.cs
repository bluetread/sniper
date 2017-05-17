using Sniper.Common;
using Sniper.Http;
using Sniper.TargetProcess.Routes;
using Xunit;

namespace Sniper.Tests.CRUD.Read.Common.Releases
{
    public class ReadReleaseTests
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
