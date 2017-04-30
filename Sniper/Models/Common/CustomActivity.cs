using Sniper.Contracts;
using System;
using System.Collections.ObjectModel;

namespace Sniper.Common
{
    /// <summary>
    /// Special type of work you can track Time against.
    /// </summary>
    /// <remarks>
    /// See the <a href="https://md5.tpondemand.com/api/v1/CustomActivities/meta">API documentation - CustomActivity</a>
    /// </remarks>
    public class CustomActivity : IHasId, IHasName, IHasCreated, IHasEstimate, IHasProject, IHasTimes, IHasUser
    {
        public int Id { get; set; }
        public DateTime Created { get; set; }
        public decimal Estimate { get; set; }
        public string Name { get; set; }

        public Project Project { get; set; }
        public User User { get; set; }

        public Collection<Time> Times { get; set; }
    }
}