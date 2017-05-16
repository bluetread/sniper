using Sniper.Common;
using Sniper.Http;
using Sniper.TargetProcess.Routes;
using Xunit;

namespace Sniper.Tests.CRUD.Create.Common.Terms 
{ 
    public class TermTests 
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
