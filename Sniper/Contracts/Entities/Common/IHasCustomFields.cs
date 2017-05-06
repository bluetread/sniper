using Sniper.Common;
using System.Collections.ObjectModel;

namespace Sniper.Contracts.Entities.Common
{
    public interface IHasCustomFields
    {
        Collection<CustomField> CustomFields { get; set; }
    }
}