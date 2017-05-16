using Sniper.Common;
using Sniper.Http;
using Sniper.TargetProcess.Routes;
using Xunit;

namespace Sniper.Tests.CRUD.Delete.Common.EntityTypes
{
    public class DeleteEntityTypeTests 
     { 
        [Fact] 
        public void EntityTypeThrowsError() 
        { 
            var client = new TargetProcessClient 
            { 
                ApiSiteInfo = new ApiSiteInfo(TargetProcessRoutes.Route.EntityTypes) 
            }; 
            var entityType = new EntityType 
            { 
            }; 
        } 
    } 
} 
