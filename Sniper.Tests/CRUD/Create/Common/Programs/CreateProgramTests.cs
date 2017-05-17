using Sniper.Common;
using Sniper.Http;
using Sniper.TargetProcess.Routes;
using Xunit;

namespace Sniper.Tests.CRUD.Create.Common.Programs
{
    public class CreateProgramTests
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
