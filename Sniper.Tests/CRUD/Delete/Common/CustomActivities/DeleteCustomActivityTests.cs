using Sniper.Common;
using Sniper.Http;
using Sniper.TargetProcess.Routes;
using Xunit;

namespace Sniper.Tests.CRUD.Delete.Common.CustomActivities
{
    public class DeleteCustomActivityTests 
     { 
        [Fact] 
        public void CustomActivityThrowsError() 
        { 
            var client = new TargetProcessClient 
            { 
                ApiSiteInfo = new ApiSiteInfo(TargetProcessRoutes.Route.CustomActivities) 
            }; 
            var customActivity = new CustomActivity 
            { 
            }; 
        } 
    } 
} 
