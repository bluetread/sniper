using System;
using System.Diagnostics;
using System.Globalization;

namespace Sniper.Response.Enterprise
{
    [DebuggerDisplay("{DebuggerDisplay,nq}")]
    public class AdminStatsMilestones
    {
        public AdminStatsMilestones() { }

        public AdminStatsMilestones(int totalMilestones, int openMilestones, int closedMilestones)
        {
            TotalMilestones = totalMilestones;
            OpenMilestones = openMilestones;
            ClosedMilestones = closedMilestones;
        }

        public int TotalMilestones
        {
            get;
        }

        public int OpenMilestones
        {
            get;
        }

        public int ClosedMilestones
        {
            get;
        }

        internal string DebuggerDisplay
        {
            get
            {
                return String.Format(CultureInfo.InvariantCulture, "TotalMilestones: {0} OpenMilestones: {1} ClosedMilestones: {2}", TotalMilestones, OpenMilestones, ClosedMilestones);
            }
        }
    }
}