using Sniper.Common;
using Sniper.Http;
using Sniper.TargetProcess.Routes;
using Xunit;

namespace Sniper.Tests.CRUD.Delete.Common.Generals
{
    public class DeleteGeneralTests 
     { 
        [Fact] 
        public void GeneralThrowsError() 
        { 
            var client = new TargetProcessClient 
            { 
                ApiSiteInfo = new ApiSiteInfo(TargetProcessRoutes.Route.Generals) 
            }; 
            var general = new General 
            { 
            }; 
        } 
    } 
} 
