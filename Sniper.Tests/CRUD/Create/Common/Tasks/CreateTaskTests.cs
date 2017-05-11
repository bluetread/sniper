using Sniper.Common;
using Sniper.Http;
using Sniper.TargetProcess.Routes;
using Xunit;

namespace Sniper.Tests.CRUD.Create.Common.Tasks 
{ 
    public class TaskTests 
     { 
        [Fact] 
        public void TaskThrowsError() 
        { 
            var client = new TargetProcessClient 
            { 
                ApiSiteInfo = new ApiSiteInfo(TargetProcessRoutes.Route.Tasks) 
            }; 
            var task = new Task 
            { 
            }; 
        } 
    } 
} 
