<Query Kind="Program">
  <NuGetReference>Sniper</NuGetReference>
  <NuGetReference>Sniper.Reactive</NuGetReference>
  <NuGetReference>Rx-Main</NuGetReference>
  <Namespace>Sniper</Namespace>
  <Namespace>System.Reactive.Linq</Namespace>
  <Namespace>System.Threading.Tasks</Namespace>
</Query>

async Task Main(string[] args)
{
	var owner = string.Empty;
	var reponame = string.Empty;
	
	owner = "Sniper";
	reponame = "Sniper";
	
	var client = new GitHubClient(new Sniper.ProductHeaderValue("Sniper.samples"));
	
	var repository = await client.Repository.Get(owner, reponame);
	
	Console.WriteLine(String.Format("Sniper can be found at {0}\n", repository.HtmlUrl));
	
	Console.WriteLine("It currently has {0} watchers and {1} forks\n", 
		repository.StargazersCount,
	    repository.ForksCount);
	
	Console.WriteLine("It has {0} open issues\n", repository.OpenIssuesCount);
	
	Console.WriteLine("And GitHub thinks it is a {0} project", repository.Language);

}