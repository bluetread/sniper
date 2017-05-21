using Sniper.Common;
using Sniper.Http;
using System.Threading.Tasks;
using Task = Sniper.Common.Task;

namespace Sniper
{
    public partial class TargetProcessClient
    {
        #region GET/Read 

        public IApiResponse<Assignable> GetAssignables(int? id = null) => GetData<Assignable>(id);
        public IApiResponse<AssignedEffort> GetAssignedEfforts(int? id = null) => GetData<AssignedEffort>(id);
        public IApiResponse<Assignment> GetAssignments(int? id = null) => GetData<Assignment>(id);
        public IApiResponse<Attachment> GetAttachments(int? id = null) => GetData<Attachment>(id);
        public IApiResponse<Bug> GetBugs(int? id = null) => GetData<Bug>(id);
        public IApiResponse<Build> GetBuilds(int? id = null) => GetData<Build>(id);
        public IApiResponse<Company> GetCompanies(int? id = null) => GetData<Company>(id);
        public IApiResponse<Context> GetContext(int? id = null) => GetData<Context>(id);
        public IApiResponse<CustomActivity> GetCustomActivities(int? id = null) => GetData<CustomActivity>(id);
        public IApiResponse<CustomField> GetCustomFields(int? id = null) => GetData<CustomField>(id);
        public IApiResponse<CustomRule> GetCustomRules(int? id = null) => GetData<CustomRule>(id);
        public IApiResponse<EntityState> GetEntityStates(int? id = null) => GetData<EntityState>(id);
        // NOT ALLOWED GetEntityTypes //
        public IApiResponse<Epic> GetEpics(int? id = null) => GetData<Epic>(id);
        public IApiResponse<Feature> GetFeatures(int? id = null) => GetData<Feature>(id);
        // NOT ALLOWED GetGenerals //
        public IApiResponse<GeneralFollower> GetGeneralFollowers(int? id = null) => GetData<GeneralFollower>(id);
        public IApiResponse<GeneralUser> GetGeneralUsers(int? id = null) => GetData<GeneralUser>(id);
        public IApiResponse<GlobalSettings> GetGlobalSettings(int? id = null) => GetData<GlobalSettings>(id);
        public IApiResponse<Impediment> GetImpediments(int? id = null) => GetData<Impediment>(id);
        public IApiResponse<InboundAssignable> GetInboundAssignables(int? id = null) => GetData<InboundAssignable>(id);
        public IApiResponse<Iteration> GetIterations(int? id = null) => GetData<Iteration>(id);
        public IApiResponse<Message> GetMessages(int? id = null) => GetData<Message>(id);
        public IApiResponse<MessageUniqueId> GetMessageUniqueIds(int? id = null) => GetData<MessageUniqueId>(id);
        public IApiResponse<Milestone> GetMilestones(int? id = null) => GetData<Milestone>(id);
        public IApiResponse<OutboundAssignable> GetOutboundAssignables(int? id = null) => GetData<OutboundAssignable>(id);
        public IApiResponse<Priority> GetPriorities(int? id = null) => GetData<Priority>(id);
        public IApiResponse<Process> GetProcesses(int? id = null) => GetData<Process>(id);
        public IApiResponse<Program> GetPrograms(int? id = null) => GetData<Program>(id);
        public IApiResponse<Project> GetProjects(int? id = null) => GetData<Project>(id);
        public IApiResponse<ProjectAllocation> GetProjectAllocations(int? id = null) => GetData<ProjectAllocation>(id);
        public IApiResponse<ProjectMember> GetProjectMembers(int? id = null) => GetData<ProjectMember>(id);
        public IApiResponse<Relation> GetRelations(int? id = null) => GetData<Relation>(id);
        public IApiResponse<RelationType> GetRelationTypes(int? id = null) => GetData<RelationType>(id);
        public IApiResponse<Release> GetReleases(int? id = null) => GetData<Release>(id);
        public IApiResponse<ReleaseProject> GetReleaseProjects(int? id = null) => GetData<ReleaseProject>(id);
        public IApiResponse<Request> GetRequests(int? id = null) => GetData<Request>(id);
        public IApiResponse<Requester> GetRequesters(int? id = null) => GetData<Requester>(id);
        public IApiResponse<RequestType> GetRequestTypes(int? id = null) => GetData<RequestType>(id);
        public IApiResponse<Revision> GetRevisions(int? id = null) => GetData<Revision>(id);
        public IApiResponse<RevisionFile> GetRevisionFiles(int? id = null) => GetData<RevisionFile>(id);
        public IApiResponse<Role> GetRoles(int? id = null) => GetData<Role>(id);
        public IApiResponse<RoleEffort> GetRoleEfforts(int? id = null) => GetData<RoleEffort>(id);
        public IApiResponse<Severity> GetSeverities(int? id = null) => GetData<Severity>(id);
        public IApiResponse<Tag> GetTags(int? id = null) => GetData<Tag>(id);
        public IApiResponse<Task> GetTasks(int? id = null) => GetData<Task>(id);
        public IApiResponse<Team> GetTeams(int? id = null) => GetData<Team>(id);
        public IApiResponse<TeamAssignment> GetTeamAssignments(int? id = null) => GetData<TeamAssignment>(id);
        public IApiResponse<TeamIteration> GetTeamIterations(int? id = null) => GetData<TeamIteration>(id);
        public IApiResponse<TeamMember> GetTeamMembers(int? id = null) => GetData<TeamMember>(id);
        public IApiResponse<TeamProject> GetTeamProjects(int? id = null) => GetData<TeamProject>(id);
        public IApiResponse<TeamProjectAllocation> GetTeamProjectAllocations(int? id = null) => GetData<TeamProjectAllocation>(id);
        public IApiResponse<Term> GetTerms(int? id = null) => GetData<Term>(id);
        public IApiResponse<TestCase> GetTestCases(int? id = null) => GetData<TestCase>(id);
        public IApiResponse<TestCaseRun> GetTestCaseRuns(int? id = null) => GetData<TestCaseRun>(id);
        public IApiResponse<TestPlan> GetTestPlans(int? id = null) => GetData<TestPlan>(id);
        public IApiResponse<TestPlanRun> GetTestPlanRuns(int? id = null) => GetData<TestPlanRun>(id);
        // NOT ALLOWED GetTestRunItemHierarchyLinks //
        public IApiResponse<TestStep> GetTestSteps(int? id = null) => GetData<TestStep>(id);
        public IApiResponse<TestStepRun> GetTestStepRuns(int? id = null) => GetData<TestStepRun>(id);
        public IApiResponse<Time> GetTimes(int? id = null) => GetData<Time>(id);
        public IApiResponse<User> GetUsers(int? id = null) => GetData<User>(id);
        public IApiResponse<UserProjectAllocation> GetUserProjectAllocations(int? id = null) => GetData<UserProjectAllocation>(id);
        public IApiResponse<UserStory> GetUserStories(int? id = null) => GetData<UserStory>(id);
        public IApiResponse<Workflow> GetWorkflows(int? id = null) => GetData<Workflow>(id);

