using Sniper.Common;
using Sniper.Http;
using Sniper.TargetProcess.Routes;
using Xunit;

namespace Sniper.Tests.CRUD.Delete.Common.Programs
{
    public class DeleteProgramTests 
     { 
        [Fact] 
        public void ProgramThrowsError() 
        { 
            var client = new TargetProcessClient 
            { 
                ApiSiteInfo = new ApiSiteInfo(TargetProcessRoutes.Route.Programs) 
            }; 
            var program = new Program 
            { 
            }; 
        } 
    } 
} 
