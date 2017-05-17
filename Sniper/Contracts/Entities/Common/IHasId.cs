using Sniper.WarningsErrors;
using System.Diagnostics.CodeAnalysis;

namespace Sniper.Contracts.Entities.Common
{
    [SuppressMessage(MessageSuppression.Categories.Naming, MessageSuppression.MessageAttributes.CompoundWordsShouldBeCasedCorrectly)]
    public interface IHasId
    {
        int? Id { get; set; }
    }
}