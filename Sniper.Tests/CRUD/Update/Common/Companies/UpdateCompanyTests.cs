using Sniper.Common;
using Sniper.Http;
using Sniper.TargetProcess.Routes;
using Xunit;

namespace Sniper.Tests.CRUD.Update.Common.Companies
{
    public class UpdateCompanyTests
    { 
        [Fact] 
        public void CompanyThrowsError() 
        { 
            var client = new TargetProcessClient 
            { 
                ApiSiteInfo = new ApiSiteInfo(TargetProcessRoutes.Route.Companies) 
            }; 
            var company = new Company 
            { 
            }; 
        } 
    } 
} 
