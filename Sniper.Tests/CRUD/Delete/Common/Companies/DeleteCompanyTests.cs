using Sniper.Common;
using Sniper.Http;
using Sniper.TargetProcess.Routes;
using Xunit;

namespace Sniper.Tests.CRUD.Delete.Common.Companies
{
    public class DeleteCompanyTests 
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
