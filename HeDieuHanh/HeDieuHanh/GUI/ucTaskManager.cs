using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HeDieuHanh.Class;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace HeDieuHanh.GUI
{
    public partial class ucTaskManager : UserControl
    {
        //Huỷ process
        [DllImport("kernel32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
        static extern bool TerminateProcess(IntPtr hProcess, uint uExitCode);

        //Lấy mã thoát của process
        [DllImport("kernel32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
        static extern bool GetExitCodeProcess(IntPtr hProcess, out uint lpExitCode);

        //Lấy ID của process
        [DllImport("user32.dll", SetLastError = true)]
        static extern uint GetWindowThreadProcessId(IntPtr hWnd, out uint lpdwProcessId);

        //Lấy handle của process theo tên cửa sổ chương trình
        [DllImport("user32.dll", SetLastError = true)]
        static extern IntPtr FindWindow(string lpClassName, string lpWindowName);

        //mở process, chỉnh sửa thuộc tính
        [DllImport("kernel32.dll", SetLastError = true)]
        public static extern IntPtr OpenProcess(ProcessAccessFlags processAccess, bool bInheritHandle, int processId);

        //Đóng handle
        [DllImport("kernel32.dll", SetLastError = true)]
        static extern bool CloseHandle(IntPtr hObject);

        TaskManager taskManager;
        private static int processoldcount;
        private static int threadoldcount = 0;
        private static int columnclickcount = 0;
        private static string selectedProcessName;
        private static string selectedProcessWdnName;
        private static IntPtr selectedProcessHandle;

        //Tạo enumerate chứa hành động cho phép thực hiện với process
        public enum ProcessAccessFlags : uint
        {
            All = 0x001F0FFF,
            Terminate = 0x00000001,
            CreateThread = 0x00000002,
            VirtualMemoryOperation = 0x00000008,
            VirtualMemoryRead = 0x00000010,
            VirtualMemoryWrite = 0x00000020,
            DuplicateHandle = 0x00000040,
            CreateProcess = 0x000000080,
            SetQuota = 0x00000100,
            SetInformation = 0x00000200,
            QueryInformation = 0x00000400,
            QueryLimitedInformation = 0x00001000,
            Synchronize = 0x00100000
        }

        public ucTaskManager()
        {
            InitializeComponent();
            ListView lvProcess = new ListView();
            taskManager = new TaskManager();
        }

        //Xoá sạch và tải lại ListView
        private void ucTaskManager_Load(object sender, EventArgs e)
        {
            lvProcess.Items.Clear();
            setupUC();
        }

        //Hiển thị ListView
        private void setupUC()
        {
            taskManager.setupListView(lvProcess);

            showProcessList();
        }

        //Hiện danh sách tiến trình
        private void showProcessList()
        {
            Process[] processList = taskManager.getListProcess();
            processoldcount = processList.Count();
            labelProcessCount.Text = processoldcount.ToString();
            threadoldcount = 0;

            lvProcess.BeginUpdate();

            //Thêm các item mới chứa thông tin của process vào ListView
            foreach (Process instance in processList)
            {
                string[] itemArray = new string[6];
                ListViewItem newitem;

                itemArray[0] = instance.ProcessName;
                itemArray[1] = instance.Id.ToString();
                itemArray[2] = Environment.MachineName;
                itemArray[3] = ((instance.WorkingSet64 / 1024.0).ToString() + " KB");
                itemArray[4] = instance.Threads.Count.ToString();
                itemArray[5] = instance.MainWindowTitle.ToString();

                newitem = new ListViewItem(itemArray);
                lvProcess.Items.Add(newitem);

                threadoldcount += Int32.Parse(itemArray[4]);
            }
            lvProcess.EndUpdate();

            labelThreadCount.Text = threadoldcount.ToString();
        }

        //Xử lý sự kiện click chuột vào cột của ListView, sắp xếp theo tên
        private void lvProcess_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            if (columnclickcount == 0)
            {
                lvProcess.Sorting = SortOrder.Ascending;
                columnclickcount = 1;
            }
            else
            {
                lvProcess.Sorting = SortOrder.Descending;
                columnclickcount = 0;
            }
        }

        //Chọn item của ListView
        private void lvProcess_Click(object sender, EventArgs e)
        {
            selectedProcessName = lvProcess.SelectedItems[0].SubItems[0].Text;
            selectedProcessWdnName = lvProcess.SelectedItems[0].SubItems[5].Text;
            selectedProcessHandle = FindWindow(null, selectedProcessWdnName);
        }


        //Chạy chương trình mới
        private void btnNewProcess_Click(object sender, EventArgs e)
        {
            OpenFileDialog newProcessDialog = new OpenFileDialog();
            newProcessDialog.Filter = "All File|*.*";
            if (newProcessDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    Process.Start(newProcessDialog.FileName);
                }
                catch (Exception exc)
                {
                    MessageBox.Show(exc.Message, "Alert");
                }
            }
        }

        //Dừng chương trình
        private void btnEndProcess_Click(object sender, EventArgs e)
        {
            uint terminatedID;

            //Lấy process id
            GetWindowThreadProcessId(selectedProcessHandle, out terminatedID);

            //Cấp quyền terminate process cho handle
            selectedProcessHandle = OpenProcess(ProcessAccessFlags.Terminate, false, (int)terminatedID);

            string messages = "Do you want to end " + selectedProcessName  + ".exe?";
            string caption = "Alert";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;

            result = MessageBox.Show(messages, caption, buttons);
            if (result == DialogResult.Yes)
            {
                if (selectedProcessWdnName == "")
                {
                    MessageBox.Show("Can not terminate system process", "Alert", MessageBoxButtons.OK);
                }
                else
                {
                    uint exitcode;
                    
                    //Lấy exit code của process
                    GetExitCodeProcess(selectedProcessHandle, out exitcode);

                    //Huỷ process
                    TerminateProcess(selectedProcessHandle, exitcode);

                    //Đóng handle
                    CloseHandle(selectedProcessHandle);
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Process[] newList = taskManager.getListProcess();
            int newcount = newList.Count();

            //Refresh ListView nếu số lượng process thay đổi
            if (newcount != processoldcount)
            {
                lvProcess.Items.Clear();
                showProcessList();
            }

            int newthreadcount = 0;

            //Đếm số lượng thread mới
            foreach (Process instance in newList)
            {
                newthreadcount += instance.Threads.Count;
            }

            labelThreadCount.Text = newthreadcount.ToString();
        }
    }
}
