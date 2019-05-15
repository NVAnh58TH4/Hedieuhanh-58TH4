using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HeDieuHanh.Class
{
    class Battery
    {
        [DllImport("user32.dll", EntryPoint = "MessageBox")]
        public static extern int MessageBox(int hwnd, string lpText, string lpCaption, int wType); //Hiển thị hộp thoại

        //Lấy thông tin pin
        PowerStatus powerStatus = SystemInformation.PowerStatus;

        public static Battery shared;
        public static Battery getInstant()
        {
            if (shared == null)
            {
                shared = new Battery();
            }
            return shared;
        }

        public int getBatteryLifePercent()
        {
            int capacityBattery = (int)(powerStatus.BatteryLifePercent * 100);
            return capacityBattery;
        }

        public string getBatteryStatus()
        {
            string batteryStatus = "";
            switch (powerStatus.PowerLineStatus)
            {
                case PowerLineStatus.Offline:
                    batteryStatus = "Dùng pin";
                    break;
                case PowerLineStatus.Online:
                    batteryStatus = "Đang sạc";
                    break;
                default:
                    batteryStatus = "Tình trạng không rõ";
                    break;
            }
            return batteryStatus;
        }

        public string getPercentBattery()
        {
            return ((int)(powerStatus.BatteryLifePercent * 100)).ToString() + "%";
        }
    }
}
