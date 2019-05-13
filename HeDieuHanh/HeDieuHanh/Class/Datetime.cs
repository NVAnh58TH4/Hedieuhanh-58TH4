using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace HeDieuHanh.Class
{
    class Datetime
    {
        [DllImport("Kernel32.dll", SetLastError = true)]// import Kernel32.dll;
        public extern static uint SetSystemTime(ref SYSTEMTIME lpSystemTime);// khai báo hàm api sử dụng;

        public struct SYSTEMTIME  // định nghĩa struct SYSTEMTIME để truyền vào hàm api SetSystemTime;
        {
            public short wYear;// biến lưu năm, có giá trị hợp lệ trong khoảng 1601-30827;
            public short wMonth;// biến lưu tháng, có giá trị hợp lệ trong khoảng 1-12;
            public short wDayOfWeek;// biến lưu ngày trong tuần, có giá trị hợp lệ trong khoảng từ 0-6 tương đương CN-thứ bảy;
            public short wDay;// biến lưu ngày trong tháng, có giá trị hợp lệ trong khoảng 1-31;
            public short wHour;// biến lưu giờ, có giá trị hợp lệ trong khoảng 0-23;
            public short wMinute;// biến lưu phút, có giá trị hợp lệ trong khoảng 0-59;
            public short wSecond;// biến lưu giây, có gía trị hợp lệ trong khoảng 0-59;
            public short wMilliseconds;// biến lưu mili giây, có giá trị hợp lệ trong khoảng 0-999;
        }

        public static Datetime shared;
        public static Datetime getInstant()
        {
            if (shared == null)
            {
                shared = new Datetime();
            }
            return shared;
        }

        public string getTime() // hàm lấy thời gian hiện tại của hệ thống, trả về 1 string;
        {
            return DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss tt");
        }

        public void setTime(short year, short month, short day, short hour, short minute)// hàm đặt thời gian hệ thống; yêu cầu đầu vào theo thứ tự năm, tháng, ngày, giờ, phút
        {
            SYSTEMTIME st = new SYSTEMTIME();// tạo biến kiểu SYSTEMTIME để lưu các giá trị;
            st.wYear = year;
            st.wMonth = month;
            st.wDayOfWeek = 0;
            st.wDay = day;
            st.wHour = hour;
            st.wMinute = minute;
            st.wSecond = 0;
            st.wMilliseconds = 0;
            SetSystemTime(ref st);// truyền các giá trị vào để thay đổi thời gian hệ thống;
        }

    }
}
