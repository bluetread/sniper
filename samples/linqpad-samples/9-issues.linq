<Query Kind="Program">
  <NuGetReference>Sniper</NuGetReference>
  <NuGetReference>Sniper.Reactive</NuGetReference>
  <NuGetReference>Rx-Main</NuGetReference>
  <Namespace>Sniper</Namespace>
  <Namespace>Sniper.Reactive</Namespace>
  <Namespace>System</Namespace>
  <Namespace>System.Reactive.Linq</Namespace>
  <Namespace>System.Threading.Tasks</Namespace>
</Query>

async Task Main(string[] args)
{
	var userName = string.Empty;
	GitHubClient client = new GitHubClient(new Sniper.ProductHeaderValue("Sniper.Samples"));
	userName = "naveensrinivasan";
	client.Credentials = new Credentials(Util.GetPassword("github"));

	IIssuesClient issuesclient = client.Issue;
	var myissues = await issuesclient.GetAllForCurrent();
	myissues.Select(m => new { m.Title, m.Body}).Dump();
		
	//var issue = new NewIssue("Test");
	
	//var newissue = await issuesclient.Create(owner,reponame,new NewIssue("Test"));
	//
	//newissue.Dump();
	
	var allissues = await issuesclient.GetAllForRepository("Sniper", "Sniper");
	allissues.Select(a => new { a.Title, a.Body}).Dump();
	
}