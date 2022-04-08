using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Labirint2D
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BoxSound_CheckedChanged(object sender, EventArgs e)
        {
            if (BoxSound.Checked)
            {
                BoxSound.Text = "Sound On";
                Sound.sound_on();
            }
            else
            {
                BoxSound.Text = "Sound Off";
                Sound.sound_off();
            }
            Sound.play_key(); 
            
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            Sound.play_start();
        }
    }
}
