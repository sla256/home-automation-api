using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HomeApi.Models
{
    public class EnvironmentData
    {
        public int EpochDateTime { get; set; }
        public int LocationId { get; set; }
        public float Temperature { get; set; }
        public float Humidity { get; set; }
    }
}