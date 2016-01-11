using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using Atlassian.Jira;
using MvcAngular.Domain.Entities;
using System.Threading;

namespace MvcAngular.Controllers
{
    public class IssueController : Controller
    {
            
      //
      // GET: /Issue/
      public ActionResult Index()
      {
          //// create a connection to JIRA using the Rest client
          ////var jira = Jira.CreateRestClient("http://<your_jira_server>", "<user>", "<password>");
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

          List<IssueEntity> listIssueEntity = new List<IssueEntity>();

          foreach (var issueTemp in issues)
          {
            IssueEntity issueEntity = new IssueEntity();

            issueEntity.Project = issueTemp.Project;
            issueEntity.Assignee = issueTemp.Assignee;
            issueEntity.Created = issueTemp.Created;
            issueEntity.Summary = issueTemp.Summary;

            listIssueEntity.Add(issueEntity);
          }

        //return View(issues.ToList());
          return View(listIssueEntity);
      }

      //
      // GET: /Data/
      //For fetch Last Contact
      public JsonResult GetIssues()
      {
        //// create a connection to JIRA using the Rest client
        ////var jira = Jira.CreateRestClient("http://<your_jira_server>", "<user>", "<password>");
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

        List<IssueEntity> listIssueEntity = new List<IssueEntity>();

        foreach (var issueTemp in issues)
        {
          IssueEntity issueEntity = new IssueEntity();

          issueEntity.Project = issueTemp.Project;
          issueEntity.Assignee = issueTemp.Assignee;
          issueEntity.Created = issueTemp.Created;
          issueEntity.Summary = issueTemp.Summary;

          listIssueEntity.Add(issueEntity);
        }
                
        return new JsonResult { Data = listIssueEntity, JsonRequestBehavior = JsonRequestBehavior.AllowGet };
      }


        // GET: /Issue/
        //public ActionResult Index()
        //{
        //    return View();
        //}

        //
        // GET: /Issue/Details/5

        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /Issue/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Issue/Create

        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Issue/Edit/5

        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /Issue/Edit/5

        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Issue/Delete/5

        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /Issue/Delete/5

        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
