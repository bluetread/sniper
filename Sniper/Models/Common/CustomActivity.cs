using Sniper.Application;
using Sniper.Contracts.Entities.Common;
using System;
using System.Collections.ObjectModel;
using static Sniper.CustomAttributes.CustomAttributes;

namespace Sniper.Common
{
    /// <summary>
    /// Special type of work you can track Time against.
    /// </summary>
    /// <remarks>
    /// See the <a href="https://md5.tpondemand.com/api/v1/CustomActivities/meta">API documentation - CustomActivity</a>
    /// </remarks>
    public class CustomActivity : Entity, IHasName, IHasCreated, IHasEstimate, IHasProject, IHasTimes, IHasUser
    {
        public DateTime Created { get; set; }
        public decimal Estimate { get; set; }

        #region Required for Create

        [RequiredForCreate]
        public string Name { get; set; }

        [RequiredForCreate(JsonProperties.Id)]
        public Project Project { get; set; }

        #endregion

        public User User { get; set; }

        public Collection<Time> Times { get; set; }
    }
}