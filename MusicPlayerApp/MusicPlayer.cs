using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicPlayerApp
{
    public partial class MusicPlayerApp : Form
    {

        // Global Variables of String Type Array to save the titles or name of tracks and paths
        String[] paths, files;



        public MusicPlayerApp()
        {
            InitializeComponent();
        }

        private void MusicPlayerApp_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            // Close app
            this.Close();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // play music
            axWindowsMediaPlayerMusic.URL = paths[listBoxSongs.SelectedIndex];
        }

        private void btnSelectSongs_Click(object sender, EventArgs e)
        {
            // Selecting song
            OpenFileDialog ofd = new OpenFileDialog();

            // Selecting multiple files
            ofd.Multiselect = true;

            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                files = ofd.SafeFileNames; // Saving names of the track in array
                paths = ofd.FileNames; // Saving paths of the track i narray

                // Display the music titles in listbox
                for (int i = 0; i < files.Length; i++)
                {
                    listBoxSongs.Items.Add(files[i]); // Display songs in listbox
                }
            }
        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {

        }
    }
}
