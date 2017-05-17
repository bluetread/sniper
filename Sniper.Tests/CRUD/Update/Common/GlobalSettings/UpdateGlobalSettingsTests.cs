using Sniper.Http;
using Sniper.TargetProcess.Routes;
using Xunit;

namespace Sniper.Tests.CRUD.Update.Common.GlobalSettings
{
    public class UpdateGlobalSettingsTests
    { 
        [Fact] 
        public void GlobalSettingsThrowsError() 
        { 
            var client = new TargetProcessClient 
            { 
                ApiSiteInfo = new ApiSiteInfo(TargetProcessRoutes.Route.GlobalSettings) 
            }; 
            var globalSettings = new Sniper.Common.GlobalSettings 
            { 
            }; 
        } 
    } 
} 
