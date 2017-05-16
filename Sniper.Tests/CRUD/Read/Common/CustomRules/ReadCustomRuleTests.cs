using Sniper.Common;
using Sniper.Http;
using Sniper.TargetProcess.Routes;
using Xunit;

namespace Sniper.Tests.CRUD.Read.Common.CustomRules
{
    public class ReadCustomRuleTests
    { 
        [Fact] 
        public void CustomRuleThrowsError() 
        { 
            var client = new TargetProcessClient 
            { 
                ApiSiteInfo = new ApiSiteInfo(TargetProcessRoutes.Route.CustomRules) 
            }; 
            var customRule = new CustomRule 
            { 
            }; 
        } 
    } 
} 
