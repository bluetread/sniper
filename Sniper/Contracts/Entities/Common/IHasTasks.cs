﻿using Sniper.Common;
using System.Collections.ObjectModel;

namespace Sniper.Contracts.Entities.Common
{
    public interface IHasTasks
    {
        Collection<Task> Tasks { get; }
    }
}