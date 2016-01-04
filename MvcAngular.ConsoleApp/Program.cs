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

  public class Program
  {
    public static void Main(string[] args)
    {
        EFUserRepository efUserRepo = new EFUserRepository();
        User user1 = new User { Username = "user1", Password = "pass1", FullName = "John Doe" };
        //User user1 = new User { Username = "user1", Password = SHA512.Encode("pass1"), FullName = "John Doe" };

        efUserRepo.SaveUser(user1);

    }
  }
}
