using Sniper.Common;
using Sniper.Http;
using Sniper.TargetProcess.Routes;
using Xunit;

namespace Sniper.Tests.CRUD.Read.Common.CustomFields
{
    public class ReadCustomFieldTests
    { 
        [Fact] 
        public void CustomFieldThrowsError() 
        { 
            var client = new TargetProcessClient 
            { 
                ApiSiteInfo = new ApiSiteInfo(TargetProcessRoutes.Route.CustomFields) 
            }; 
            var customField = new CustomField 
            { 
            }; 
        } 
    } 
} 
