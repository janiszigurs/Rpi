using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace rpi_web_e.Models
{
    public class News
    {
        public int ID { get; set; }
        public DateTime Date { get; set; }
        public string Text { get; set; }
    }
}