using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace vamosupcapi.Models.DTO
{
    public class RegisterDTO
    {
        public int id { get; set; }//
        public string name { get; set; }//
        public int userTypeId { get; set; }//
        public string dni { get; set; }//
        public bool active { get; set; }//
        public string password { get; set; }//

        public user toUser()
        {
            return new user()
            {
                id = id,
                name = name,
                userTypeId = userTypeId,
                dni = dni,
                active = active,
                password = password
            };
        }
    }
}