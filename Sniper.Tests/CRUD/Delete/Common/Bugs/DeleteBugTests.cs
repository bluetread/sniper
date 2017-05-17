using Sniper.Common;
using Sniper.Http;
using Sniper.TargetProcess.Routes;
using Xunit;

namespace Sniper.Tests.CRUD.Delete.Common.Bugs
{
    public class DeleteBugTests 
     { 
        [Fact] 
        public void DeleteBugThrowsError() 
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
