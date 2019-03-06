using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibrary1;

namespace kambio
{
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBoxp3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxp3.Checked)
            {
                textBoxp3.Enabled = true;
            }

            else
            {
                textBoxp3.Enabled = false;
            }
        }

        private void checkBoxp4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxp4.Checked)
            {
                textBoxp4.Enabled = true;
            }

            else
            {
                textBoxp4.Enabled = false;
            }

        }

        private void button_play_Click(object sender, EventArgs e)
        {
            List<Player> lisrPlayers = new List<Player>();
            foreach (var textBox in this.Controls.OfType<TextBox>())
            {
                if (textBox.Enabled)
                {
                    lisrPlayers.Add(new Player(textBox.Text));
                }
            }
            Game game = new Game(lisrPlayers);
            game.ShowDialog();

        }
    }
}
