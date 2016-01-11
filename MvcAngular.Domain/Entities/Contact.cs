using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvcAngular.Domain.Entities
{
  public partial class Contact
  {
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string ContactNo1 { get; set; }
    public string ContactNo2 { get; set; }
    public string EmailId { get; set; }
    public string Address { get; set; }

  }
}
