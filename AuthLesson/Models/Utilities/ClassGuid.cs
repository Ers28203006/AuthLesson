using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AuthLesson.Models.Utilities
{
    public class ClassGuid
    {
        public static string GetNewGuid()
        {
            Guid guid = Guid.NewGuid();
            return Convert.ToString(guid);
        }
    }
}