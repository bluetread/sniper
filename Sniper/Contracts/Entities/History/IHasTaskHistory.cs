﻿using Sniper.History;
using System.Collections.ObjectModel;

namespace Sniper.Contracts.Entities.History
{
    public interface IHasTaskHistory
    {
        Collection<TaskSimpleHistory> History { get; }
    }
}