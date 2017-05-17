using Sniper.Common;
using Sniper.Http;
using Sniper.TargetProcess.Routes;
using Xunit;

namespace Sniper.Tests.CRUD.Delete.Common.Times
{
    public class DeleteTimeTests 
     { 
        [Fact] 
        public void TimeThrowsError() 
        { 
            var client = new TargetProcessClient 
            { 
                ApiSiteInfo = new ApiSiteInfo(TargetProcessRoutes.Route.Times) 
            }; 
            var time = new Time 
            { 
            }; 
        }

        //TODO: Add logic to class to require data (at least user id and project id or story id?)
         [Fact]
         public void DeleteTimeWithMinimumFieldsSucceeds()
         {
             var client = new TargetProcessClient
             {
                 ApiSiteInfo = new ApiSiteInfo(TargetProcessRoutes.Route.Times)
             };

             var time = new Time();
        
         }
    } 
} 
