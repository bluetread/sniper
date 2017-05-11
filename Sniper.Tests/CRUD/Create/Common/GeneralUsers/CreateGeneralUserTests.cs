using Sniper.Common;
using Sniper.Http;
using Sniper.TargetProcess.Routes;
using Xunit;

namespace Sniper.Tests.CRUD.Create.Common.GeneralUsers 
{ 
    public class GeneralUserTests 
     { 
        [Fact] 
        public void GeneralUserThrowsError() 
        { 
            var client = new TargetProcessClient 
            { 
                ApiSiteInfo = new ApiSiteInfo(TargetProcessRoutes.Route.GeneralUsers) 
            }; 
            var generalUser = new GeneralUser 
            { 
            }; 
        } 
    } 
} 
