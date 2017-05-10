using Sniper.Common;
using System.Collections.ObjectModel;

namespace Sniper.Contracts.Entities.Common
{
    public interface IHasRevisionFiles
    {
        Collection<RevisionFile> RevisionFiles { get; }
    }
}