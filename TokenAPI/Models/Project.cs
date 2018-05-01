using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TokenAPI.Models
{
    public class Project
    {
        public int Id { get; set; }
        public String Name { get; set; }
        public UserIdentity PM { get; set; }
        public UserIdentity PO { get; set; }
        public List<UserIdentity> Members { get; set; }
    }
}