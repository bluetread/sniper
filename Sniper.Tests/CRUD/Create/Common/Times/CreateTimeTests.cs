using Sniper.Common;
using Sniper.Http;
using Sniper.TargetProcess.Routes;
using Xunit;

namespace Sniper.Tests.CRUD.Create.Common.Times 
{ 
    public class TimeTests 
     { 
        [Fact] 
        public void TimeThrowsError() 
        { 
            var client = new TargetProcessClient 
            { 
                ApiSiteInfo = new ApiSiteInfo(TargetProcessRoutes.Route.Times) 
            }; 
            var time = new Time 
            { 
            }; 
        } 
    } 
} 