        // NOT ALLOWED GetBugSimpleHistories //
        // NOT ALLOWED GetEpicSimpleHistories //
        // NOT ALLOWED GetFeatureSimpleHistories //
        // NOT ALLOWED GetImpedimentSimpleHistories //
        // NOT ALLOWED GetRequestSimpleHistories //
        // NOT ALLOWED GetTaskSimpleHistories //
        // NOT ALLOWED GetUserStorySimpleHistories //

        #endregion

        #region GET / Read Async

        public Task<IApiResponse<Assignable>> GetAssignablesAsync(int? id = null) => GetDataAsync<Assignable>(id);
        public Task<IApiResponse<AssignedEffort>> GetAssignedEffortsAsync(int? id = null) => GetDataAsync<AssignedEffort>(id);
        public Task<IApiResponse<Assignment>> GetAssignmentsAsync(int? id = null) => GetDataAsync<Assignment>(id);
        public Task<IApiResponse<Attachment>> GetAttachmentsAsync(int? id = null) => GetDataAsync<Attachment>(id);
        public Task<IApiResponse<Bug>> GetBugsAsync(int? id = null) => GetDataAsync<Bug>(id);
        public Task<IApiResponse<Build>> GetBuildsAsync(int? id = null) => GetDataAsync<Build>(id);
        public Task<IApiResponse<Company>> GetCompaniesAsync(int? id = null) => GetDataAsync<Company>(id);
        public Task<IApiResponse<Context>> GetContextAsync(int? id = null) => GetDataAsync<Context>(id);
        public Task<IApiResponse<CustomActivity>> GetCustomActivitiesAsync(int? id = null) => GetDataAsync<CustomActivity>(id);
        public Task<IApiResponse<CustomField>> GetCustomFieldsAsync(int? id = null) => GetDataAsync<CustomField>(id);
        public Task<IApiResponse<CustomRule>> GetCustomRulesAsync(int? id = null) => GetDataAsync<CustomRule>(id);
        public Task<IApiResponse<EntityState>> GetEntityStatesAsync(int? id = null) => GetDataAsync<EntityState>(id);
        // NOT ALLOWED GetEntityTypesAsync //
        public Task<IApiResponse<Epic>> GetEpicsAsync(int? id = null) => GetDataAsync<Epic>(id);
        public Task<IApiResponse<Feature>> GetFeaturesAsync(int? id = null) => GetDataAsync<Feature>(id);
        // NOT ALLOWED GetGeneralsAsync //
        public Task<IApiResponse<GeneralFollower>> GetGeneralFollowersAsync(int? id = null) => GetDataAsync<GeneralFollower>(id);
        public Task<IApiResponse<GeneralUser>> GetGeneralUsersAsync(int? id = null) => GetDataAsync<GeneralUser>(id);
        public Task<IApiResponse<GlobalSettings>> GetGlobalSettingsAsync(int? id = null) => GetDataAsync<GlobalSettings>(id);
        public Task<IApiResponse<Impediment>> GetImpedimentsAsync(int? id = null) => GetDataAsync<Impediment>(id);
        public Task<IApiResponse<InboundAssignable>> GetInboundAssignablesAsync(int? id = null) => GetDataAsync<InboundAssignable>(id);
        public Task<IApiResponse<Iteration>> GetIterationsAsync(int? id = null) => GetDataAsync<Iteration>(id);
        public Task<IApiResponse<Message>> GetMessagesAsync(int? id = null) => GetDataAsync<Message>(id);
        public Task<IApiResponse<MessageUniqueId>> GetMessageUniqueIdsAsync(int? id = null) => GetDataAsync<MessageUniqueId>(id);
        public Task<IApiResponse<Milestone>> GetMilestonesAsync(int? id = null) => GetDataAsync<Milestone>(id);
        public Task<IApiResponse<OutboundAssignable>> GetOutboundAssignablesAsync(int? id = null) => GetDataAsync<OutboundAssignable>(id);
        public Task<IApiResponse<Priority>> GetPrioritiesAsync(int? id = null) => GetDataAsync<Priority>(id);
        public Task<IApiResponse<Process>> GetProcessesAsync(int? id = null) => GetDataAsync<Process>(id);
        public Task<IApiResponse<Program>> GetProgramsAsync(int? id = null) => GetDataAsync<Program>(id);
        public Task<IApiResponse<Project>> GetProjectsAsync(int? id = null) => GetDataAsync<Project>(id);
        public Task<IApiResponse<ProjectAllocation>> GetProjectAllocationsAsync(int? id = null) => GetDataAsync<ProjectAllocation>(id);
        public Task<IApiResponse<ProjectMember>> GetProjectMembersAsync(int? id = null) => GetDataAsync<ProjectMember>(id);
        public Task<IApiResponse<Relation>> GetRelationsAsync(int? id = null) => GetDataAsync<Relation>(id);
        public Task<IApiResponse<RelationType>> GetRelationTypesAsync(int? id = null) => GetDataAsync<RelationType>(id);
        public Task<IApiResponse<Release>> GetReleasesAsync(int? id = null) => GetDataAsync<Release>(id);
        public Task<IApiResponse<ReleaseProject>> GetReleaseProjectsAsync(int? id = null) => GetDataAsync<ReleaseProject>(id);
        public Task<IApiResponse<Request>> GetRequestsAsync(int? id = null) => GetDataAsync<Request>(id);
        public Task<IApiResponse<Requester>> GetRequestersAsync(int? id = null) => GetDataAsync<Requester>(id);
        public Task<IApiResponse<RequestType>> GetRequestTypesAsync(int? id = null) => GetDataAsync<RequestType>(id);
        public Task<IApiResponse<Revision>> GetRevisionsAsync(int? id = null) => GetDataAsync<Revision>(id);
        public Task<IApiResponse<RevisionFile>> GetRevisionFilesAsync(int? id = null) => GetDataAsync<RevisionFile>(id);
        public Task<IApiResponse<Role>> GetRolesAsync(int? id = null) => GetDataAsync<Role>(id);
        public Task<IApiResponse<RoleEffort>> GetRoleEffortsAsync(int? id = null) => GetDataAsync<RoleEffort>(id);
        public Task<IApiResponse<Severity>> GetSeveritiesAsync(int? id = null) => GetDataAsync<Severity>(id);
        public Task<IApiResponse<Tag>> GetTagsAsync(int? id = null) => GetDataAsync<Tag>(id);
        public Task<IApiResponse<Task>> GetTasksAsync(int? id = null) => GetDataAsync<Task>(id);
        public Task<IApiResponse<Team>> GetTeamsAsync(int? id = null) => GetDataAsync<Team>(id);
        public Task<IApiResponse<TeamAssignment>> GetTeamAssignmentsAsync(int? id = null) => GetDataAsync<TeamAssignment>(id);
        public Task<IApiResponse<TeamIteration>> GetTeamIterationsAsync(int? id = null) => GetDataAsync<TeamIteration>(id);
        public Task<IApiResponse<TeamMember>> GetTeamMembersAsync(int? id = null) => GetDataAsync<TeamMember>(id);
        public Task<IApiResponse<TeamProject>> GetTeamProjectsAsync(int? id = null) => GetDataAsync<TeamProject>(id);
        public Task<IApiResponse<TeamProjectAllocation>> GetTeamProjectAllocationsAsync(int? id = null) => GetDataAsync<TeamProjectAllocation>(id);
        public Task<IApiResponse<Term>> GetTermsAsync(int? id = null) => GetDataAsync<Term>(id);
        public Task<IApiResponse<TestCase>> GetTestCasesAsync(int? id = null) => GetDataAsync<TestCase>(id);
        public Task<IApiResponse<TestCaseRun>> GetTestCaseRunsAsync(int? id = null) => GetDataAsync<TestCaseRun>(id);
        public Task<IApiResponse<TestPlan>> GetTestPlansAsync(int? id = null) => GetDataAsync<TestPlan>(id);
        public Task<IApiResponse<TestPlanRun>> GetTestPlanRunsAsync(int? id = null) => GetDataAsync<TestPlanRun>(id);
        // NOT ALLOWED GetTestRunItemHierarchyLinksAsync //
        public Task<IApiResponse<TestStep>> GetTestStepsAsync(int? id = null) => GetDataAsync<TestStep>(id);
        public Task<IApiResponse<TestStepRun>> GetTestStepRunsAsync(int? id = null) => GetDataAsync<TestStepRun>(id);
        public Task<IApiResponse<Time>> GetTimesAsync(int? id = null) => GetDataAsync<Time>(id);
        public Task<IApiResponse<User>> GetUsersAsync(int? id = null) => GetDataAsync<User>(id);
        public Task<IApiResponse<UserProjectAllocation>> GetUserProjectAllocationsAsync(int? id = null) => GetDataAsync<UserProjectAllocation>(id);
        public Task<IApiResponse<UserStory>> GetUserStoriesAsync(int? id = null) => GetDataAsync<UserStory>(id);
        public Task<IApiResponse<Workflow>> GetWorkflowsAsync(int? id = null) => GetDataAsync<Workflow>(id);

