using System.Diagnostics.CodeAnalysis;
using static Sniper.WarningsErrors.MessageSuppression;

namespace Sniper.Contracts
{
    [SuppressMessage(Categories.Naming, MessageAttributes.CompoundWordsShouldBeCasedCorrectly)]
    public interface IHasId
    {
        int Id { get; set; }
    }
}
