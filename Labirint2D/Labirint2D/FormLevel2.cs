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
    public partial class FormLevel2 : Form
    {
        public FormLevel2()
        {
            InitializeComponent();
        }
        private void start_game()
        {
            label_door.Visible = true;
            label_key.Visible = true;
            Point point = label_start.Location;
            point.Offset(label_start.Width / 2, label_start.Height / 2);
            Cursor.Position = PointToScreen(point);
            label_flash1.Visible = true;
            label_flash2.Visible = false;
            label_flash3.Visible = true;

        }
        private void finish_game()
        {
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void restart_game()
        {
            Sound.play_fail();

            DialogResult dr = MessageBox.Show(
                "Game Over!\nOne more time?", "Lose!!",
                MessageBoxButtons.YesNo);
            if (dr == System.Windows.Forms.DialogResult.Yes)
                start_game();
            else
                this.DialogResult = System.Windows.Forms.DialogResult.Abort;
        }

        private void FormLevel2_Shown(object sender, EventArgs e)
        {
            start_game();
        }

        private void label21_MouseEnter(object sender, EventArgs e)
        {
            restart_game();
        }

        private void label_key_MouseEnter(object sender, EventArgs e)
        {
            label_door.Visible=false;
            label_key.Visible = false;
            Sound.play_key();
        }

        private void label_finish_Click(object sender, EventArgs e)
        {
            finish_game();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            label_flash1.Visible = !label_flash1.Visible;
            label_flash2.Visible = !label_flash2.Visible;
            label_flash3.Visible = !label_flash3.Visible;
        }
    }
}