        // NOT ALLOWED GetBugSimpleHistoriesAsync //
        // NOT ALLOWED GetEpicSimpleHistoriesAsync //
        // NOT ALLOWED GetFeatureSimpleHistoriesAsync //
        // NOT ALLOWED GetImpedimentSimpleHistoriesAsync //
        // NOT ALLOWED GetRequestSimpleHistoriesAsync //
        // NOT ALLOWED GetTaskSimpleHistoriesAsync //
        // NOT ALLOWED GetUserStorySimpleHistoriesAsync //

        #endregion

        #region Create

        // NOT ALLOWED CreateAssignable //
        // NOT ALLOWED CreateAssignedEffort //
        public IApiResponse<Assignment> CreateAssignment(Assignment assignment) => CreateData<Assignment>(assignment);
        public IApiResponse<Attachment> CreateAttachment(Attachment attachment) => CreateData<Attachment>(attachment);
        public IApiResponse<Bug> CreateBug(Bug bug) => CreateData<Bug>(bug);
        public IApiResponse<Build> CreateBuild(Build build) => CreateData<Build>(build);
        public IApiResponse<Company> CreateCompany(Company company) => CreateData<Company>(company);
        public IApiResponse<Context> CreateContext(Context context) => CreateData<Context>(context);
        public IApiResponse<CustomActivity> CreateCustomActivity(CustomActivity customActivity) => CreateData<CustomActivity>(customActivity);
        public IApiResponse<CustomField> CreateCustomField(CustomField customField) => CreateData<CustomField>(customField);
        public IApiResponse<CustomRule> CreateCustomRule(CustomRule customRule) => CreateData<CustomRule>(customRule);
        public IApiResponse<EntityState> CreateEntityState(EntityState entityState) => CreateData<EntityState>(entityState);
        // NOT ALLOWED CreateEntityType //
        public IApiResponse<Epic> CreateEpic(Epic epic) => CreateData<Epic>(epic);
        public IApiResponse<Feature> CreateFeature(Feature feature) => CreateData<Feature>(feature);
        // NOT ALLOWED CreateGeneral //
        public IApiResponse<GeneralFollower> CreateGeneralFollower(GeneralFollower generalFollower) => CreateData<GeneralFollower>(generalFollower);
        // NOT ALLOWED CreateGeneralUser //
        public IApiResponse<GlobalSettings> CreateGlobalSetting(GlobalSettings globalSettings) => CreateData<GlobalSettings>(globalSettings);
        public IApiResponse<Impediment> CreateImpediment(Impediment impediment) => CreateData<Impediment>(impediment);
        public IApiResponse<InboundAssignable> CreateInboundAssignable(InboundAssignable inboundAssignable) => CreateData<InboundAssignable>(inboundAssignable);
        public IApiResponse<Iteration> CreateIteration(Iteration iteration) => CreateData<Iteration>(iteration);
        public IApiResponse<Message> CreateMessage(Message message) => CreateData<Message>(message);
        public IApiResponse<MessageUniqueId> CreateMessageUniqueId(MessageUniqueId messageUniqueId) => CreateData<MessageUniqueId>(messageUniqueId);
        public IApiResponse<Milestone> CreateMilestone(Milestone milestone) => CreateData<Milestone>(milestone);
        public IApiResponse<OutboundAssignable> CreateOutboundAssignable(OutboundAssignable outboundAssignable) => CreateData<OutboundAssignable>(outboundAssignable);
        // NOT ALLOWED CreatePractice //
        public IApiResponse<Priority> CreatePriority(Priority priority) => CreateData<Priority>(priority);
        public IApiResponse<Process> CreateProcess(Process process) => CreateData<Process>(process);
        public IApiResponse<Program> CreateProgram(Program program) => CreateData<Program>(program);
        public IApiResponse<Project> CreateProject(Project project) => CreateData<Project>(project);
        // NOT ALLOWED CreateProjectAllocation //
        public IApiResponse<ProjectMember> CreateProjectMember(ProjectMember projectMember) => CreateData<ProjectMember>(projectMember);
        public IApiResponse<Relation> CreateRelation(Relation relation) => CreateData<Relation>(relation);
        public IApiResponse<RelationType> CreateRelationType(RelationType relationType) => CreateData<RelationType>(relationType);
        public IApiResponse<Release> CreateRelease(Release release) => CreateData<Release>(release);
        public IApiResponse<ReleaseProject> CreateReleaseProject(ReleaseProject releaseProject) => CreateData<ReleaseProject>(releaseProject);
        public IApiResponse<Request> CreateRequest(Request request) => CreateData<Request>(request);
        public IApiResponse<Requester> CreateRequester(Requester requester) => CreateData<Requester>(requester);
        public IApiResponse<RequestType> CreateRequestType(RequestType requestType) => CreateData<RequestType>(requestType);
        public IApiResponse<Revision> CreateRevision(Revision revision) => CreateData<Revision>(revision);
        public IApiResponse<RevisionFile> CreateRevisionFile(RevisionFile revisionFile) => CreateData<RevisionFile>(revisionFile);
        public IApiResponse<Role> CreateRole(Role role) => CreateData<Role>(role);
        public IApiResponse<RoleEffort> CreateRoleEffort(RoleEffort roleEffort) => CreateData<RoleEffort>(roleEffort);
        public IApiResponse<Severity> CreateSeverity(Severity severity) => CreateData<Severity>(severity);
        public IApiResponse<Tag> CreateTag(Tag tag) => CreateData<Tag>(tag);
        public IApiResponse<Task> CreateTask(Task task) => CreateData<Task>(task);
        public IApiResponse<Team> CreateTeam(Team team) => CreateData<Team>(team);
        public IApiResponse<TeamAssignment> CreateTeamAssignment(TeamAssignment teamAssignment) => CreateData<TeamAssignment>(teamAssignment);
        public IApiResponse<TeamIteration> CreateTeamIteration(TeamIteration teamIteration) => CreateData<TeamIteration>(teamIteration);
        public IApiResponse<TeamMember> CreateTeamMember(TeamMember teamMember) => CreateData<TeamMember>(teamMember);
        public IApiResponse<TeamProject> CreateTeamProject(TeamProject teamProject) => CreateData<TeamProject>(teamProject);
        public IApiResponse<TeamProjectAllocation> CreateTeamProjectAllocation(TeamProjectAllocation teamProjectAllocation) => CreateData<TeamProjectAllocation>(teamProjectAllocation);
        public IApiResponse<Term> CreateTerm(Term term) => CreateData<Term>(term);
        public IApiResponse<TestCase> CreateTestCase(TestCase testCase) => CreateData<TestCase>(testCase);
        public IApiResponse<TestCaseRun> CreateTestCaseRun(TestCaseRun testCaseRun) => CreateData<TestCaseRun>(testCaseRun);
        public IApiResponse<TestPlan> CreateTestPlan(TestPlan testPlan) => CreateData<TestPlan>(testPlan);
        public IApiResponse<TestPlanRun> CreateTestPlanRun(TestPlanRun testPlanRun) => CreateData<TestPlanRun>(testPlanRun);
        // NOT ALLOWED CreateTestRunItemHierarchyLink //
        public IApiResponse<TestStep> CreateTestStep(TestStep testStep) => CreateData<TestStep>(testStep);
        public IApiResponse<TestStepRun> CreateTestStepRun(TestStepRun testStepRun) => CreateData<TestStepRun>(testStepRun);
        public IApiResponse<Time> CreateTime(Time time) => CreateData<Time>(time);
        public IApiResponse<User> CreateUser(User user) => CreateData<User>(user);
        public IApiResponse<UserProjectAllocation> CreateUserProjectAllocation(UserProjectAllocation userProjectAllocation) => CreateData<UserProjectAllocation>(userProjectAllocation);
        public IApiResponse<UserStory> CreateUserStory(UserStory userStory) => CreateData<UserStory>(userStory);
        public IApiResponse<Workflow> CreateWorkflow(Workflow workflow) => CreateData<Workflow>(workflow);

