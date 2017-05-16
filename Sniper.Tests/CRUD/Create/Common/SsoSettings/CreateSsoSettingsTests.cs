using Sniper.Common;
using Sniper.Http;
using Sniper.TargetProcess.Routes;
using Xunit;

namespace Sniper.Tests.CRUD.Create.Common.SsoSettings 
{ 
    public class SsoSettingsTests 
     { 
        [Fact] 
        public void SsoSettingsThrowsError() 
        { 
            var client = new TargetProcessClient 
            { 
                ApiSiteInfo = new ApiSiteInfo(TargetProcessRoutes.Route.SsoSettings) 
            }; 
            var ssoSettings = new Sniper.Common.SsoSettings 
            { 
            }; 
        } 
    } 
} 
