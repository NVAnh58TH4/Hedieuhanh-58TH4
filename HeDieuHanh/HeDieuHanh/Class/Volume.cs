using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace HeDieuHanh.Class
{
    class Volume
    {
        // Khai báo các tham số hệ thống
        private const int VK_VOLUME_MUTE = 0xAD;
        private const int VK_VOLUME_DOWN = 0xAE;
        private const int VK_VOLUME_UP = 0xAF;

        [DllImport("user32.dll")]
        private static extern void keybd_event(byte bVk, byte bScan, uint dwFlags, int dwExtraInfo);

        public static Volume shared;
        public static Volume getInstant()
        {
            if (shared == null)
            {
                shared = new Volume();
            }
            return shared;
        }

        public void volumeUp()
        {
            keybd_event((byte)VK_VOLUME_UP, 0, 0, 0);
        }

        public void volumeDown()
        {
            keybd_event((byte)VK_VOLUME_DOWN, 0, 0, 0);
        }
        public void mute()
        {
            keybd_event((byte)VK_VOLUME_MUTE, 0, 0, 0);
        }
    }
}