        // NOT ALLOWED CreateBugSimpleHistories //
        // NOT ALLOWED CreateBugSimpleHistories //
        // NOT ALLOWED CreateEpicSimpleHistories //
        // NOT ALLOWED CreateFeatureSimpleHistories //
        // NOT ALLOWED CreateImpedimentSimpleHistories //
        // NOT ALLOWED CreateRequestSimpleHistories //
        // NOT ALLOWED CreateTaskSimpleHistories //
        // NOT ALLOWED CreateUserStorySimpleHistories //

        #endregion

        #region CreateAsync

        // NOT ALLOWED CreateAssignableAsync //
        // NOT ALLOWED CreateAssignedEffortAsync //
        public Task<IApiResponse<Assignment>> CreateAssignmentAsync(Assignment assignment) => CreateDataAsync<Assignment>(assignment);
        public Task<IApiResponse<Attachment>> CreateAttachmentAsync(Attachment attachment) => CreateDataAsync<Attachment>(attachment);
        public Task<IApiResponse<Bug>> CreateBugAsync(Bug bug) => CreateDataAsync<Bug>(bug);
        public Task<IApiResponse<Build>> CreateBuildAsync(Build build) => CreateDataAsync<Build>(build);
        public Task<IApiResponse<Company>> CreateCompanyAsync(Company company) => CreateDataAsync<Company>(company);
        public Task<IApiResponse<Context>> CreateContextAsync(Context context) => CreateDataAsync<Context>(context);
        public Task<IApiResponse<CustomActivity>> CreateCustomActivityAsync(CustomActivity customActivity) => CreateDataAsync<CustomActivity>(customActivity);
        public Task<IApiResponse<CustomField>> CreateCustomFieldAsync(CustomField customField) => CreateDataAsync<CustomField>(customField);
        public Task<IApiResponse<CustomRule>> CreateCustomRuleAsync(CustomRule customRule) => CreateDataAsync<CustomRule>(customRule);
        public Task<IApiResponse<EntityState>> CreateEntityStateAsync(EntityState entityState) => CreateDataAsync<EntityState>(entityState);
        // NOT ALLOWED CreateEntityTypeAsync //
        public Task<IApiResponse<Epic>> CreateEpicAsync(Epic epic) => CreateDataAsync<Epic>(epic);
        public Task<IApiResponse<Feature>> CreateFeatureAsync(Feature feature) => CreateDataAsync<Feature>(feature);
        // NOT ALLOWED CreateGeneralAsync //
        public Task<IApiResponse<GeneralFollower>> CreateGeneralFollowerAsync(GeneralFollower generalFollower) => CreateDataAsync<GeneralFollower>(generalFollower);
        // NOT ALLOWED CreateGeneralUserAsync //
        public Task<IApiResponse<GlobalSettings>> CreateGlobalSettingAsync(GlobalSettings globalSettings) => CreateDataAsync<GlobalSettings>(globalSettings);
        public Task<IApiResponse<Impediment>> CreateImpedimentAsync(Impediment impediment) => CreateDataAsync<Impediment>(impediment);
        public Task<IApiResponse<InboundAssignable>> CreateInboundAssignableAsync(InboundAssignable inboundAssignable) => CreateDataAsync<InboundAssignable>(inboundAssignable);
        public Task<IApiResponse<Iteration>> CreateIterationAsync(Iteration iteration) => CreateDataAsync<Iteration>(iteration);
        public Task<IApiResponse<Message>> CreateMessageAsync(Message message) => CreateDataAsync<Message>(message);
        public Task<IApiResponse<MessageUniqueId>> CreateMessageUniqueIdAsync(MessageUniqueId messageUniqueId) => CreateDataAsync<MessageUniqueId>(messageUniqueId);
        public Task<IApiResponse<Milestone>> CreateMilestoneAsync(Milestone milestone) => CreateDataAsync<Milestone>(milestone);
        public Task<IApiResponse<OutboundAssignable>> CreateOutboundAssignableAsync(OutboundAssignable outboundAssignable) => CreateDataAsync<OutboundAssignable>(outboundAssignable);
        // NOT ALLOWED CreatePracticeAsync //
        public Task<IApiResponse<Priority>> CreatePriorityAsync(Priority priority) => CreateDataAsync<Priority>(priority);
        public Task<IApiResponse<Process>> CreateProcessAsync(Process process) => CreateDataAsync<Process>(process);
        public Task<IApiResponse<Program>> CreateProgramAsync(Program program) => CreateDataAsync<Program>(program);
        public Task<IApiResponse<Project>> CreateProjectAsync(Project project) => CreateDataAsync<Project>(project);
        // NOT ALLOWED CreateProjectAllocationAsync //
        public Task<IApiResponse<ProjectMember>> CreateProjectMemberAsync(ProjectMember projectMember) => CreateDataAsync<ProjectMember>(projectMember);
        public Task<IApiResponse<Relation>> CreateRelationAsync(Relation relation) => CreateDataAsync<Relation>(relation);
        public Task<IApiResponse<RelationType>> CreateRelationTypeAsync(RelationType relationType) => CreateDataAsync<RelationType>(relationType);
        public Task<IApiResponse<Release>> CreateReleaseAsync(Release release) => CreateDataAsync<Release>(release);
        public Task<IApiResponse<ReleaseProject>> CreateReleaseProjectAsync(ReleaseProject releaseProject) => CreateDataAsync<ReleaseProject>(releaseProject);
        public Task<IApiResponse<Request>> CreateRequestAsync(Request request) => CreateDataAsync<Request>(request);
        public Task<IApiResponse<Requester>> CreateRequesterAsync(Requester requester) => CreateDataAsync<Requester>(requester);
        public Task<IApiResponse<RequestType>> CreateRequestTypeAsync(RequestType requestType) => CreateDataAsync<RequestType>(requestType);
        public Task<IApiResponse<Revision>> CreateRevisionAsync(Revision revision) => CreateDataAsync<Revision>(revision);
        public Task<IApiResponse<RevisionFile>> CreateRevisionFileAsync(RevisionFile revisionFile) => CreateDataAsync<RevisionFile>(revisionFile);
        public Task<IApiResponse<Role>> CreateRoleAsync(Role role) => CreateDataAsync<Role>(role);
        public Task<IApiResponse<RoleEffort>> CreateRoleEffortAsync(RoleEffort roleEffort) => CreateDataAsync<RoleEffort>(roleEffort);
        public Task<IApiResponse<Severity>> CreateSeverityAsync(Severity severity) => CreateDataAsync<Severity>(severity);
        public Task<IApiResponse<Tag>> CreateTagAsync(Tag tag) => CreateDataAsync<Tag>(tag);
        public Task<IApiResponse<Task>> CreateTaskAsync(Task task) => CreateDataAsync<Task>(task);
        public Task<IApiResponse<Team>> CreateTeamAsync(Team team) => CreateDataAsync<Team>(team);
        public Task<IApiResponse<TeamAssignment>> CreateTeamAssignmentAsync(TeamAssignment teamAssignment) => CreateDataAsync<TeamAssignment>(teamAssignment);
        public Task<IApiResponse<TeamIteration>> CreateTeamIterationAsync(TeamIteration teamIteration) => CreateDataAsync<TeamIteration>(teamIteration);
        public Task<IApiResponse<TeamMember>> CreateTeamMemberAsync(TeamMember teamMember) => CreateDataAsync<TeamMember>(teamMember);
        public Task<IApiResponse<TeamProject>> CreateTeamProjectAsync(TeamProject teamProject) => CreateDataAsync<TeamProject>(teamProject);
        public Task<IApiResponse<TeamProjectAllocation>> CreateTeamProjectAllocationAsync(TeamProjectAllocation teamProjectAllocation) => CreateDataAsync<TeamProjectAllocation>(teamProjectAllocation);
        public Task<IApiResponse<Term>> CreateTermAsync(Term term) => CreateDataAsync<Term>(term);
        public Task<IApiResponse<TestCase>> CreateTestCaseAsync(TestCase testCase) => CreateDataAsync<TestCase>(testCase);
        public Task<IApiResponse<TestCaseRun>> CreateTestCaseRunAsync(TestCaseRun testCaseRun) => CreateDataAsync<TestCaseRun>(testCaseRun);
        public Task<IApiResponse<TestPlan>> CreateTestPlanAsync(TestPlan testPlan) => CreateDataAsync<TestPlan>(testPlan);
        public Task<IApiResponse<TestPlanRun>> CreateTestPlanRunAsync(TestPlanRun testPlanRun) => CreateDataAsync<TestPlanRun>(testPlanRun);
        // NOT ALLOWED CreateTestRunItemHierarchyLinkAsync //
        public Task<IApiResponse<TestStep>> CreateTestStepAsync(TestStep testStep) => CreateDataAsync<TestStep>(testStep);
        public Task<IApiResponse<TestStepRun>> CreateTestStepRunAsync(TestStepRun testStepRun) => CreateDataAsync<TestStepRun>(testStepRun);
        public Task<IApiResponse<Time>> CreateTimeAsync(Time time) => CreateDataAsync<Time>(time);
        public Task<IApiResponse<User>> CreateUserAsync(User user) => CreateDataAsync<User>(user);
        public Task<IApiResponse<UserProjectAllocation>> CreateUserProjectAllocationAsync(UserProjectAllocation userProjectAllocation) => CreateDataAsync<UserProjectAllocation>(userProjectAllocation);
        public Task<IApiResponse<UserStory>> CreateUserStoryAsync(UserStory userStory) => CreateDataAsync<UserStory>(userStory);
        public Task<IApiResponse<Workflow>> CreateWorkflowAsync(Workflow workflow) => CreateDataAsync<Workflow>(workflow);

