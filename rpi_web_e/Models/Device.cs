using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net;
using System.Net.NetworkInformation;

namespace rpi_web_e.Models
{
    public class Device
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public Guid UniqueID { get; set; }
        public User Owner { get; set; }
        public string Description { get; set; }
        public string DeviceLocation { get; set; }
        public string DefaultEndpointIP { get; set; }
        public string EndpointMAC { get; set; }
        public List<DeviceAccesory> Accessories { get; set; }
    }
}