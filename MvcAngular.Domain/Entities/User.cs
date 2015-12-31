using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Web.Mvc;
using System.ComponentModel.DataAnnotations;

namespace MvcAngular.Domain.Entities
{
  public partial class User
  {
    [HiddenInput(DisplayValue = false)]
    public int UserID { get; set; }

    [Required(ErrorMessage = "Please enter a Username")]
    public string Username { get; set; }

    [Required(ErrorMessage = "Please specify a Password")]
    public string Password { get; set; }

    public string FullName { get; set; }
  }
}