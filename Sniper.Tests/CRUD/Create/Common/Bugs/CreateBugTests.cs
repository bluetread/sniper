using Sniper.Common;
using Sniper.Http;
using Sniper.TargetProcess.Routes;
using Xunit;

namespace Sniper.Tests.CRUD.Create.Common.Bugs 
{ 
    public class BugTests 
     { 
        [Fact] 
        public void BugThrowsError() 
        { 
            var client = new TargetProcessClient 
            { 
                ApiSiteInfo = new ApiSiteInfo(TargetProcessRoutes.Route.Bugs) 
            }; 
            var bug = new Bug 
            { 
            }; 
        } 
    } 
} 
