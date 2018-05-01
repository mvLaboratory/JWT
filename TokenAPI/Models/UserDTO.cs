using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TokenAPI.Models
{
    public class UserDTO
    {
        public Int64 Id { get; set; }
        public String Login { get; set; }
        public String Email { get; set; }
        public String GUID { get; set; }
    }
}