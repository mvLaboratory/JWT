using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TokenAPI.Core;

namespace TokenAPI.Controllers
{
    [Route("api/token/{action}")]
    public class TokenController : ApiController
    {
        [HttpGet] [ActionName("generate")]
        public IHttpActionResult Index()
        {
            return Ok(_tokenFactory.Generate());
        }

        [HttpPost] [ActionName("validate")]
        [Route("api/token/validate")]
        public IHttpActionResult Validate([FromBody]String param)
        {
            _tokenFactory.Validate(param);
            return Ok();
        }

        TokenFactory _tokenFactory = new TokenFactory();
    }
}
