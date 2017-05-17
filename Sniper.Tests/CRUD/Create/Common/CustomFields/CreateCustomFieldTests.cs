using Sniper.Common;
using Sniper.Http;
using Sniper.TargetProcess.Routes;
using Xunit;

namespace Sniper.Tests.CRUD.Create.Common.CustomFields
{
    public class CreateCustomFieldTests
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