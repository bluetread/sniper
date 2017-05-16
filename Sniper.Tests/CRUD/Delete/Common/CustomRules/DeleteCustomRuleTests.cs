using Sniper.Common;
using Sniper.Http;
using Sniper.TargetProcess.Routes;
using Xunit;

namespace Sniper.Tests.CRUD.Delete.Common.CustomRules
{
    public class DeleteCustomRuleTests 
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
