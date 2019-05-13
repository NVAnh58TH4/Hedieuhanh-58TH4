using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace HeDieuHanh.Class
{
    class Wallpaper
    {
        //khai báo thư viện của hệ thống
        [DllImport("user32.dll", CharSet = CharSet.Auto)]

        private static extern int SystemParametersInfo(int uAction, int uParam, string lpvParam, int fuWinini);

        private const int SPI_SETDESKWALLPAPER = 20; // cài đặt hình ảnh màn hình
        private const int SPIF_SENDWININICHANGE = 0x1; //căng ảnh toàn màn hình 
        private const int SPIF_UPDATEINIFILE = 0x2; // cập nhật hình ảnh 

        //Hàm & biến lấy đường dẫn của ảnh
        public Wallpaper(string url)
        {
            _url = url;
        }

        private string _url;
        public string Url
        {
            get { return _url; }
            set { _url = value; }
        }

        //đổi hình nền bằng đường dẫn ảnh
        public void ChangeBackground()
        {
            SystemParametersInfo(SPI_SETDESKWALLPAPER, 0, _url, SPIF_SENDWININICHANGE);
        }
    }
}
