namespace Sniper.Tests
{
    public static class TestDataConstants
    {
        public static class SingleQuotedJson
        {
            public const string UserStoryFromCreateResult = @"
            {
              'ResourceType': 'UserStory',
              'Id': 245,
              'Name': 'Sample Create From Code Story',
              'Description': null,
              'StartDate': null,
              'EndDate': null,
              'CreateDate': '/Date(1494263925000-0500)/',
              'ModifyDate': '/Date(1494263925000-0500)/',
              'LastCommentDate': null,
              'Tags': '',
              'NumericPriority': 192.5,
              'Effort': 0,
              'EffortCompleted': 0,
              'EffortToDo': 0,
              'Progress': 0,
              'TimeSpent': 0,
              'TimeRemain': 0,
              'LastStateChangeDate': '/Date(1494263924000-0500)/',
              'PlannedStartDate': null,
              'PlannedEndDate': null,
              'InitialEstimate': 0,
              'Units': 'pt',
              'EntityType': {
                'ResourceType': 'EntityType',
                'Id': 4,
                'Name': 'UserStory'
              },
              'Project': {
                'ResourceType': 'Project',
                'Id': 194,
                'Name': 'First Test Scrum Project',
                'Process': {
                  'ResourceType': 'Process',
                  'Id': 3,
                  'Name': 'Scrum'
                }
              },
              'LastEditor': {
                'ResourceType': 'GeneralUser',
                'Id': 18,
                'FirstName': 'API',
                'LastName': 'Access',
                'Login': 'apiaccess'
              },
              'Owner': {
                'ResourceType': 'GeneralUser',
                'Id': 18,
                'FirstName': 'API',
                'LastName': 'Access',
                'Login': 'apiaccess'
              },
              'LastCommentedUser': null,
              'LinkedTestPlan': null,
              'Release': null,
              'Iteration': null,
              'TeamIteration': null,
              'Team': null,
              'Priority': {
                'ResourceType': 'Priority',
                'Id': 5,
                'Name': 'Nice To Have',
                'Importance': 5
              },
              'EntityState': {
                'ResourceType': 'EntityState',
                'Id': 73,
                'Name': 'Open',
                'NumericPriority': 73
              },
              'ResponsibleTeam': null,
              'Feature': null,
              'CustomFields': []
            }";
        }
    }
}
