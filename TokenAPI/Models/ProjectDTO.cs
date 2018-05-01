using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TokenAPI.Models
{
    public class ProjectDTO
    {
        public int Id { get; set; }
        public String Name { get; set; }
        public String PM { get; set; }
        public String PO { get; set; }
        public List<String> Members { get; set; }
    }
}