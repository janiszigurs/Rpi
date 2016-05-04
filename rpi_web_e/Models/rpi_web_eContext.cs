using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace rpi_web_e.Models
{
    public class rpi_web_eContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public rpi_web_eContext() : base("name=rpi_web_eContext")
        {
        }

        public System.Data.Entity.DbSet<rpi_web_e.Models.News> News { get; set; }

        public System.Data.Entity.DbSet<rpi_web_e.Models.Device> Devices { get; set; }
    }
}
