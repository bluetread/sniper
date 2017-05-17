using Sniper.Common;
using Sniper.Http;
using Sniper.TargetProcess.Routes;
using Xunit;

namespace Sniper.Tests.CRUD.Create.Common.InboundAssignables
{
    public class CreateInboundAssignableTests
    { 
        [Fact] 
        public void InboundAssignableThrowsError() 
        { 
            var client = new TargetProcessClient 
            { 
                ApiSiteInfo = new ApiSiteInfo(TargetProcessRoutes.Route.InboundAssignables) 
            }; 
            var inboundAssignable = new InboundAssignable 
            { 
            }; 
        } 
    } 
} 
