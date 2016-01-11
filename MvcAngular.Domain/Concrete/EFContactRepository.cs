using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MvcAngular.Domain.Entities;
using MvcAngular.Domain.Abstract;

namespace MvcAngular.Domain.Concrete
{

  public class EFContactRepository : IContactRepository
  {
    private MyDatabaseEntities context = new MyDatabaseEntities();

    public IEnumerable<Contact> Contacts
    {
      get { return context.Contacts; }
    }

    public void SaveContact(Contact contact)
    {

      if (contact.Id == 0)
      {
        context.Contacts.Add(contact);
      }
      else
      {
        Contact dbEntry = context.Contacts.Find(contact.Id);
        if (dbEntry != null)
        {
          dbEntry.FirstName = contact.FirstName;
          dbEntry.LastName = contact.LastName;
          dbEntry.ContactNo1 = contact.ContactNo1;
          dbEntry.ContactNo2 = contact.ContactNo2;
          dbEntry.EmailId = contact.EmailId;
          dbEntry.Address = contact.Address;

        }
      }
      context.SaveChanges();
    }

    public Contact DeleteContact(int contactID)
    {
      Contact dbEntry = context.Contacts.Find(contactID);

      if (dbEntry != null)
      {
        context.Contacts.Remove(dbEntry);
        context.SaveChanges();
      }
      return dbEntry;
    }
  }
}

