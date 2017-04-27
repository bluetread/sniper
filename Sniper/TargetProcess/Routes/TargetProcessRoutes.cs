using System.Diagnostics.CodeAnalysis;
using static Sniper.WarningsErrors.MessageSuppression;

namespace Sniper.TargetProcess.Routes
{
    public static class TargetProcessRoutes
    {
        public enum Route
        {
            None = 0,

            [SuppressMessage(Categories.Naming, MessageAttributes.IdentifiersShouldBeSpelledCorrectly)]
            Assignables,

            AssignedEfforts,
            Assignments,
            Attachments,
            Bugs,
            Builds,
            Companies,
            Context, //singular - Do not change
            CustomActivities,
            CustomFields,
            CustomRules,
            EntityStates,
            EntityTypes,
            Epics,
            ExtendedContexts, //TODO: link is bad. Need to verify
            Features,
            Generals,
            GeneralFollowers,
            GeneralUsers,
            GlobalSettings,
            Impediments,

            [SuppressMessage(Categories.Naming, MessageAttributes.IdentifiersShouldBeSpelledCorrectly)]
            InboundAssignables,

            Iterations,
            Messages,
            MessageUniqueIds,
            Milestones,

            [SuppressMessage(Categories.Naming, MessageAttributes.IdentifiersShouldBeSpelledCorrectly)]
            OutboundAssignables,

            Priorities,
            Processes,
            Programs,
            Projects,
            ProjectAllocations,
            ProjectMembers,
            Relations,
            RelationTypes,
            Releases,
            ReleaseProjects,
            Requests,
            Requesters,
            RequestTypes,
            Revisions,
            RevisionFiles,
            Roles,
            RoleEfforts,
            Severities,
            Tags,
            Tasks,
            Teams,
            TeamAssignments,
            TeamIterations,
            TeamMembers,
            TeamProjects,
            TeamProjectAllocations,
            Terms,
            TestCases,
            TestCaseRuns,
            TestPlans,
            TestPlanRuns,
            TestRunItemHierarchyLinks,
            TestSteps,
            TestStepRuns,
            Times,
            Users,
            UserProjectAllocations,
            UserStories,
            Workflows
        }
    }
}