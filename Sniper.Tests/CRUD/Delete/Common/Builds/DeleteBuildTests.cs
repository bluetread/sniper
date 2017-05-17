using Sniper.Common;
using Sniper.Http;
using Sniper.TargetProcess.Routes;
using Xunit;

namespace Sniper.Tests.CRUD.Delete.Common.Builds
{
    public class DeleteBuildTests 
     { 
        [Fact] 
        public void BuildThrowsError() 
        { 
            var client = new TargetProcessClient 
            { 
                ApiSiteInfo = new ApiSiteInfo(TargetProcessRoutes.Route.Builds) 
            }; 
            var build = new Build 
            { 
            }; 
        } 
    } 
} 
