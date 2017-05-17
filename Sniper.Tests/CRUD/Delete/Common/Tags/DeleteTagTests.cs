using Sniper.Common;
using Sniper.Http;
using Sniper.TargetProcess.Routes;
using Xunit;

namespace Sniper.Tests.CRUD.Delete.Common.Tags
{
    public class DeleteTagTests 
     { 
        [Fact] 
        public void TagThrowsError() 
        { 
            var client = new TargetProcessClient 
            { 
                ApiSiteInfo = new ApiSiteInfo(TargetProcessRoutes.Route.Tags) 
            }; 
            var tag = new Tag 
            { 
            }; 
        } 
    } 
} 
