using Sniper.Common;
using Sniper.Http;
using Sniper.TargetProcess.Routes;
using Xunit;

namespace Sniper.Tests.CRUD.Create.Common.Impediments 
{ 
    public class ImpedimentTests 
     { 
        [Fact] 
        public void ImpedimentThrowsError() 
        { 
            var client = new TargetProcessClient 
            { 
                ApiSiteInfo = new ApiSiteInfo(TargetProcessRoutes.Route.Impediments) 
            }; 
            var impediment = new Impediment 
            { 
            }; 
        } 
    } 
} 
