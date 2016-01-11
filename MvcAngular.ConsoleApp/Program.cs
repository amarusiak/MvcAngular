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

      //User user1 = new User { Username = "user1", Password = "pass1", FullName = "John Doe" };
      User user1 = new User { Username = "user1", Password = SHA512.Encode("pass1"), FullName = "John Doe" };

      Console.WriteLine(user1.Username);
      Console.WriteLine(user1.Password);
      Console.WriteLine(user1.FullName);

      efUserRepo.SaveUser(user1);
      // ------
        EFContactRepository efContactRepo = new EFContactRepository();

        //User user1 = new User { Username = "user1", Password = "pass1", FullName = "John Doe" };
        Contact contact1 = new Contact { 
          FirstName = "FirstName1", 
          LastName = "LastName1", 
          ContactNo1 = "ContactNo1",
          ContactNo2 = "ContactNo2",
          EmailId = "EmailId",
          Address = "Address"
        };

        Console.WriteLine(contact1.FirstName);
        Console.WriteLine(contact1.LastName);
        Console.WriteLine(contact1.ContactNo1);

        efContactRepo.SaveContact(contact1);

    }
  }
}
