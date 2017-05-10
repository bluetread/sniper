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

            public const string UserStoryFromReadResult = @"
                {
                  'Items': [
                    {
                      'ResourceType': 'UserStory',
                      'Id': 249,
                      'Name': 'Sample Create From Code Story',
                      'Description': null,
                      'StartDate': null,
                      'EndDate': null,
                      'CreateDate': '/Date(1494264990000-0500)/',
                      'ModifyDate': '/Date(1494264990000-0500)/',
                      'LastCommentDate': null,
                      'Tags': '',
                      'NumericPriority': 194.5,
                      'Effort': 0,
                      'EffortCompleted': 0,
                      'EffortToDo': 0,
                      'Progress': 0,
                      'TimeSpent': 0,
                      'TimeRemain': 0,
                      'LastStateChangeDate': '/Date(1494264990000-0500)/',
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
                    },
                    {
                      'ResourceType': 'UserStory',
                      'Id': 248,
                      'Name': 'Sample Create From Code Story',
                      'Description': null,
                      'StartDate': null,
                      'EndDate': null,
                      'CreateDate': '/Date(1494264877000-0500)/',
                      'ModifyDate': '/Date(1494264877000-0500)/',
                      'LastCommentDate': null,
                      'Tags': '',
                      'NumericPriority': 194,
                      'Effort': 0,
                      'EffortCompleted': 0,
                      'EffortToDo': 0,
                      'Progress': 0,
                      'TimeSpent': 0,
                      'TimeRemain': 0,
                      'LastStateChangeDate': '/Date(1494264877000-0500)/',
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
                    },
                    {
                      'ResourceType': 'UserStory',
                      'Id': 247,
                      'Name': 'Sample Create From Code Story',
                      'Description': null,
                      'StartDate': null,
                      'EndDate': null,
                      'CreateDate': '/Date(1494264790000-0500)/',
                      'ModifyDate': '/Date(1494264790000-0500)/',
                      'LastCommentDate': null,
                      'Tags': '',
                      'NumericPriority': 193.5,
                      'Effort': 0,
                      'EffortCompleted': 0,
                      'EffortToDo': 0,
                      'Progress': 0,
                      'TimeSpent': 0,
                      'TimeRemain': 0,
                      'LastStateChangeDate': '/Date(1494264789000-0500)/',
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
                    },
                    {
                      'ResourceType': 'UserStory',
                      'Id': 246,
                      'Name': 'Sample Create From Code Story',
                      'Description': null,
                      'StartDate': null,
                      'EndDate': null,
                      'CreateDate': '/Date(1494264481000-0500)/',
                      'ModifyDate': '/Date(1494264481000-0500)/',
                      'LastCommentDate': null,
                      'Tags': '',
                      'NumericPriority': 193,
                      'Effort': 0,
                      'EffortCompleted': 0,
                      'EffortToDo': 0,
                      'Progress': 0,
                      'TimeSpent': 0,
                      'TimeRemain': 0,
                      'LastStateChangeDate': '/Date(1494264481000-0500)/',
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
                    },
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
                    },
                    {
                      'ResourceType': 'UserStory',
                      'Id': 220,
                      'Name': 'Sample Create From Code Story',
                      'Description': null,
                      'StartDate': null,
                      'EndDate': null,
                      'CreateDate': '/Date(1494106822000-0500)/',
                      'ModifyDate': '/Date(1494106822000-0500)/',
                      'LastCommentDate': null,
                      'Tags': '',
                      'NumericPriority': 192,
                      'Effort': 0,
                      'EffortCompleted': 0,
                      'EffortToDo': 0,
                      'Progress': 0,
                      'TimeSpent': 0,
                      'TimeRemain': 0,
                      'LastStateChangeDate': '/Date(1494106821000-0500)/',
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
                    },
                    {
                      'ResourceType': 'UserStory',
                      'Id': 205,
                      'Name': 'Second Sample User Story',
                      'Description': null,
                      'StartDate': null,
                      'EndDate': null,
                      'CreateDate': '/Date(1493248812000-0500)/',
                      'ModifyDate': '/Date(1493248813000-0500)/',
                      'LastCommentDate': null,
                      'Tags': '',
                      'NumericPriority': 188,
                      'Effort': 0,
                      'EffortCompleted': 0,
                      'EffortToDo': 0,
                      'Progress': 0,
                      'TimeSpent': 0,
                      'TimeRemain': 0,
                      'LastStateChangeDate': '/Date(1493248812000-0500)/',
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
                        'Id': 1,
                        'FirstName': 'Adam',
                        'LastName': 'Menkes',
                        'Login': 'admin'
                      },
                      'Owner': {
                        'ResourceType': 'GeneralUser',
                        'Id': 1,
                        'FirstName': 'Adam',
                        'LastName': 'Menkes',
                        'Login': 'admin'
                      },
                      'LastCommentedUser': null,
                      'LinkedTestPlan': null,
                      'Release': null,
                      'Iteration': null,
                      'TeamIteration': null,
                      'Team': {
                        'ResourceType': 'Team',
                        'Id': 191,
                        'Name': 'Sample Team 1'
                      },
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
                      'ResponsibleTeam': {
                        'ResourceType': 'TeamAssignment',
                        'Id': 5
                      },
                      'Feature': {
                        'ResourceType': 'Feature',
                        'Id': 203,
                        'Name': 'Sample Feature for Sample Epic'
                      },
                      'CustomFields': []
                    },
                    {
                      'ResourceType': 'UserStory',
                      'Id': 204,
                      'Name': 'First Sample User Story',
                      'Description': null,
                      'StartDate': null,
                      'EndDate': null,
                      'CreateDate': '/Date(1493248804000-0500)/',
                      'ModifyDate': '/Date(1493248807000-0500)/',
                      'LastCommentDate': null,
                      'Tags': '',
                      'NumericPriority': 187,
                      'Effort': 0,
                      'EffortCompleted': 0,
                      'EffortToDo': 0,
                      'Progress': 0,
                      'TimeSpent': 0,
                      'TimeRemain': 0,
                      'LastStateChangeDate': '/Date(1493248804000-0500)/',
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
                        'Id': 1,
                        'FirstName': 'Adam',
                        'LastName': 'Menkes',
                        'Login': 'admin'
                      },
                      'Owner': {
                        'ResourceType': 'GeneralUser',
                        'Id': 1,
                        'FirstName': 'Adam',
                        'LastName': 'Menkes',
                        'Login': 'admin'
                      },
                      'LastCommentedUser': null,
                      'LinkedTestPlan': null,
                      'Release': null,
                      'Iteration': null,
                      'TeamIteration': null,
                      'Team': {
                        'ResourceType': 'Team',
                        'Id': 191,
                        'Name': 'Sample Team 1'
                      },
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
                      'ResponsibleTeam': {
                        'ResourceType': 'TeamAssignment',
                        'Id': 4
                      },
                      'Feature': {
                        'ResourceType': 'Feature',
                        'Id': 203,
                        'Name': 'Sample Feature for Sample Epic'
                      },
                      'CustomFields': []
                    }
                  ]
                }

            ";
        }
    }
}
