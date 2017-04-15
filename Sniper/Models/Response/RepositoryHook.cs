using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;

namespace Sniper.Response
{
    [DebuggerDisplay("{DebuggerDisplay,nq}")]
    public class RepositoryHook
    {
        public RepositoryHook() { }

        public RepositoryHook(int id, string url, string testUrl, string pingUrl, DateTimeOffset createdAt, DateTimeOffset updatedAt, string name, IReadOnlyList<string> events, bool active, IReadOnlyDictionary<string, string> config)
        {
            Url = url;
            TestUrl = testUrl;
            PingUrl = pingUrl;
            CreatedAt = createdAt;
            UpdatedAt = updatedAt;
            Name = name;
            Events = events;
            Active = active;
            Config = config;
            Id = id;
        }

        public int Id { get; }

        public string Url { get; }

        [Parameter(Key = "test_url")]
        public string TestUrl { get; }

        [Parameter(Key = "ping_url")]
        public string PingUrl { get; }

        public DateTimeOffset CreatedAt { get; }

        public DateTimeOffset UpdatedAt { get; }

        public string Name { get; }

        public IReadOnlyList<string> Events { get; }

        public bool Active { get; }

        public IReadOnlyDictionary<string, string> Config { get; }

        internal string DebuggerDisplay
        {
            get
            {
                return string.Format(CultureInfo.InvariantCulture,
                    "Repository Hook: Name: {0} Url: {1}, Events: {2}", Name, Url, string.Join(", ", Events));
            }
        }
    }
}
