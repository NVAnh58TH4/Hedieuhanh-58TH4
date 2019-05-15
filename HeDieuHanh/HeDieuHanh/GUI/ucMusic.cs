using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace HeDieuHanh.GUI
{
    public partial class ucMusic : UserControl
    {
        public ucMusic()
        {
            InitializeComponent();
        }
        SoundPlayer player = new SoundPlayer();

        private void ucMusic_Load(object sender, EventArgs e)
        {
            
        }

        private void btnBrowser_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "WAV|*.wav", Multiselect = false, ValidateNames = true }) //duyệt thư mục.
                if (ofd.ShowDialog() == DialogResult.OK) // truyền giá trị cho các form.
                    txtUrl.Text = ofd.FileName;
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUrl.Text)) // so sánh NULL.
                return;
            try
            {
                player.SoundLocation = txtUrl.Text;
                player.PlayLooping(); //chơi và lặp file wav, tải lần đầu nếu chưa chọn.
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            player.Stop();
        }

        
    }
}
