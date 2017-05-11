using Sniper.Common;
using Sniper.Http;
using Sniper.TargetProcess.Routes;
using Xunit;

namespace Sniper.Tests.CRUD.Create.Common.Epics 
{ 
    public class EpicTests 
     { 
        [Fact] 
        public void EpicThrowsError() 
        { 
            var client = new TargetProcessClient 
            { 
                ApiSiteInfo = new ApiSiteInfo(TargetProcessRoutes.Route.Epics) 
            }; 
            var epic = new Epic 
            { 
            }; 
        } 
    } 
} 
