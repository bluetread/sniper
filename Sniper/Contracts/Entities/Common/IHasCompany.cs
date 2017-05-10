using Sniper.Common;

namespace Sniper.Contracts.Entities.Common
{
    public interface IHasCompany
    {
        Company Company { get; set; }
    }
}