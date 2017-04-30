using Sniper.Common;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using static Sniper.TargetProcess.Common.Enumerations;
using static Sniper.TargetProcess.Resources.TargetProcessResources;
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
            {TargetProcessResource.Assignable, Assignables},
            {TargetProcessResource.AssignedEffort, AssignedEfforts},
            {TargetProcessResource.Assignment, Assignments},
            {TargetProcessResource.Attachment, Attachments},
            {TargetProcessResource.Bug, Bugs},
            {TargetProcessResource.Build, Builds},
            {TargetProcessResource.Company, Companies},
            {TargetProcessResource.Context, Route.Context}, //singular - Do not change
            {TargetProcessResource.CustomActivity, CustomActivities},
            {TargetProcessResource.CustomField, CustomFields},
            {TargetProcessResource.CustomRule, CustomRules},
            {TargetProcessResource.EntityState, EntityStates},
            {TargetProcessResource.EntityType, EntityTypes},
            {TargetProcessResource.Epic, Epics},
            {TargetProcessResource.Feature, Features},
            {TargetProcessResource.General, Generals},
            {TargetProcessResource.GeneralFollower, GeneralFollowers},
            {TargetProcessResource.GeneralUser, GeneralUsers},
            {TargetProcessResource.GlobalSettings, Route.GlobalSettings},
            {TargetProcessResource.Impediment, Impediments},
            {TargetProcessResource.InboundAssignable, InboundAssignables},
            {TargetProcessResource.Iteration, Iterations},
            {TargetProcessResource.Message, Messages},
            {TargetProcessResource.MessageUniqueId, MessageUniqueIds},
            {TargetProcessResource.Milestone, Milestones},
            {TargetProcessResource.OutboundAssignable, OutboundAssignables},
            {TargetProcessResource.Priority, Priorities},
            {TargetProcessResource.Process, Processes},
            {TargetProcessResource.Program, Programs},
            {TargetProcessResource.Project, Projects},
            {TargetProcessResource.ProjectAllocation, ProjectAllocations},
            {TargetProcessResource.ProjectMember, ProjectMembers},
            {TargetProcessResource.Relation, Relations},
            {TargetProcessResource.RelationType, RelationTypes},
            {TargetProcessResource.Release, Releases},
            {TargetProcessResource.ReleaseProject, ReleaseProjects},
            {TargetProcessResource.Request, Requests},
            {TargetProcessResource.Requester, Requesters},
            {TargetProcessResource.RequestType, RequestTypes},
            {TargetProcessResource.Revision, Revisions},
            {TargetProcessResource.RevisionFile, RevisionFiles},
            {TargetProcessResource.Role, Roles},
            {TargetProcessResource.RoleEffort, RoleEfforts},
            {TargetProcessResource.Severity, Severities},
            {TargetProcessResource.Tag, Tags},
            {TargetProcessResource.Task, Tasks},
            {TargetProcessResource.Team, Teams},
            {TargetProcessResource.TeamAssignment, TeamAssignments},
            {TargetProcessResource.TeamIteration, TeamIterations},
            {TargetProcessResource.TeamMember, TeamMembers},
            {TargetProcessResource.TeamProject, TeamProjects},
            {TargetProcessResource.TeamProjectAllocation, TeamProjectAllocations},
            {TargetProcessResource.Term, Terms},
            {TargetProcessResource.TestCase, TestCases},
            {TargetProcessResource.TestCaseRun, TestCaseRuns},
            {TargetProcessResource.TestPlan, TestPlans},
            {TargetProcessResource.TestPlanRun, TestPlanRuns},
            {TargetProcessResource.TestRunItemHierarchyLink, TestRunItemHierarchyLinks},
            {TargetProcessResource.TestStep, TestSteps},
            {TargetProcessResource.TestStepRun, TestStepRuns},
            {TargetProcessResource.Time, Times},
            {TargetProcessResource.User, Users},
            {TargetProcessResource.UserProjectAllocation, UserProjectAllocations},
            {TargetProcessResource.UserStory, UserStories},
            {TargetProcessResource.Workflow, Workflows}
        };

        [SuppressMessage(Categories.Security, MessageAttributes.DoNotDeclareReadOnlyMutableReferenceTypes)]
        public static readonly Dictionary<Type, Route> ResourceTypeRoutes = new Dictionary<Type, Route>
        {
            {typeof(Assignable), Assignables},
            {typeof(AssignedEffort), AssignedEfforts},
            {typeof(Assignment), Assignments},
            {typeof(Attachment), Attachments},
            {typeof(Bug), Bugs},
            {typeof(Build), Builds},
            {typeof(Company), Companies},
            {typeof(Context), Route.Context}, //singular - Do not change
            {typeof(CustomActivity), CustomActivities},
            {typeof(CustomField), CustomFields},
            {typeof(CustomRule), CustomRules},
            {typeof(EntityState), EntityStates},
            {typeof(EntityType), EntityTypes},
            {typeof(Epic), Epics},
            {typeof(Feature), Features},
            {typeof(General), Generals},
            {typeof(GeneralFollower), GeneralFollowers},
            {typeof(GeneralUser), GeneralUsers},
            {typeof(GlobalSettings), Route.GlobalSettings},
            {typeof(Impediment), Impediments},
            {typeof(InboundAssignable), InboundAssignables},
            {typeof(Iteration), Iterations},
            {typeof(Message), Messages},
            {typeof(MessageUniqueId), MessageUniqueIds},
            {typeof(Milestone), Milestones},
            {typeof(OutboundAssignable), OutboundAssignables},
            {typeof(Priority), Priorities},
            {typeof(Process), Processes},
            {typeof(Program), Programs},
            {typeof(Project), Projects},
            {typeof(ProjectAllocation), ProjectAllocations},
            {typeof(ProjectMember), ProjectMembers},
            {typeof(Relation), Relations},
            {typeof(RelationType), RelationTypes},
            {typeof(Release), Releases},
            {typeof(ReleaseProject), ReleaseProjects},
            {typeof(Request), Requests},
            {typeof(Requester), Requesters},
            {typeof(RequestType), RequestTypes},
            {typeof(Revision), Revisions},
            {typeof(RevisionFile), RevisionFiles},
            {typeof(Role), Roles},
            {typeof(RoleEffort), RoleEfforts},
            {typeof(Severity), Severities},
            {typeof(Tag), Tags},
            {typeof(Task), Tasks},
            {typeof(Team), Teams},
            {typeof(TeamAssignment), TeamAssignments},
            {typeof(TeamIteration), TeamIterations},
            {typeof(TeamMember), TeamMembers},
            {typeof(TeamProject), TeamProjects},
            {typeof(TeamProjectAllocation), TeamProjectAllocations},
            {typeof(Term), Terms},
            {typeof(TestCase), TestCases},
            {typeof(TestCaseRun), TestCaseRuns},
            {typeof(TestPlan), TestPlans},
            {typeof(TestPlanRun), TestPlanRuns},
            {typeof(TestRunItemHierarchyLink), TestRunItemHierarchyLinks},
            {typeof(TestStep), TestSteps},
            {typeof(TestStepRun), TestStepRuns},
            {typeof(Time), Times},
            {typeof(User), Users},
            {typeof(UserProjectAllocation), UserProjectAllocations},
            {typeof(UserStory), UserStories},
            {typeof(Workflow), Workflows}
        };
        [SuppressMessage(Categories.Security, MessageAttributes.DoNotDeclareReadOnlyMutableReferenceTypes)]
        public static readonly Dictionary<TargetProcessResource, HistoryRoute> ResourceHistoryRoutes = new Dictionary<TargetProcessResource, HistoryRoute>
        {
            {TargetProcessResource.Bug, BugSimpleHistories},
            {TargetProcessResource.Epic, EpicSimpleHistories},
            {TargetProcessResource.Feature, FeatureSimpleHistories},
            {TargetProcessResource.Impediment, ImpedimentSimpleHistories},
            {TargetProcessResource.Request, RequestSimpleHistories},
            {TargetProcessResource.Task, TaskSimpleHistories},
            {TargetProcessResource.UserStory, UserStorySimpleHistories}
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