using Sniper.Common;
using Sniper.Http;
using Sniper.TargetProcess.Routes;
using Xunit;

namespace Sniper.Tests.CRUD.Update.Common.Comments
{
    public class UpdateCommentTests
    { 
        [Fact] 
        public void CommentThrowsError() 
        { 
            var client = new TargetProcessClient 
            { 
                ApiSiteInfo = new ApiSiteInfo(TargetProcessRoutes.Route.Comments) 
            }; 
            var comment = new Comment 
            { 
            }; 
        } 
    } 
} 
