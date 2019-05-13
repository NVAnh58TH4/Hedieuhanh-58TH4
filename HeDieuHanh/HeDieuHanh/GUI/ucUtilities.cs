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

namespace HeDieuHanh.GUI
{
    public partial class ucUtilities : UserControl
    {
        static int volumeValue;

        public ucUtilities()
        {
            InitializeComponent();
        }

        public bool _runThread = true;

        private void ucUtilities_Load(object sender, EventArgs e)
        {
            setupForm();

        }

        void setupForm()
        {
            prgBattery.Maximum = 100;
            prgBattery.Minimum = 0;

            prgBattery.Value = Battery.getInstant().getBatteryLifePercent();
            lblStateBattery.Text = Battery.getInstant().getBatteryStatus();
            lblCapacityBattery.Text = Battery.getInstant().getPercentBattery();
            lblStateNetwork.Text = Network.getInstant().getStateInternet();
        }

        /*private void trackBarVolume_Scroll(object sender, EventArgs e)
        {
            Volume.getInstant().volumeUp();
        }*/

        private void timer_Tick(object sender, EventArgs e)
        {
            setupForm();
        }

        private void btnVolumeUp_Click(object sender, EventArgs e)
        {
            Volume.getInstant().volumeUp();
        }

        private void btnVolumeDown_Click(object sender, EventArgs e)
        {
            Volume.getInstant().volumeDown();
        }

        private void btnMute_Click(object sender, EventArgs e)
        {
            Volume.getInstant().mute();
        }
    }
}
