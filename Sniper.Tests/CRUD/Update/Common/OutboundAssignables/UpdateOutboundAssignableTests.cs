using Sniper.Common;
using Sniper.Http;
using Sniper.TargetProcess.Routes;
using Xunit;

namespace Sniper.Tests.CRUD.Update.Common.OutboundAssignables
{
    public class UpdateOutboundAssignableTests
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
