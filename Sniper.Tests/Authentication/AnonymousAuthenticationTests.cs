﻿using System.Net;
using Sniper.Http;
using Sniper.TargetProcess.Routes;
using Xunit;

namespace Sniper.Tests.Authentication
{
    public class AnonymousAuthenticationTests
    {
        public class TheAuthenticateMethod
        {
            [Fact]
            public void AnonymousAuthenticatorReturnsError()
            {
                var client = new TargetProcessClient(new AnonymousAuthenticator())
                {
                    ApiSiteInfo = new ApiSiteInfo(TargetProcessRoutes.Route.UserStories, true)
                };
                var data = client.GetSiteData();
                var error = data.HttpResponse.IsError;
                Assert.True(error);
                Assert.True(data.HttpResponse.StatusCode == HttpStatusCode.Unauthorized);
            }
        }
    }
}