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
        public static extern void GetSystemInfo(out SystemInfo input);

        public enum ProcessorArchitecture
        {
            X86 = 0,
            X64 = 9,
            @Arm = -1,
            Itanium = 6,
            Unknown = 0xFFFF,
        }

        [StructLayout(LayoutKind.Sequential)]

        public struct SystemInfo
        {
            public ProcessorArchitecture ProcessorArchitecture; // WORD
            public uint PageSize; // DWORD
            public IntPtr MinimumApplicationAddress; // (long)void*
            public IntPtr MaximumApplicationAddress; // (long)void*
            public IntPtr ActiveProcessorMask; // DWORD*
            public uint NumberOfProcessors; // DWORD (WTF)
            public uint ProcessorType; // DWORD
            public uint AllocationGranularity; // DWORD
            public ushort ProcessorLevel; // WORD
            public ushort ProcessorRevision; // WORD
        }

        public ucSystemInfor()
        {
            InitializeComponent();
        }

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
                SystemInfoArray[5] = pSI.MinimumApplicationAddress.ToString("X");

                SystemInfoArray[6] = "Maximum Application Address:";
                SystemInfoArray[7] = pSI.MaximumApplicationAddress.ToString("X");

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