        // NOT ALLOWED CreateBugSimpleHistoriesAsync //
        // NOT ALLOWED CreateBugSimpleHistoriesAsync //
        // NOT ALLOWED CreateEpicSimpleHistoriesAsync //
        // NOT ALLOWED CreateFeatureSimpleHistoriesAsync //
        // NOT ALLOWED CreateImpedimentSimpleHistoriesAsync //
        // NOT ALLOWED CreateRequestSimpleHistoriesAsync //
        // NOT ALLOWED CreateTaskSimpleHistoriesAsync //
        // NOT ALLOWED CreateUserStorySimpleHistoriesAsync //
        #endregion

        #region Delete

        // NOT ALLOWED DeleteAssignedEffort //
        // NOT ALLOWED DeleteEntityType //
        // NOT ALLOWED DeleteGeneral //
        // NOT ALLOWED DeletePractice //
        // NOT ALLOWED DeleteTestRunItemHierarchyLink //

        // NOT ALLOWED DeleteBugSimpleHistories //
        // NOT ALLOWED DeleteBugSimpleHistories //
        // NOT ALLOWED DeleteEpicSimpleHistories //
        // NOT ALLOWED DeleteFeatureSimpleHistories //
        // NOT ALLOWED DeleteImpedimentSimpleHistories //
        // NOT ALLOWED DeleteRequestSimpleHistories //
        // NOT ALLOWED DeleteTaskSimpleHistories //
        // NOT ALLOWED DeleteUserStorySimpleHistories //

