using Sniper.Common;
using Sniper.Http;
using Sniper.TargetProcess.Routes;
using Xunit;

namespace Sniper.Tests.CRUD.Create.Common.Features 
{ 
    public class FeatureTests 
     { 
        [Fact] 
        public void FeatureThrowsError() 
        { 
            var client = new TargetProcessClient 
            { 
                ApiSiteInfo = new ApiSiteInfo(TargetProcessRoutes.Route.Features) 
            }; 
            var feature = new Feature 
            { 
            }; 
        } 
    } 
} 
