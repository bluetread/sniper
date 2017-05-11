using Sniper.Common;
using Sniper.Http;
using Sniper.TargetProcess.Routes;
using Xunit;

namespace Sniper.Tests.CRUD.Create.Common.RequestTypes 
{ 
    public class RequestTypeTests 
     { 
        [Fact] 
        public void RequestTypeThrowsError() 
        { 
            var client = new TargetProcessClient 
            { 
                ApiSiteInfo = new ApiSiteInfo(TargetProcessRoutes.Route.RequestTypes) 
            }; 
            var requestType = new RequestType 
            { 
            }; 
        } 
    } 
} 
