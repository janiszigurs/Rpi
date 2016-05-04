using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace rpi_web_e.Models
{
    public class DeviceAccesory
    {
        public int ID { get; set; }
        public Guid UniqueID { get; set; }
        public Device Device { get; set; }
        public string Type { get; set; } //TODO: ar laiku vajadzētu, kā pre-built types uztaisīt piem models: Temperature, Alarms utt
        public string Description { get; set; }
    }
}