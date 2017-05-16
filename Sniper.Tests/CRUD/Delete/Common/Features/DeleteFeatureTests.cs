using Sniper.Common;
using Sniper.Http;
using Sniper.TargetProcess.Routes;
using Xunit;

namespace Sniper.Tests.CRUD.Delete.Common.Features
{
    public class DeleteFeatureTests 
     {
        [Fact]
        public void DeleteFeatureWithoutNameThrowsError()
        {
            var client = new TargetProcessClient
            {
                ApiSiteInfo = new ApiSiteInfo(TargetProcessRoutes.Route.Features)
            };
            var feature = new Feature();
          
        }
    } 
} 
