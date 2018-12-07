using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nobatgir.Util
{
    public static class Extensions
    {
        public static object GetValue(this object obj, string propertyName)
        {
            return obj.GetType().GetProperty(propertyName).GetValue(obj);
        }
    }
}
