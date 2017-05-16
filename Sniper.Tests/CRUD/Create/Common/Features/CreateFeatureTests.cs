using System;
using Sniper.Common;
using Sniper.Http;
using Sniper.TargetProcess.Routes;
using Xunit;

namespace Sniper.Tests.CRUD.Create.Common.Features 
{ 
    public class FeatureTests 
     {
        [Fact]
        public void CreateFeatureWithoutNameThrowsError()
        {
            var client = new TargetProcessClient
            {
                ApiSiteInfo = new ApiSiteInfo(TargetProcessRoutes.Route.Features)
            };
            var feature = new Feature();
            var data = client.CreateData<Feature>(feature);

            Assert.NotNull(data);
            Assert.True(data.HttpResponse.IsError);
        }

        [Fact]
        public void CreateFeatureWithNameButNoProjectIdFails()
        {
            var client = new TargetProcessClient
            {
                ApiSiteInfo = new ApiSiteInfo(TargetProcessRoutes.Route.Features)
            };
            var feature = new Feature
            {
                Name = $"Sample Feature From Code - {DateTime.Now}"
            };
            var data = client.CreateData<Feature>(feature);

            Assert.NotNull(data);
            Assert.True(data.HttpResponse.IsError);
        }


         [Fact]
         public void CreateFeatureWithNameAndProjectIdSucceeds()
         {
             var client = new TargetProcessClient
             {
                 ApiSiteInfo = new ApiSiteInfo(TargetProcessRoutes.Route.Features)
             };
             var feature = new Feature
             {
                 Name = $"Sample Feature From Code - {DateTime.Now}",
                 Project = new Project { Id = 194 }
             };
             var data = client.CreateData<Feature>(feature);

             Assert.NotNull(data);
             Assert.False(data.HttpResponse.IsError);
         }
    } 
} 
