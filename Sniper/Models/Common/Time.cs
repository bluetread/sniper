using System;
using Sniper.Contracts;

namespace Sniper.Common
{
    public class Time : IHasId, IHasCreateDate, IHasDate, IHasDescription, IHasWorkEffort
    {
        public int Id { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime? EntryDate { get; set; }
        public string Description { get; set; }
        public decimal Remain { get; set; }
        public decimal Spent { get; set; }
        public bool IsEstimation { get; set; }
    }
}
