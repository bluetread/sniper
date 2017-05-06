using Sniper.Common;

namespace Sniper.Contracts.Entities.Common
{
    public interface IHasTestCase
    {
        TestCase TestCase { get; set; }
    }
}