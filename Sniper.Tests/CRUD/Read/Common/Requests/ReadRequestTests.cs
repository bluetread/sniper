using Sniper.Common;
using Sniper.Http;
using Sniper.TargetProcess.Routes;
using Xunit;

namespace Sniper.Tests.CRUD.Read.Common.Requests
{
    public class ReadRequestTests
    { 
        [Fact] 
        public void RequestThrowsError() 
        { 
            var client = new TargetProcessClient 
            { 
                ApiSiteInfo = new ApiSiteInfo(TargetProcessRoutes.Route.Requests) 
            }; 
            var request = new Request 
            { 
            }; 
        } 
    } 
} 
