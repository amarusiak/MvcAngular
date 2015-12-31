using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MvcAngular.Domain.Entities;
using MvcAngular.Domain.Abstract;
using MvcAngular.Domain.Concrete;

namespace MvcAngular.ConsoleApp
{
  class Program
  {
    static void Main(string[] args)
    {
        EFUserRepository efUserRepo = new EFUserRepository();
        User user1 = new User { Username = "user1", Password = "pass1", FullName = "John Doe" };
        efUserRepo.SaveUser(user1);

    }
  }
}
