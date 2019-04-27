using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeDieuHanh.Class
{
    class Datetime
    {
        public static Datetime shared;
        public static Datetime getInstant()
        {
            if (shared == null)
            {
                shared = new Datetime();
            }
            return shared;
        }
    }
}
