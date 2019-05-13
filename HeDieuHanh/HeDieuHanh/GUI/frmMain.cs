using HeDieuHanh.Class;
using HeDieuHanh.GUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HeDieuHanh
{
    public partial class frmMain : Form
    {
        ucTaskManager ucTaskManager = new ucTaskManager();
        ucMusic ucMusic = new ucMusic();
        ucUtilities ucUtilities = new ucUtilities();
        ucSystemInfor ucSystemInfor = new ucSystemInfor();

        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            setupForm();
        }

        void setupForm()
        {
            displayUcOnPanel(ucUtilities);
            //displayUcOnPanel(ucTaskManager);
        }


        private void btnTaskManager_Click(object sender, EventArgs e)
        {
            displayUcOnPanel(ucTaskManager);
        }

        private void btnMusic_Click(object sender, EventArgs e)
        {
            
            displayUcOnPanel(ucMusic);
        }

        private void btnUtility_Click(object sender, EventArgs e)
        {
            displayUcOnPanel(ucUtilities);
        }

        private void btnSystemInfor_Click(object sender, EventArgs e)
        {
            displayUcOnPanel(ucSystemInfor);
        }

        private void trackBarVolume_Scroll(object sender, EventArgs e)
        {
            Volume.getInstant().volumeUp();
        }

        void displayUcOnPanel(UserControl userControl)
        {
            pnDisplay.Controls.Clear();
            pnDisplay.Refresh();
            pnDisplay.Controls.Add(userControl);
            userControl.Dock = DockStyle.Fill;
        }

        
    }
}
