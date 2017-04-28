using Sniper.Common;
using Sniper.Http;

namespace Sniper
{
    public partial class TargetProcessClient
    {
        // GETs / Read
        public IApiResponse<Assignable> GetAssignables() => GetData<Assignable>();
        public IApiResponse<AssignedEffort> GetAssignedEfforts() => GetData<AssignedEffort>();
        public IApiResponse<Assignment> GetAssignments() => GetData<Assignment>();
        public IApiResponse<Attachment> GetAttachments() => GetData<Attachment>();
        public IApiResponse<Bug> GetBugs() => GetData<Bug>();
        public IApiResponse<Build> GetBuilds() => GetData<Build>();
        public IApiResponse<Company> GetCompanies() => GetData<Company>();
        public IApiResponse<Context> GetContext() => GetData<Context>();
        public IApiResponse<CustomActivity> GetCustomActivities() => GetData<CustomActivity>();
        public IApiResponse<CustomField> GetCustomFields() => GetData<CustomField>();
        public IApiResponse<CustomRule> GetCustomRules() => GetData<CustomRule>();
        public IApiResponse<EntityState> GetEntityStates() => GetData<EntityState>();
        public IApiResponse<EntityType> GetEntityTypes() => GetData<EntityType>();
        public IApiResponse<Epic> GetEpics() => GetData<Epic>();
        public IApiResponse<Feature> GetFeatures() => GetData<Feature>();
        public IApiResponse<General> GetGenerals() => GetData<General>();
        public IApiResponse<GeneralFollower> GetGeneralFollowers() => GetData<GeneralFollower>();
        public IApiResponse<GeneralUser> GetGeneralUsers() => GetData<GeneralUser>();
        public IApiResponse<GlobalSettings> GetGlobalSettings() => GetData<GlobalSettings>();
        public IApiResponse<Impediment> GetImpediments() => GetData<Impediment>();
        public IApiResponse<InboundAssignable> GetInboundAssignables() => GetData<InboundAssignable>();
        public IApiResponse<Iteration> GetIterations() => GetData<Iteration>();
        public IApiResponse<Message> GetMessages() => GetData<Message>();
        public IApiResponse<MessageUniqueId> GetMessageUniqueIds() => GetData<MessageUniqueId>();
        public IApiResponse<Milestone> GetMilestones() => GetData<Milestone>();
        public IApiResponse<OutboundAssignable> GetOutboundAssignables() => GetData<OutboundAssignable>();
        public IApiResponse<Priority> GetPriorities() => GetData<Priority>();
        public IApiResponse<Process> GetProcesses() => GetData<Process>();
        public IApiResponse<Program> GetPrograms() => GetData<Program>();
        public IApiResponse<Project> GetProjects() => GetData<Project>();
        public IApiResponse<ProjectAllocation> GetProjectAllocations() => GetData<ProjectAllocation>();
        public IApiResponse<ProjectMember> GetProjectMembers() => GetData<ProjectMember>();
        public IApiResponse<Relation> GetRelations() => GetData<Relation>();
        public IApiResponse<RelationType> GetRelationTypes() => GetData<RelationType>();
        public IApiResponse<Release> GetReleases() => GetData<Release>();
        public IApiResponse<ReleaseProject> GetReleaseProjects() => GetData<ReleaseProject>();
        public IApiResponse<Request> GetRequests() => GetData<Request>();
        public IApiResponse<Requester> GetRequesters() => GetData<Requester>();
        public IApiResponse<RequestType> GetRequestTypes() => GetData<RequestType>();
        public IApiResponse<Revision> GetRevisions() => GetData<Revision>();
        public IApiResponse<RevisionFile> GetRevisionFiles() => GetData<RevisionFile>();
        public IApiResponse<Role> GetRoles() => GetData<Role>();
        public IApiResponse<RoleEffort> GetRoleEfforts() => GetData<RoleEffort>();
        public IApiResponse<Severity> GetSeverities() => GetData<Severity>();
        public IApiResponse<Tag> GetTags() => GetData<Tag>();
        public IApiResponse<Task> GetTasks() => GetData<Task>();
        public IApiResponse<Team> GetTeams() => GetData<Team>();
        public IApiResponse<TeamAssignment> GetTeamAssignments() => GetData<TeamAssignment>();
        public IApiResponse<TeamIteration> GetTeamIterations() => GetData<TeamIteration>();
        public IApiResponse<TeamMember> GetTeamMembers() => GetData<TeamMember>();
        public IApiResponse<TeamProject> GetTeamProjects() => GetData<TeamProject>();
        public IApiResponse<TeamProjectAllocation> GetTeamProjectAllocations() => GetData<TeamProjectAllocation>();
        public IApiResponse<Term> GetTerms() => GetData<Term>();
        public IApiResponse<TestCase> GetTestCases() => GetData<TestCase>();
        public IApiResponse<TestCaseRun> GetTestCaseRuns() => GetData<TestCaseRun>();
        public IApiResponse<TestPlan> GetTestPlans() => GetData<TestPlan>();
        public IApiResponse<TestPlanRun> GetTestPlanRuns() => GetData<TestPlanRun>();
        public IApiResponse<TestRunItemHierarchyLink> GetTestRunItemHierarchyLinks() => GetData<TestRunItemHierarchyLink>();
        public IApiResponse<TestStep> GetTestSteps() => GetData<TestStep>();
        public IApiResponse<TestStepRun> GetTestStepRuns() => GetData<TestStepRun>();
        public IApiResponse<Time> GetTimes() => GetData<Time>();
        public IApiResponse<User> GetUsers() => GetData<User>();
        public IApiResponse<UserProjectAllocation> GetUserProjectAllocations() => GetData<UserProjectAllocation>();
        public IApiResponse<UserStory> GetUserStories() => GetData<UserStory>();
        public IApiResponse<Workflow> GetWorkflows() => GetData<Workflow>();
    }
}
