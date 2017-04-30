using System.Collections.ObjectModel;
using Sniper.Common;

namespace Sniper.Contracts
{
    public interface IHasRevisionFiles
    {
        Collection<RevisionFile> RevisionFiles { get; set; }
    }
}
