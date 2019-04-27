using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeDieuHanh.Class
{
    class Music
    {
        public static Music shared;
        public static Music getInstant()
        {
            if (shared == null)
            {
                shared = new Music();
            }
            return shared;
        }
    }
}
