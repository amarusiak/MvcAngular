using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using MvcAngular.Domain.Entities;
using MvcAngular.Domain.Abstract;
using MvcAngular.Domain.Concrete;
using MvcAngular.Models;

namespace MvcAngular.Controllers
{
  public class SHA512
  {
    public static string Encode(string value)
    {
      var hash = System.Security.Cryptography.SHA512.Create();

      var encoder = new System.Text.ASCIIEncoding();

      var combined = encoder.GetBytes(value ?? "");

      return BitConverter
        .ToString(hash.ComputeHash(combined))
        .ToLower()
        .Replace("-", "");
    }
  }


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
      //{
      //  EFUserRepository efUserRepo = new EFUserRepository();
      //  User user1 = new User { Username = "user1", Password = "pass1", FullName = "John Doe" };
      //  efUserRepo.SaveUser(user1);
      //}

      //
      using (MyDatabaseEntities dc = new MyDatabaseEntities())
      {
        //var user = dc.Users.Where(a => a.Username.Equals(d.Username) && a.Password.Equals(d.Password)).FirstOrDefault();

        //  SHA Encode branch
        string passFromUI = SHA512.Encode(d.Password);
        var user = dc.Users.
          Where(a => (a.Username.Equals(d.Username) && a.Password.Equals(passFromUI))).
          FirstOrDefault();
                
        //string passFromDB = dc.Users.Where(a => a.Username.Equals(d.Username)).FirstOrDefault().Password;
        //var user = dc.Users.Where(a => (a.Username.Equals(d.Username) && (passFromDB == passFromUI)) ).FirstOrDefault();
        
        return new JsonResult { Data = user, JsonRequestBehavior = JsonRequestBehavior.AllowGet };
      }
    }
  }
}
