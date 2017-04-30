using Sniper.Common;
using System.Collections.ObjectModel;

namespace Sniper.Contracts
{
    public interface IHasCustomFields
    {
        Collection<CustomField> CustomFields { get; set; }
    }
}