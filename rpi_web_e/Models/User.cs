using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace rpi_web_e.Models
{
    public class User
    {
        public int ID { get; set; }
        public Guid UniqueID { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string EmailAddress { get; set; }


        //public bool IsAdministrator { get; set; } //may not be required

    }
}