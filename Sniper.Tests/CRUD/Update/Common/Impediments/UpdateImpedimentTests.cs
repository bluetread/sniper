using Sniper.Common;
using Sniper.Http;
using Sniper.TargetProcess.Routes;
using Xunit;

namespace Sniper.Tests.CRUD.Update.Common.Impediments
{
    public class UpdateImpedimentTests
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
