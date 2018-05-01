﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TokenAPI.Models
{
    public class UserIdentity
    {
        public Int64 Id { get; set; }
        public String FirstName { get; set; }
        public String LastName { get; set; }
        public String Login { get; set; }
        public String Email { get; set; }
        public String GUID { get; set; }
    }
}