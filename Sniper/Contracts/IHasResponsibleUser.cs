using Sniper.Common;

namespace Sniper.Contracts
{
    public interface IHasResponsibleUser
    {
        User Responsible { get; set; }
    }
}
