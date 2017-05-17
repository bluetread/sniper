using Sniper.Common;
using Sniper.Http;
using Sniper.TargetProcess.Routes;
using Xunit;

namespace Sniper.Tests.CRUD.Read.Common.RevisionFiles
{
    public class ReadRevisionFileTests
    { 
        [Fact] 
        public void RevisionFileThrowsError() 
        { 
            var client = new TargetProcessClient 
            { 
                ApiSiteInfo = new ApiSiteInfo(TargetProcessRoutes.Route.RevisionFiles) 
            }; 
            var revisionFile = new RevisionFile 
            { 
            }; 
        } 
    } 
} 
