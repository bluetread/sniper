using Sniper.Common;
using Sniper.Http;
using System.Threading.Tasks;
using Task = Sniper.Common.Task;

namespace Sniper
{
    public partial class TargetProcessClient
    {
        #region GET/Read 

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

        #endregion

        #region GET / Read Async

        public Task<IApiResponse<Assignable>> GetAssignablesAsync() => GetDataAsync<Assignable>();
        public Task<IApiResponse<AssignedEffort>> GetAssignedEffortsAsync() => GetDataAsync<AssignedEffort>();
        public Task<IApiResponse<Assignment>> GetAssignmentsAsync() => GetDataAsync<Assignment>();
        public Task<IApiResponse<Attachment>> GetAttachmentsAsync() => GetDataAsync<Attachment>();
        public Task<IApiResponse<Bug>> GetBugsAsync() => GetDataAsync<Bug>();
        public Task<IApiResponse<Build>> GetBuildsAsync() => GetDataAsync<Build>();
        public Task<IApiResponse<Company>> GetCompaniesAsync() => GetDataAsync<Company>();
        public Task<IApiResponse<Context>> GetContextAsync() => GetDataAsync<Context>();
        public Task<IApiResponse<CustomActivity>> GetCustomActivitiesAsync() => GetDataAsync<CustomActivity>();
        public Task<IApiResponse<CustomField>> GetCustomFieldsAsync() => GetDataAsync<CustomField>();
        public Task<IApiResponse<CustomRule>> GetCustomRulesAsync() => GetDataAsync<CustomRule>();
        public Task<IApiResponse<EntityState>> GetEntityStatesAsync() => GetDataAsync<EntityState>();
        public Task<IApiResponse<EntityType>> GetEntityTypesAsync() => GetDataAsync<EntityType>();
        public Task<IApiResponse<Epic>> GetEpicsAsync() => GetDataAsync<Epic>();
        public Task<IApiResponse<Feature>> GetFeaturesAsync() => GetDataAsync<Feature>();
        public Task<IApiResponse<General>> GetGeneralsAsync() => GetDataAsync<General>();
        public Task<IApiResponse<GeneralFollower>> GetGeneralFollowersAsync() => GetDataAsync<GeneralFollower>();
        public Task<IApiResponse<GeneralUser>> GetGeneralUsersAsync() => GetDataAsync<GeneralUser>();
        public Task<IApiResponse<GlobalSettings>> GetGlobalSettingsAsync() => GetDataAsync<GlobalSettings>();
        public Task<IApiResponse<Impediment>> GetImpedimentsAsync() => GetDataAsync<Impediment>();
        public Task<IApiResponse<InboundAssignable>> GetInboundAssignablesAsync() => GetDataAsync<InboundAssignable>();
        public Task<IApiResponse<Iteration>> GetIterationsAsync() => GetDataAsync<Iteration>();
        public Task<IApiResponse<Message>> GetMessagesAsync() => GetDataAsync<Message>();
        public Task<IApiResponse<MessageUniqueId>> GetMessageUniqueIdsAsync() => GetDataAsync<MessageUniqueId>();
        public Task<IApiResponse<Milestone>> GetMilestonesAsync() => GetDataAsync<Milestone>();
        public Task<IApiResponse<OutboundAssignable>> GetOutboundAssignablesAsync() => GetDataAsync<OutboundAssignable>();
        public Task<IApiResponse<Priority>> GetPrioritiesAsync() => GetDataAsync<Priority>();
        public Task<IApiResponse<Process>> GetProcessesAsync() => GetDataAsync<Process>();
        public Task<IApiResponse<Program>> GetProgramsAsync() => GetDataAsync<Program>();
        public Task<IApiResponse<Project>> GetProjectsAsync() => GetDataAsync<Project>();
        public Task<IApiResponse<ProjectAllocation>> GetProjectAllocationsAsync() => GetDataAsync<ProjectAllocation>();
        public Task<IApiResponse<ProjectMember>> GetProjectMembersAsync() => GetDataAsync<ProjectMember>();
        public Task<IApiResponse<Relation>> GetRelationsAsync() => GetDataAsync<Relation>();
        public Task<IApiResponse<RelationType>> GetRelationTypesAsync() => GetDataAsync<RelationType>();
        public Task<IApiResponse<Release>> GetReleasesAsync() => GetDataAsync<Release>();
        public Task<IApiResponse<ReleaseProject>> GetReleaseProjectsAsync() => GetDataAsync<ReleaseProject>();
        public Task<IApiResponse<Request>> GetRequestsAsync() => GetDataAsync<Request>();
        public Task<IApiResponse<Requester>> GetRequestersAsync() => GetDataAsync<Requester>();
        public Task<IApiResponse<RequestType>> GetRequestTypesAsync() => GetDataAsync<RequestType>();
        public Task<IApiResponse<Revision>> GetRevisionsAsync() => GetDataAsync<Revision>();
        public Task<IApiResponse<RevisionFile>> GetRevisionFilesAsync() => GetDataAsync<RevisionFile>();
        public Task<IApiResponse<Role>> GetRolesAsync() => GetDataAsync<Role>();
        public Task<IApiResponse<RoleEffort>> GetRoleEffortsAsync() => GetDataAsync<RoleEffort>();
        public Task<IApiResponse<Severity>> GetSeveritiesAsync() => GetDataAsync<Severity>();
        public Task<IApiResponse<Tag>> GetTagsAsync() => GetDataAsync<Tag>();
        public Task<IApiResponse<Task>> GetTasksAsync() => GetDataAsync<Task>();
        public Task<IApiResponse<Team>> GetTeamsAsync() => GetDataAsync<Team>();
        public Task<IApiResponse<TeamAssignment>> GetTeamAssignmentsAsync() => GetDataAsync<TeamAssignment>();
        public Task<IApiResponse<TeamIteration>> GetTeamIterationsAsync() => GetDataAsync<TeamIteration>();
        public Task<IApiResponse<TeamMember>> GetTeamMembersAsync() => GetDataAsync<TeamMember>();
        public Task<IApiResponse<TeamProject>> GetTeamProjectsAsync() => GetDataAsync<TeamProject>();
        public Task<IApiResponse<TeamProjectAllocation>> GetTeamProjectAllocationsAsync() => GetDataAsync<TeamProjectAllocation>();
        public Task<IApiResponse<Term>> GetTermsAsync() => GetDataAsync<Term>();
        public Task<IApiResponse<TestCase>> GetTestCasesAsync() => GetDataAsync<TestCase>();
        public Task<IApiResponse<TestCaseRun>> GetTestCaseRunsAsync() => GetDataAsync<TestCaseRun>();
        public Task<IApiResponse<TestPlan>> GetTestPlansAsync() => GetDataAsync<TestPlan>();
        public Task<IApiResponse<TestPlanRun>> GetTestPlanRunsAsync() => GetDataAsync<TestPlanRun>();
        public Task<IApiResponse<TestRunItemHierarchyLink>> GetTestRunItemHierarchyLinksAsync() => GetDataAsync<TestRunItemHierarchyLink>();
        public Task<IApiResponse<TestStep>> GetTestStepsAsync() => GetDataAsync<TestStep>();
        public Task<IApiResponse<TestStepRun>> GetTestStepRunsAsync() => GetDataAsync<TestStepRun>();
        public Task<IApiResponse<Time>> GetTimesAsync() => GetDataAsync<Time>();
        public Task<IApiResponse<User>> GetUsersAsync() => GetDataAsync<User>();
        public Task<IApiResponse<UserProjectAllocation>> GetUserProjectAllocationsAsync() => GetDataAsync<UserProjectAllocation>();
        public Task<IApiResponse<UserStory>> GetUserStoriesAsync() => GetDataAsync<UserStory>();
        public Task<IApiResponse<Workflow>> GetWorkflowsAsync() => GetDataAsync<Workflow>();


        #endregion
    }
}
