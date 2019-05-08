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
            volumeValue = trackBarVolume.Value;
            progressBarBattery.Maximum = 100;
            progressBarBattery.Minimum = 0;

            trackBarVolume.Maximum = 100;
            trackBarVolume.Minimum = 0;

            progressBarBattery.Value = Battery.getInstant().getBatteryLifePercent();
            lblStatePin.Text = Battery.getInstant().getBatteryStatus();
            lblBattery.Text = Battery.getInstant().getPercentBattery();
            lblInternet.Text = Network.getInstant().getStateInternet();
        }

        private void btnMute_Click(object sender, EventArgs e)
        {
            Volume.getInstant().mute();
        }

        /*private void trackBarVolume_Scroll(object sender, EventArgs e)
        {
            Volume.getInstant().volumeUp();
        }*/

        private void timer_Tick(object sender, EventArgs e)
        {
            setupForm();
        }

        private void trackBarVolume_ValueChanged(object sender, EventArgs e)
        {
            int newValue = trackBarVolume.Value;
            if (newValue > volumeValue)
            {
                Volume.getInstant().volumeUp();
            }
            else
            {
                Volume.getInstant().volumeDown();
            }

            volumeValue = newValue;
        }
    }
}
