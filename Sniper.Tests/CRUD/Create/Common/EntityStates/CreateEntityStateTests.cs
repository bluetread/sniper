using Sniper.Common;
using Sniper.Http;
using Sniper.TargetProcess.Routes;
using Xunit;

namespace Sniper.Tests.CRUD.Create.Common.EntityStates 
{ 
    public class EntityStateTests 
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