        #endregion

        #region DeleteAsync

        // NOT ALLOWED DeleteAssignedEffortAsync //
        // NOT ALLOWED DeleteEntityTypeAsync //
        // NOT ALLOWED DeleteGeneralAsync //
        // NOT ALLOWED DeletePracticeAsync //
        // NOT ALLOWED DeleteTestRunItemHierarchyLinkAsync //

        // NOT ALLOWED DeleteBugSimpleHistoriesAsync //
        // NOT ALLOWED DeleteBugSimpleHistoriesAsync //
        // NOT ALLOWED DeleteEpicSimpleHistoriesAsync //
        // NOT ALLOWED DeleteFeatureSimpleHistoriesAsync //
        // NOT ALLOWED DeleteImpedimentSimpleHistoriesAsync //
        // NOT ALLOWED DeleteRequestSimpleHistoriesAsync //
        // NOT ALLOWED DeleteTaskSimpleHistoriesAsync //
        // NOT ALLOWED DeleteUserStorySimpleHistoriesAsync //

        #endregion

        #region Update

        // NOT ALLOWED UpdateAssignedEffort //
        // NOT ALLOWED UpdateEntityType //
        // NOT ALLOWED UpdateGeneral //
        // NOT ALLOWED UpdatePractice //
        // NOT ALLOWED UpdateTestRunItemHierarchyLink //

