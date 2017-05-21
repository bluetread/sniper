using Sniper.Common;
using Sniper.Http;
using System;

namespace Sniper.Tests.CRUD.Create
{
    public static class CreateCommonMethods
    {
        public static IApiResponse<Project> GetNewProject(ITargetProcessClient client)
        {
            var project = new Project { Name = $"Sample Project From Code - {DateTime.Now}" };
            var data = client.CreateData<Project>(project);
            return data;
        }
    }
}
