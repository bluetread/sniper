using Sniper.Common;
using Sniper.Http;
using Sniper.TargetProcess.Routes;
using Xunit;

namespace Sniper.Tests.CRUD.Delete.Common.RevisionFiles
{
    public class DeleteRevisionFileTests 
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
