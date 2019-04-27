using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace HeDieuHanh.Class
{
    class Batery
    {
        [DllImport("user32.dll", EntryPoint = "MessageBox")]
        public static extern int MessageBox(int hwnd, string lpText, string lpCaption, int wType);
        static var shared = Batery();
        //public static shared = Batery();
        void getCapacityBatery()
        {

        }
    }
}
