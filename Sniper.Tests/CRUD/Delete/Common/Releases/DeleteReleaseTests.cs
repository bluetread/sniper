using Sniper.Common;
using Sniper.Http;
using Sniper.TargetProcess.Routes;
using Xunit;

namespace Sniper.Tests.CRUD.Delete.Common.Releases
{
    public class DeleteReleaseTests 
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
