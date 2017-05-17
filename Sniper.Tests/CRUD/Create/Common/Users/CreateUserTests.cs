using Sniper.Common;
using Sniper.Http;
using Sniper.TargetProcess.Routes;
using Xunit;

namespace Sniper.Tests.CRUD.Create.Common.Users
{
    public class CreateUserTests
    { 
        [Fact] 
        public void UserThrowsError() 
        { 
            var client = new TargetProcessClient 
            { 
                ApiSiteInfo = new ApiSiteInfo(TargetProcessRoutes.Route.Users) 
            }; 
            var user = new User 
            { 
            }; 
        } 
    } 
} 
