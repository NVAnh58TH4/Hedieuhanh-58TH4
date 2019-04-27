using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace HeDieuHanh.Class
{
    class Network
    {
        [DllImport("wininet.dll")]
        private extern static bool InternetGetConnectedState(out int Description, int ReservedValue);
        //hàm này sẽ trả về true nếu có kết nối internet và false nếu không

        public static Network shared;
        public static Network getInstant()
        {
            if (shared == null)
            {
                shared = new Network();
            }
            return shared;
        }

        public string getStateInternet()
        {
            int des;

            if ((InternetGetConnectedState(out des, 0) == true))
            {
                return "Đang kết nối";
            }

            return "Không kết nối";
        }
    }
}
