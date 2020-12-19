using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Player01
{
    public partial class AddPlayList : Form
    {
        public AddPlayList()
        {
            InitializeComponent();
        }

        private void titleLabel_Click(object sender, EventArgs e)
        {
            titleLabel.Text = "hellllllloooooooo";
        }

        private void PickMusic_Btn(object sender, EventArgs e)
        {
            if (openMp3FileDialog.ShowDialog() == DialogResult.OK)
            {
                mp3PathTextBox.Text = openMp3FileDialog.FileName;
            }
        }

        private void AlbumArtTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                albumArtPicture.BackgroundImage = Image.FromFile(albumArtTextBox.Text);
            }
            catch (Exception ex)
            {
                albumArtPicture.BackgroundImage = Properties.Resources.no_album_art;
            }
        }

        private void Close_Btn(object sender, EventArgs e)
        {
            ControlBoxBtn Close = new ControlBoxBtn();
            Close.CloseScreen(this);
        }
    }
}
