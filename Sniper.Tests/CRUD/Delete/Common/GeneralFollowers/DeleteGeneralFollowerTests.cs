using Sniper.Common;
using Sniper.Http;
using Sniper.TargetProcess.Routes;
using Xunit;

namespace Sniper.Tests.CRUD.Delete.Common.GeneralFollowers
{
    public class DeleteGeneralFollowerTests 
     { 
        [Fact] 
        public void GeneralFollowerThrowsError() 
        { 
            var client = new TargetProcessClient 
            { 
                ApiSiteInfo = new ApiSiteInfo(TargetProcessRoutes.Route.GeneralFollowers) 
            }; 
            var generalFollower = new GeneralFollower 
            { 
            }; 
        } 
    } 
} 
