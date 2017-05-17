using Sniper.Common;
using Sniper.Http;
using Sniper.TargetProcess.Routes;
using Xunit;

namespace Sniper.Tests.CRUD.Update.Common.Terms
{
    public class UpdateTermTests
    { 
        [Fact] 
        public void TermThrowsError() 
        { 
            var client = new TargetProcessClient 
            { 
                ApiSiteInfo = new ApiSiteInfo(TargetProcessRoutes.Route.Terms) 
            }; 
            var term = new Term 
            { 
            }; 
        } 
    } 
} 
