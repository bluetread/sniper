using Sniper.Common;
using Sniper.TargetProcess.Routes;
using Xunit;

namespace Sniper.Tests.CRUD.Create.Common.Comments
{
    public class CreateCommentTests
    {
        [Fact]
        public void CommentThrowsError()
        {
            var client = CommonMethods.GetClientByRoute(TargetProcessRoutes.Route.Comments);

            var comment = new Comment();
        }
    }
}
