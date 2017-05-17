using Sniper.Common;
using Sniper.Http;
using Sniper.TargetProcess.Routes;
using Xunit;

namespace Sniper.Tests.CRUD.Delete.Common.EntityStates
{
    public class DeleteEntityStateTests 
     { 
        [Fact] 
        public void EntityStateThrowsError() 
        { 
            var client = new TargetProcessClient 
            { 
                ApiSiteInfo = new ApiSiteInfo(TargetProcessRoutes.Route.EntityStates) 
            }; 
            var entityState = new EntityState 
            { 
            }; 
        } 
    } 
} 
