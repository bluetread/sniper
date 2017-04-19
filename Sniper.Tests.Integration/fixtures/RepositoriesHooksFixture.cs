﻿using System;
using System.Collections.Generic;

namespace Sniper.Tests.Integration.fixtures
{
    public class RepositoriesHooksFixture : IDisposable
    {
        private readonly IGitHubClient _github;
        private readonly Repository _repository;
        private readonly RepositoryHook _hook;
        private readonly IList<RepositoryHook> _hooks;

        public RepositoriesHooksFixture()
        {
            _github = Helper.GetAuthenticatedClient();
            _repository = CreateRepository(_github);
            _hooks = new List<RepositoryHook>(5)
            {
                CreateHook(_github, _repository, "awscodedeploy", "deployment"),
                CreateHook(_github, _repository, "awsopsworks", "push"),
                CreateHook(_github, _repository, "activecollab", "push"),
                CreateHook(_github, _repository, "acunote", "push"),
                CreateHook(_github, _repository, "agilezen", "push")
            };
            _hook = _hooks[0];
        }

        public string RepositoryOwner { get { return _repository.Owner.Login; } }

        public string RepositoryName { get { return _repository.Name; } }

        public long RepositoryId { get { return _repository.Id; } }

        public RepositoryHook ExpectedHook { get { return _hook; } }

        public IList<RepositoryHook> ExpectedHooks { get { return _hooks; } }

        public void Dispose()
        {
            _github.Repository.Delete(_repository.Owner.Login, _repository.Name);
        }

        private static Repository CreateRepository(IGitHubClient github)
        {
            var repoName = Helper.MakeNameWithTimestamp("create-hooks-test");
            var repository = github.Repository.Create(new NewRepository(repoName) { AutoInit = true });

            return repository.Result;
        }

        private static RepositoryHook CreateHook(IGitHubClient github, Repository repository, string hookName, string eventName)
        {
            var config = new Dictionary<string, string> { { "content_type", "json" }, { "url", "http://test.com/example" } };
            var parameters = new NewRepositoryHook(hookName, config)
            {
                Events = new[] { eventName },
                Active = false
            };
            var createdHook = github.Repository.Hooks.Create(Helper.UserName, repository.Name, parameters);

            return createdHook.Result;
        }
    }
}
