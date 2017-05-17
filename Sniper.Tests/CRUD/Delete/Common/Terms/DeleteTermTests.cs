using Sniper.Common;
using Sniper.Http;
using Sniper.TargetProcess.Routes;
using Xunit;

namespace Sniper.Tests.CRUD.Delete.Common.Terms
{
    public class DeleteTermTests 
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
