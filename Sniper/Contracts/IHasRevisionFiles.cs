using Sniper.Common;
using System.Collections.ObjectModel;

namespace Sniper.Contracts
{
    public interface IHasRevisionFiles
    {
        Collection<RevisionFile> RevisionFiles { get; set; }
    }
}
