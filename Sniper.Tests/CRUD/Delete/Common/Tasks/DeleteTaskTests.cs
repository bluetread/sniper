using Sniper.Common;
using Sniper.Http;
using Sniper.TargetProcess.Routes;
using Xunit;

namespace Sniper.Tests.CRUD.Delete.Common.Tasks
{
    public class DeleteTaskTests 
     { 
        [Fact] 
        public void DeleteTaskThrowsError() 
        { 
            var client = new TargetProcessClient 
            { 
                ApiSiteInfo = new ApiSiteInfo(TargetProcessRoutes.Route.Tasks) 
            }; 
            var task = new Task();
        }
    } 
} 
