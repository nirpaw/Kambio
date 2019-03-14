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
    public partial class StartingForm : Form
    {
        public StartingForm()
        {
            InitializeComponent();
        }

        private void textBoxUserName_TextChanged(object sender, EventArgs e)
        {
            if (textBoxUserName.Text != String.Empty )
            {
                buttonPlay.Enabled = true;
            }
            else
            {
                buttonPlay.Enabled = false;
            }
        }

        private void buttonPlay_Click(object sender, EventArgs e)
        {
            RoomsMenu roomsMenu = new RoomsMenu(new User(textBoxUserName.Text));
            roomsMenu.ShowDialog();
        }
    }
}
