using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MvcAngular.Domain.Entities;
using MvcAngular.Domain.Abstract;

namespace MvcAngular.Domain.Concrete
{

  public class EFUserRepository : IUserRepositoty
  {
    private MyDatabaseEntities context = new MyDatabaseEntities();

    public IEnumerable<User> Users
    {
      get { return context.Users; }
    }

    public void SaveUser(User user)
    {

      if (user.UserID == 0)
      {
        context.Users.Add(user);
      }
      else
      {
        User dbEntry = context.Users.Find(user.UserID);
        if (dbEntry != null)
        {
          dbEntry.Username = user.Username;
          dbEntry.Password = user.Password;
          dbEntry.FullName = user.FullName;
        }
      }
      context.SaveChanges();
    }

    public User DeleteUser(int userID)
    {
      User dbEntry = context.Users.Find(userID);

      if (dbEntry != null)
      {
        context.Users.Remove(dbEntry);
        context.SaveChanges();
      }
      return dbEntry;
    }
  }
}
