using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using vamosupcapi.Models;
using vamosupcapi.Models.DTO;

namespace vamosupcapi.Controllers
{
    public class usersController : ApiController
    {
        private vamosupcEntities db = new vamosupcEntities();

        // GET: api/users
        public IQueryable<user> Getusers()
        {
            return db.users;
        }

        // GET: api/users/5
        [ResponseType(typeof(user))]
        public IHttpActionResult Getuser(int id)
        {
            user user = db.users.Find(id);
            if (user == null)
            {
                return NotFound();
            }

            return Ok(user);
        }

        //// PUT: api/users/5
        //[ResponseType(typeof(void))]
        //public IHttpActionResult Putuser(int id, user user)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return BadRequest(ModelState);
        //    }

        //    if (id != user.id)
        //    {
        //        return BadRequest();
        //    }

        //    db.Entry(user).State = EntityState.Modified;

        //    try
        //    {
        //        db.SaveChanges();
        //    }
        //    catch (DbUpdateConcurrencyException)
        //    {
        //        if (!userExists(id))
        //        {
        //            return NotFound();
        //        }
        //        else
        //        {
        //            throw;
        //        }
        //    }

        //    return StatusCode(HttpStatusCode.NoContent);
        //}

        // POST: api/users

        [ResponseType(typeof(user))]
        public IHttpActionResult Postuser(RegisterDTO registerUser)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (!userExists(registerUser.dni))
            {
                user userToAdd = registerUser.toUser();
                userToAdd.active = true;
                user userAdded = db.users.Add(userToAdd);
                db.SaveChanges();
                return Ok(userAdded);
            }
            else
            {
                return Conflict();
            }
        }

        //// DELETE: api/users/5
        //[ResponseType(typeof(user))]
        //public IHttpActionResult Deleteuser(int id)
        //{
        //    user user = db.users.Find(id);
        //    if (user == null)
        //    {
        //        return NotFound();
        //    }

        //    db.users.Remove(user);
        //    db.SaveChanges();

        //    return Ok(user);
        //}

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool userExists(string dni)
        {
            return db.users.Count(e => e.dni == dni) > 0;
        }
    }
}