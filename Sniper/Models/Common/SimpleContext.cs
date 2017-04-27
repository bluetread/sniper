using Sniper.Contracts;

namespace Sniper.Common
{
    public class SimpleContext : IHasId
    {
        public int Id { get; set; }
        public bool No { get; set; }
    }
}