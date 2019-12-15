using AuthLesson.Models.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AuthLesson.Models
{
    public class Car
    {
        public string Id { get; set; }
        public Car()
        {
            Id = ClassGuid.GetNewGuid();
        }

        public string Wheel { get; set; }
        public int DoorCount { get; set; }
        public string ApplicationUserId { get; set; }
        public virtual ApplicationUser ApplicationUser { get; set; }
    }
}