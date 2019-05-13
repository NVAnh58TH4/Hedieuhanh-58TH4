using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HeDieuHanh.Class
{
    class TaskManager
    {
        public static TaskManager shared;
        public static TaskManager getInstant()
        {
            if (shared == null)
            {
                shared = new TaskManager();
            }
            return shared;
        }


        //Trả về mảng các tiến trình
        public Process[] getListProcess()
        {
            Process[] listProcess = Process.GetProcesses();
            return listProcess;
        }


        //Khởi tạo ListView
        public ListView setupListView(ListView processlist)
        {
            processlist.Columns.Add("Name");
            processlist.Columns.Add("Process ID");
            processlist.Columns.Add("Username");
            processlist.Columns.Add("Memory usage");
            processlist.Columns.Add("Threads");
            processlist.Columns.Add("Window name");

            processlist.Columns[0].Width = 120;
            processlist.Columns[1].Width = 80;
            processlist.Columns[2].Width = 80;
            processlist.Columns[3].Width = 100;
            processlist.Columns[4].Width = 60;
            processlist.Columns[5].Width = 100;

            return processlist;
        }
    }
}