        // NOT ALLOWED UpdateBugSimpleHistories //
        // NOT ALLOWED UpdateBugSimpleHistories //
        // NOT ALLOWED UpdateEpicSimpleHistories //
        // NOT ALLOWED UpdateFeatureSimpleHistories //
        // NOT ALLOWED UpdateImpedimentSimpleHistories //
        // NOT ALLOWED UpdateRequestSimpleHistories //
        // NOT ALLOWED UpdateTaskSimpleHistories //
        // NOT ALLOWED UpdateUserStorySimpleHistories //

        #endregion

        #region UpdateAsync

        // NOT ALLOWED UpdateAssignedEffortAsync //
        // NOT ALLOWED UpdateEntityTypeAsync //
        // NOT ALLOWED UpdateGeneralAsync //
        // NOT ALLOWED UpdatePracticeAsync //
        // NOT ALLOWED UpdateTestRunItemHierarchyLinkAsync //

        // NOT ALLOWED UpdateBugSimpleHistoriesAsync //
        // NOT ALLOWED UpdateBugSimpleHistoriesAsync //
        // NOT ALLOWED UpdateEpicSimpleHistoriesAsync //
        // NOT ALLOWED UpdateFeatureSimpleHistoriesAsync //
        // NOT ALLOWED UpdateImpedimentSimpleHistoriesAsync //
        // NOT ALLOWED UpdateRequestSimpleHistoriesAsync //
        // NOT ALLOWED UpdateTaskSimpleHistoriesAsync //
        // NOT ALLOWED UpdateUserStorySimpleHistoriesAsync //

        #endregion


    }
}
