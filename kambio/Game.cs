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
    public partial class Game : Form
    {
        private readonly SessionManager sessionManager;


        public Game(List<Player>iListOfPlayers)
        {
            InitializeComponent();

            sessionManager = new SessionManager(iListOfPlayers);
        }

        private void button_new_game_Click(object sender, EventArgs e)
        {
            sessionManager.StartNewGame();

        }
    }
}
