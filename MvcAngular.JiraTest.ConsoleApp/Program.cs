using Atlassian.Jira;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvcAngular.JiraTest.ConsoleApp
{
  class Program
  {
    static void Main(string[] args)
    {
      // create a connection to JIRA using the Rest client
      //var jira = Jira.CreateRestClient("http://<your_jira_server>", "<user>", "<password>");
      var jiraClient = Jira.CreateRestClient("http://ssu-jira.softserveinc.com",
        "amarutc", "ii(41iGZ");

      // use LINQ syntax to retrieve issues
      //var issues = from i in jiraClient.Issues
      //             where i.Assignee == "admin" && i.Priority == "Major"
      //             orderby i.Created
      //             select i;

      var issues = from i in jiraClient.Issues
                   //where i.Assignee == "admin" && i.Priority == "Major"
                   where i.Project == "Rv-015.Net" 
                   //&& ( (i.Assignee == "Mykhailo Omel'chuk") || (i.Assignee == "Oleksandr Feodruk") )
                   orderby i.Created
                   select i;

      foreach (var issueTemp in issues)
      {
        Console.WriteLine();
        Console.Write((issueTemp.Project != null) ? issueTemp.Project.ToString() + '\t' : "" + '\t');
        
        //Console.Write(issueTemp.Assignee.ToString() + '\t');
        Console.Write(issueTemp.Created.ToString() + '\t');
        //Console.Write(issueTemp.DueDate.ToString() + '\t'); // ok
        //Console.Write(issueTemp.Key.ToString() + '\t');
        //Console.Write(issueTemp.Priority.ToString() + '\t');  // ok
        //Console.Write(issueTemp.Project.ToString() + '\t');
        //Console.Write(issueTemp.Key.ToString() + '\t');
        //Console.Write(issueTemp.Reporter.ToString() + '\t');
        //Console.Write(issueTemp.Resolution.ToString() + '\t');
        Console.Write(issueTemp.Status.ToString() + '\t');
        Console.Write(issueTemp.Summary.ToString() + '\t');
        //Console.Write(issueTemp.Type.ToString() + '\t');  //  ok
        //Console.Write(issueTemp.Updated.ToString() + '\t'); //  ok
        //Console.Write(issueTemp.Votes.ToString() + '\t'); //  ok
      }
    }
  }
}
