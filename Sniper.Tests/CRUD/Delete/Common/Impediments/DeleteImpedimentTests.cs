using Sniper.Common;
using Sniper.Http;
using Sniper.TargetProcess.Routes;
using Xunit;

namespace Sniper.Tests.CRUD.Delete.Common.Impediments
{
    public class DeleteImpedimentTests 
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
