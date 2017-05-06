namespace Sniper.Contracts.Entities.Common
{
    public interface IHasCommonEntityCollections :
        IHasCommonCollections, IHasEpics, IHasFeatures, IHasRequests, IHasTestPlans
    { }
}