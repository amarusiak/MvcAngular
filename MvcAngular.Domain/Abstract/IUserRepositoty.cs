using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MvcAngular.Domain.Entities;

namespace MvcAngular.Domain.Abstract
{
  public interface IUserRepositoty
  {
    IEnumerable<User> Users { get; }

    void SaveUser(User user);

    User DeleteUser(int userID);
  }
}
