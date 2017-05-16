using Sniper.Common;
using Sniper.Http;
using Sniper.TargetProcess.Routes;
using Xunit;

namespace Sniper.Tests.CRUD.Read.Common.MessageUniqueIds
{
    public class ReadMessageUniqueIdTests
    { 
        [Fact] 
        public void MessageUniqueIdThrowsError() 
        { 
            var client = new TargetProcessClient 
            { 
                ApiSiteInfo = new ApiSiteInfo(TargetProcessRoutes.Route.MessageUniqueIds) 
            }; 
            var messageUniqueId = new MessageUniqueId 
            { 
            }; 
        } 
    } 
} 
