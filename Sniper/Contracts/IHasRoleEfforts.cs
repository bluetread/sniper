﻿using Sniper.Common;
using System.Collections.ObjectModel;

namespace Sniper.Contracts
{
    public interface IHasRoleEfforts
    {
        Collection<RoleEffort> RoleEfforts { get; set; }
    }
}