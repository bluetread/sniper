using Sniper.Common;
using Sniper.Http;
using Sniper.TargetProcess.Routes;
using Xunit;

namespace Sniper.Tests.CRUD.Create.Common.Relations 
{ 
    public class RelationTests 
     { 
        [Fact] 
        public void RelationThrowsError() 
        { 
            var client = new TargetProcessClient 
            { 
                ApiSiteInfo = new ApiSiteInfo(TargetProcessRoutes.Route.Relations) 
            }; 
            var relation = new Relation 
            { 
            }; 
        } 
    } 
} 
