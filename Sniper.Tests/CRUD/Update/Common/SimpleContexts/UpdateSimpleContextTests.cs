using Sniper.Common;
using Sniper.Http;
using Sniper.TargetProcess.Routes;
using Xunit;

namespace Sniper.Tests.CRUD.Update.Common.SimpleContexts
{
    public class UpdateSimpleContextTests
    { 
        [Fact] 
        public void SimpleContextThrowsError() 
        { 
            var client = new TargetProcessClient 
            { 
                ApiSiteInfo = new ApiSiteInfo(TargetProcessRoutes.Route.SimpleContexts) 
            }; 
            var simpleContext = new SimpleContext 
            { 
            }; 
        } 
    } 
} 
