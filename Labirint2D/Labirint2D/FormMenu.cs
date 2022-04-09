using System;
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
            start_level1();
        }

        private void start_level1()
        {


            Sound.play_start();
            FormLevel1 level1 = new FormLevel1();
            DialogResult dr = level1.ShowDialog();
            if (dr == DialogResult.OK)
                start_level2();

        }
        private void start_level2()
        {
            Sound.play_start();
            FormLevel2 level2 = new FormLevel2();
            DialogResult dr = level2.ShowDialog();
            if (dr == DialogResult.OK)
            {
                Sound.play_win();
                MessageBox.Show("WINNN!!","Yeeess!!");
            }

        }


    }


        

    }

