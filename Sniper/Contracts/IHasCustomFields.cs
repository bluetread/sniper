using System.Collections.ObjectModel;
using Sniper.Common;

namespace Sniper.Contracts
{
    public interface IHasCustomFields
    {
        Collection<CustomField> CustomFields { get; set; }
    }
}
