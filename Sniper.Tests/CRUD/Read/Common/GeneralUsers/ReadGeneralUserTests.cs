using Sniper.Common;
using Sniper.Http;
using Sniper.TargetProcess.Routes;
using Xunit;

namespace Sniper.Tests.CRUD.Read.Common.GeneralUsers
{
    public class ReadGeneralUserTests
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
