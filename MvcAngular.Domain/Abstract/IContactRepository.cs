using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MvcAngular.Domain.Entities;

namespace MvcAngular.Domain.Abstract
{
  public interface IContactRepository
  {
    IEnumerable<Contact> Contacts { get; }

    void SaveContact(Contact contact);

    Contact DeleteContact(int contactID);
  }
}
