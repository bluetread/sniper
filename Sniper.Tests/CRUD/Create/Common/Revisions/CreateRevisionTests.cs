using Sniper.Common;
using Sniper.Http;
using Sniper.TargetProcess.Routes;
using Xunit;

namespace Sniper.Tests.CRUD.Create.Common.Revisions 
{ 
    public class RevisionTests 
     { 
        [Fact] 
        public void RevisionThrowsError() 
        { 
            var client = new TargetProcessClient 
            { 
                ApiSiteInfo = new ApiSiteInfo(TargetProcessRoutes.Route.Revisions) 
            }; 
            var revision = new Revision 
            { 
            }; 
        } 
    } 
} 
