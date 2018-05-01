using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TokenAPI.Models;

namespace TokenAPI.Controllers
{
    public class TakeoffController : ApiController
    {
        public TakeoffController()
        {
            _user1 = new UserIdentity()
            {
                Id = 1,
                FirstName = "John",
                LastName = "Doe",
                Login = "jDoe",
                Email = "jd@test.com",
                GUID = Guid.NewGuid().ToString()
            };

            _user2 = new UserIdentity()
            {
                Id = 2,
                FirstName = "PM",
                LastName = "manage",
                Login = "Project manager",
                Email = "pm@test.com",
                GUID = Guid.NewGuid().ToString()
            };

            _user3 = new UserIdentity()
            {
                Id = 3,
                FirstName = "PO",
                LastName = "owner",
                Login = "p Owner",
                Email = "po@test.com",
                GUID = Guid.NewGuid().ToString()
            };

            _proj1 = new Project()
            {
                Id = 1,
                Name = "CONST-Coonn",
                PM = _user2,
                PO = _user3,
                Members = new List<UserIdentity>() { _user1, _user2, _user3  }
            };
        }

        // GET: api/Takeoff/User
        [Route("api/takeoff/User")]
        [AcceptVerbs("Get")]
        public UserDTO GetUser()
        {
            var userDto = Mapper.Map<UserDTO>(_user1);
            return userDto;
        }

        [Route("api/takeoff/Project")]
        [AcceptVerbs("Get")]
        public ProjectDTO GetProject()
        {
            return Mapper.Map<ProjectDTO>(_proj1);
        }

        private UserIdentity _user1;
        private UserIdentity _user2;
        private UserIdentity _user3;
        private Project _proj1;

    }
}
