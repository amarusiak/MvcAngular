﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using MvcAngular.Domain;
using MvcAngular.Models;

namespace MvcAngular.Controllers
{
  public class DataController : Controller
  {
    //
    // GET: /Data/
    //For fetch Last Contact
    //public JsonResult GetLastContact()
    //{
    //  Contact c = null;
    //  //here MyDatabaseEntities our DBContext
    //  using (MyDatabaseEntities dc = new MyDatabaseEntities())
    //  {
    //    c = dc.Contacts.OrderByDescending(a => a.ContactID).Take(1).FirstOrDefault();
    //  }
    //  return new JsonResult { Data = c, JsonRequestBehavior = JsonRequestBehavior.AllowGet };
    //}

    public JsonResult UserLogin(LoginData d)
    {
      using (MyDatabaseEntities dc = new MyDatabaseEntities())
      {
        var user = dc.Users.Where(a => a.Username.Equals(d.Username) && a.Password.Equals(d.Password)).FirstOrDefault();
        return new JsonResult { Data = user, JsonRequestBehavior = JsonRequestBehavior.AllowGet };
      }
    }
  }
}