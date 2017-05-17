using Sniper.Common;
using Sniper.Http;
using Sniper.TargetProcess.Routes;
using Xunit;

namespace Sniper.Tests.CRUD.Read.Common.Revisions
{
    public class ReadRevisionTests
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
