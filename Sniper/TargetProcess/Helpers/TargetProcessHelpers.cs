using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using static Sniper.TargetProcess.Enumerations;
using static Sniper.TargetProcess.Resources.TargetProcessResources;
using static Sniper.TargetProcess.Resources.TargetProcessResources.TargetProcessResource;
using static Sniper.TargetProcess.Routes.TargetProcessHistoryRoutes;
using static Sniper.TargetProcess.Routes.TargetProcessHistoryRoutes.HistoryRoute;
using static Sniper.TargetProcess.Routes.TargetProcessRoutes;
using static Sniper.TargetProcess.Routes.TargetProcessRoutes.Route;
using static Sniper.WarningsErrors.MessageSuppression;

namespace Sniper.TargetProcess.Helpers
{
    public static class TargetProcessHelpers
    {
        // List of resources and routes. Example: https://md5.tpondemand.com/api/v1/Assignables
        [SuppressMessage(Categories.Security, MessageAttributes.DoNotDeclareReadOnlyMutableReferenceTypes)]
        public static readonly Dictionary<Aggregate, string> AggregateOptions = new Dictionary<Aggregate, string>
        {
            { Aggregate.Average, Aggregates.Average },
            { Aggregate.Count, Aggregates.Count },
            { Aggregate.Maximum, Aggregates.Maximum },
            { Aggregate.Minimum, Aggregates.Minimum },
            { Aggregate.Sum, Aggregates.Sum }
        };

        [SuppressMessage(Categories.Security, MessageAttributes.DoNotDeclareReadOnlyMutableReferenceTypes)]
        public static readonly Dictionary<DataFilter, string> DataFilterOptions = new Dictionary<DataFilter, string>
        {
            { DataFilter.Append, DataFilters.Append },
            { DataFilter.Exclude, DataFilters.Exclude },
            { DataFilter.Include, DataFilters.Include },
            { DataFilter.InnerTake, DataFilters.InnerTake },
            { DataFilter.Skip, DataFilters.Skip },
            { DataFilter.Take, DataFilters.Take },
            { DataFilter.Where, DataFilters.Where }
        };

        [SuppressMessage(Categories.Security, MessageAttributes.DoNotDeclareReadOnlyMutableReferenceTypes)]
        public static readonly Dictionary<FilterOperator, string> FilterOptions = new Dictionary<FilterOperator, string>
        {
            { FilterOperator.Contains, FilterOperators.Contains },
            { FilterOperator.Equality, FilterOperators.Equality },
            { FilterOperator.GreaterThan, FilterOperators.GreaterThan },
            { FilterOperator.GreaterThanOrEqual, FilterOperators.GreaterThanOrEqual },
            { FilterOperator.InList, FilterOperators.InList },
            { FilterOperator.IsNull, FilterOperators.IsNull },
            { FilterOperator.IsNotNull, FilterOperators.IsNotNull },
            { FilterOperator.LessThan, FilterOperators.LessThan },
            { FilterOperator.LessThanOrEqual, FilterOperators.LessThanOrEqual },
            { FilterOperator.NotEquality, FilterOperators.NotEquality }
        };

        [SuppressMessage(Categories.Security, MessageAttributes.DoNotDeclareReadOnlyMutableReferenceTypes)]
        public static readonly Dictionary<SortOrder, string> SortOptions = new Dictionary<SortOrder, string>()
        {
            { SortOrder.Ascending, SortOrders.Ascending },
            { SortOrder.Descending, SortOrders.Descending }
        };

