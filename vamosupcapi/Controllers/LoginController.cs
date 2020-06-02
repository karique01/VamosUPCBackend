using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using vamosupcapi.Models;
using vamosupcapi.Models.DTO;

namespace vamosupcapi.Controllers
{
    public class LoginController : ApiController
    {
        private vamosupcEntities db = new vamosupcEntities();

        // POST: api/Login
        [ResponseType(typeof(user))]
        public IHttpActionResult Post([FromBody]LoginDTO login)
        {
            user user = db.users.FirstOrDefault(u => u.dni == login.dni && u.password == login.password);
            if (user == null)
            {
                return NotFound();
            }
            if (user.active == false)
            {
                return NotFound();
            }

            return Ok(user);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
