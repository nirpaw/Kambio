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
    public partial class RoomsMenu : Form
    {
        private MenuWizard _menuWizard;
        public RoomsMenu(User iUser)
        {
            _menuWizard = new MenuWizard(iUser);
            InitializeComponent();
            labelUserName.Text = iUser.UserName;
            listBox1.DataSource = _menuWizard.ActiveUsers;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
