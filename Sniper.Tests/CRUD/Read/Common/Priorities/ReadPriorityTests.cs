using Sniper.Common;
using Sniper.Http;
using Sniper.TargetProcess.Routes;
using Xunit;

namespace Sniper.Tests.CRUD.Read.Common.Priorities
{
    public class PriorityTests 
     { 
        [Fact] 
        public void PriorityThrowsError() 
        { 
            var client = new TargetProcessClient 
            { 
                ApiSiteInfo = new ApiSiteInfo(TargetProcessRoutes.Route.Priorities) 
            }; 
            var priority = new Priority 
            { 
            }; 
        } 
    } 
} 
