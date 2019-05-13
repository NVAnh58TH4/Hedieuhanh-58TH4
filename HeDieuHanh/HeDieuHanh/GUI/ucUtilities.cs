﻿using System;
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
            nmrHour.Maximum = 24;
            nmrMinute.Maximum = 59;

            prgBattery.Maximum = 100;
            prgBattery.Minimum = 0;  

            prgBattery.Value = Battery.getInstant().getBatteryLifePercent();
            lblStateBattery.Text = Battery.getInstant().getBatteryStatus();
            lblCapacityBattery.Text = Battery.getInstant().getPercentBattery();
            lblStateNetwork.Text = Network.getInstant().getStateInternet();

            lblDatetime.Text = Datetime.getInstant().getTime();
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

        private void btnChangeDateTime_Click(object sender, EventArgs e)
        {
            short year = short.Parse(dtp.Value.Date.Year.ToString());
            short month = short.Parse(dtp.Value.Date.Month.ToString());
            short day = short.Parse(dtp.Value.Date.Day.ToString());
            short hour = short.Parse(nmrHour.Value.ToString());
            short minute = short.Parse(nmrMinute.Value.ToString());
            try
            {
                Datetime.getInstant().setTime(2016, month, day, hour, minute);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnBrowser_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image File|*jpg;*gif;*png";//chọn ảnh
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                txtUrl.Text = ofd.FileName;
                ptb.ImageLocation = ofd.FileName;
            }
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            new Wallpaper(txtUrl.Text).ChangeBackground();
        }
    }
}
