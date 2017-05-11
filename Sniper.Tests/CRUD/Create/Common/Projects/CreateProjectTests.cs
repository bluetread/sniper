using Sniper.Common;
using Sniper.Http;
using Sniper.TargetProcess.Routes;
using Xunit;

namespace Sniper.Tests.CRUD.Create.Common.Projects 
{ 
    public class ProjectTests 
     { 
        [Fact] 
        public void ProjectThrowsError() 
        { 
            var client = new TargetProcessClient 
            { 
                ApiSiteInfo = new ApiSiteInfo(TargetProcessRoutes.Route.Projects) 
            }; 
            var project = new Project 
            { 
            }; 
        } 
    } 
} 
