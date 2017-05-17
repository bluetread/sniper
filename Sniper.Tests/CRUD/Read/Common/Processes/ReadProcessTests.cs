using Sniper.Common;
using Sniper.Http;
using Sniper.TargetProcess.Routes;
using Xunit;

namespace Sniper.Tests.CRUD.Read.Common.Processes
{
    public class ReadProcessTests
    { 
        [Fact] 
        public void ProcessThrowsError() 
        { 
            var client = new TargetProcessClient 
            { 
                ApiSiteInfo = new ApiSiteInfo(TargetProcessRoutes.Route.Processes) 
            }; 
            var process = new Process 
            { 
            }; 
        } 
    } 
} 
