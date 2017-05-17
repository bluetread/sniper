using Sniper.Common;
using Sniper.Http;
using Sniper.TargetProcess.Routes;
using Xunit;

namespace Sniper.Tests.CRUD.Create.Common.OutboundAssignables
{
    public class CreateOutboundAssignableTests
    { 
        [Fact] 
        public void OutboundAssignableThrowsError() 
        { 
            var client = new TargetProcessClient 
            { 
                ApiSiteInfo = new ApiSiteInfo(TargetProcessRoutes.Route.OutboundAssignables) 
            }; 
            var outboundAssignable = new OutboundAssignable 
            { 
            }; 
        } 
    } 
} 