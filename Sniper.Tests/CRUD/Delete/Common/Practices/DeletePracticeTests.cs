using Sniper.Common;
using Sniper.Http;
using Sniper.TargetProcess.Routes;
using Xunit;

namespace Sniper.Tests.CRUD.Delete.Common.Practices
{
    public class DeletePracticeTests 
     { 
        [Fact] 
        public void PracticeThrowsError() 
        { 
            var client = new TargetProcessClient 
            { 
                ApiSiteInfo = new ApiSiteInfo(TargetProcessRoutes.Route.Practices) 
            }; 
            var practice = new Practice 
            { 
            }; 
        } 
    } 
} 