        [SuppressMessage(Categories.Security, MessageAttributes.DoNotDeclareReadOnlyMutableReferenceTypes)]
        public static readonly Dictionary<TargetProcessResource, Route> ResourceRoutes = new Dictionary<TargetProcessResource, Route>
        {
            {Assignable, Assignables},
            {AssignedEffort, AssignedEfforts},
            {Assignment, Assignments},
            {Attachment, Attachments},
            {Bug, Bugs},
            {Build, Builds},
            {Company, Companies},
            {TargetProcessResource.Context, Route.Context}, //singular - Do not change
            {CustomActivity, CustomActivities},
            {CustomField, CustomFields},
            {CustomRule, CustomRules},
            {EntityState, EntityStates},
            {EntityType, EntityTypes},
            {Epic, Epics},
            {ExtendedContext, ExtendedContexts}, //TODO: link is bad. Need to verify
            {Feature, Features},
            {General, Generals},
            {GeneralFollower, GeneralFollowers},
            {GeneralUser, GeneralUsers},
            {TargetProcessResource.GlobalSettings, Route.GlobalSettings},
            {Impediment, Impediments},
            {InboundAssignable, InboundAssignables},
            {Iteration, Iterations},
            {Message, Messages},
            {MessageUniqueId, MessageUniqueIds},
            {Milestone, Milestones},
            {OutboundAssignable, OutboundAssignables},
            {Priority, Priorities},
            {Process, Processes},
            {Program, Programs},
            {Project, Projects},
            {ProjectAllocation, ProjectAllocations},
            {ProjectMember, ProjectMembers},
            {Relation, Relations},
            {RelationType, RelationTypes},
            {Release, Releases},
            {ReleaseProject, ReleaseProjects},
            {Request, Requests},
            {Requester, Requesters},
            {RequestType, RequestTypes},
            {Revision, Revisions},
            {RevisionFile, RevisionFiles},
            {Role, Roles},
            {RoleEffort, RoleEfforts},
            {Severity, Severities},
            {Tag, Tags},
            {Task, Tasks},
            {Team, Teams},
            {TeamAssignment, TeamAssignments},
            {TeamIteration, TeamIterations},
            {TeamMember, TeamMembers},
            {TeamProject, TeamProjects},
            {TeamProjectAllocation, TeamProjectAllocations},
            {Term, Terms},
            {TestCase, TestCases},
            {TestCaseRun, TestCaseRuns},
            {TestPlan, TestPlans},
            {TestPlanRun, TestPlanRuns},
            {TestRunItemHierarchyLink, TestRunItemHierarchyLinks},
            {TestStep, TestSteps},
            {TestStepRun, TestStepRuns},
            {Time, Times},
            {User, Users},
            {UserProjectAllocation, UserProjectAllocations},
            {UserStory, UserStories},
            {Workflow, Workflows}
        };

        [SuppressMessage(Categories.Security, MessageAttributes.DoNotDeclareReadOnlyMutableReferenceTypes)]
        public static readonly Dictionary<TargetProcessResource, HistoryRoute> ResourceHistoryRoutes = new Dictionary<TargetProcessResource, HistoryRoute>
        {
            {Bug, BugSimpleHistories},
            {Epic, EpicSimpleHistories},
            {Feature, FeatureSimpleHistories},
            {Impediment, ImpedimentSimpleHistories},
            {Request, RequestSimpleHistories},
            {Task, TaskSimpleHistories},
            {UserStory, UserStorySimpleHistories}
        };

        public static Route GetRouteByResource(TargetProcessResource resource)
        {
            Ensure.ArgumentNotNull(nameof(resource), resource);

            return ResourceRoutes.TryGetValue(resource, out Route result) ? result : Route.None;
        }

        public static HistoryRoute GetRouteHistoryByResource(TargetProcessResource resource)
        {
            Ensure.ArgumentNotNull(nameof(resource), resource);

            return ResourceHistoryRoutes.TryGetValue(resource, out HistoryRoute result) ? result : HistoryRoute.None;
        }

        public static string ToRouteString(this Route route)
        {
            return route == Route.None ? string.Empty : route.ToString();
        }

        public static string ToRouteString(this HistoryRoute route)
        {
            return route == HistoryRoute.None ? string.Empty : route.ToString();
        }
    }
}
