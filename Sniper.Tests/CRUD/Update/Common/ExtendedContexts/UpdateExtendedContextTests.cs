using Sniper.Common;
using Sniper.Http;
using Sniper.TargetProcess.Routes;
using Xunit;

namespace Sniper.Tests.CRUD.Update.Common.ExtendedContexts
{
    public class UpdateExtendedContextTests
    { 
        [Fact] 
        public void ExtendedContextThrowsError() 
        { 
            var client = new TargetProcessClient 
            { 
                ApiSiteInfo = new ApiSiteInfo(TargetProcessRoutes.Route.ExtendedContexts) 
            }; 
            var extendedContext = new ExtendedContext 
            { 
            }; 
        } 
    } 
} 
