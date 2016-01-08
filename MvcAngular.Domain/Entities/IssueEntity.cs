using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Atlassian.Jira;

namespace MvcAngular.Domain.Entities
{
  public partial class IssueEntity
  {

    public string Project { get; set; }

    public string Assignee { get; set; }
    public DateTime? Created { get; set; }
    //public int Status { get; set; }
    public string Summary { get; set; }

  }
}
