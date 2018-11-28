using ASPApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASPApp.Areas.Admin.ViewModels
{
    public class UsersIndex
    {
        public IEnumerable<User> Users { get; set; }
    }
}