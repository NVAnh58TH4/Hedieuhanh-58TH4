using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace HeDieuHanh.GUI
{
    public partial class ucSystemInfor : UserControl
    {
        [DllImport("kernel32.dll")]
        public static extern void GetSystemInfo(out SystemInfo input); //Lấy thông tin CPU

        //Kiểu dữ liệu tự định nghĩa về kiến trúc của CPU
        public enum ProcessorArchitecture
        {
            X86 = 0,
            X64 = 9,
            @Arm = -1,
            Itanium = 6,
            Unknown = 0xFFFF,
        }

        [StructLayout(LayoutKind.Sequential)]

        //Kiểu dữ liệu tổng hợp thông tin CPU
        public struct SystemInfo
        {
            public ProcessorArchitecture ProcessorArchitecture; //Kiến trúc
            public uint PageSize; // Kích cỡ trang
            public IntPtr MinimumApplicationAddress; // Kích cỡ ứng dụng tối thiểu
            public IntPtr MaximumApplicationAddress; // Kích cỡ ứng dụng tối đa
            public IntPtr ActiveProcessorMask;
            public uint NumberOfProcessors; //Số bộ xử lý
            public uint ProcessorType; // Loại bộ xử lý
            public uint AllocationGranularity;
            public ushort ProcessorLevel;
            public ushort ProcessorRevision;
        }

        public ucSystemInfor()
        {
            InitializeComponent();
        }


        // Thêm thông tin vào listbox
        private void btnShow_Click(object sender, EventArgs e)
        {
            try
            {
                listBox1.Items.Clear();
                SystemInfo pSI = new SystemInfo();
                GetSystemInfo(out pSI);

                string[] SystemInfoArray = new string[20];
                SystemInfoArray[0] = "Processor Architecture:";
                SystemInfoArray[1] = pSI.ProcessorArchitecture.ToString();

                SystemInfoArray[2] = "Page Size:";
                SystemInfoArray[3] = pSI.PageSize.ToString();

                SystemInfoArray[4] = "Minimum Application Address:";
                SystemInfoArray[5] = Convert.ToInt32(pSI.MinimumApplicationAddress.ToString("X"), 16).ToString();

                SystemInfoArray[6] = "Maximum Application Address:";
                SystemInfoArray[7] = Convert.ToInt64(pSI.MaximumApplicationAddress.ToString("X"), 16).ToString();

                SystemInfoArray[8] = "Active Processor Mask:";
                SystemInfoArray[9] = pSI.ActiveProcessorMask.ToString();

                SystemInfoArray[10] = "Number Of Processor:";
                SystemInfoArray[11] = pSI.NumberOfProcessors.ToString();

                SystemInfoArray[12] = "Processor Type:";
                SystemInfoArray[13] = pSI.ProcessorType.ToString();

                SystemInfoArray[14] = "Allocation Granularity";
                SystemInfoArray[15] = pSI.AllocationGranularity.ToString();

                SystemInfoArray[16] = "Processor Level:";
                SystemInfoArray[17] = pSI.ProcessorLevel.ToString();

                SystemInfoArray[18] = "Processor Revision:";
                SystemInfoArray[19] = pSI.ProcessorRevision.ToString();

                listBox1.Items.AddRange(SystemInfoArray);
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
        }
    }
}
