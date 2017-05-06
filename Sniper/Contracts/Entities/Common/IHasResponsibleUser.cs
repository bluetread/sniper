using Sniper.Common;

namespace Sniper.Contracts.Entities.Common
{
    public interface IHasResponsibleUser
    {
        User Responsible { get; set; }
    }
}