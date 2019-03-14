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
    public partial class Form1 : Form
    {
        private readonly SessionManager sessionManager ;
        public Form1()
        {
            InitializeComponent();
            Player p1 = new Player();
            Player p2 = new Player();
            sessionManager = new SessionManager(new List<Player>(){p1, p2}, "test");
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            sessionManager.StartNewGame();
            reffreshListBoxFresh();
            listBoxPlayer1.DataSource = new BindingSource(sessionManager.Players[0].PlayerHandCards, null);
            listBoxPlayer2.DataSource = new BindingSource(sessionManager.Players[1].PlayerHandCards, null);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (listBoxStand.Items.Count == 0)
            {
                sessionManager.TheDeck.ChooseTopFreshCard();
                listBoxStand.DataSource = new BindingSource(sessionManager.TheDeck.StandCard, null);
                reffreshListBoxFresh();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listBoxStand.Items.Count == 0)
            {
                sessionManager.TheDeck.ChooseTopDroppedCard();
                listBoxStand.DataSource = new BindingSource(sessionManager.TheDeck.StandCard, null);
                reffreshListBoxDropped();
            }
        }

        private void reffreshStand()
        {
            listBoxStand.DataSource = new BindingSource(sessionManager.TheDeck.StandCard, null);

        }

        private void reffreshPlayerLists()
        {
            listBoxPlayer1.DataSource = new BindingSource(sessionManager.Players[0].PlayerHandCards, null);
            listBoxPlayer2.DataSource = new BindingSource(sessionManager.Players[1].PlayerHandCards, null);

        }
        private void reffreshListBoxFresh()
        {
            listBoxFrsehCards.DataSource = new BindingSource(sessionManager.TheDeck.ListOfFreshCards, null);
            label1.Text = listBoxFrsehCards.Items.Count.ToString();
        }
        private void reffreshListBoxDropped()
        {
            listBoxDropped.DataSource = new BindingSource(sessionManager.TheDeck.ListOfDroppedCards, null);
        }
        private void button4_Click(object sender, EventArgs e)
        {
            if (listBoxStand.Items.Count != 0)
            {
                sessionManager.TheDeck.DropStandCard();
                reffreshListBoxDropped();
                listBoxStand.DataSource = new BindingSource(sessionManager.TheDeck.StandCard, null);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int selectedCardIndex = listBoxPlayer1.SelectedIndex;
            sessionManager.SwapStandCardWithPlayerHandCard(0, selectedCardIndex);
            reffreshListBoxDropped();
            reffreshListBoxFresh();
            reffreshPlayerLists();
            reffreshStand();
     
        }

        private void buttonDoAction_Click(object sender, EventArgs e)
        {
            int mySelectedCard = listBoxPlayer1.SelectedIndex;
            int otherSelectedCard = listBoxPlayer2.SelectedIndex;
            if (sessionManager.TheDeck.StandCard.Rank == eCardRank.Seven ||
                sessionManager.TheDeck.StandCard.Rank == eCardRank.Eight)
            {
                labelWatch.Text = sessionManager.WatchOneOfYourCards(mySelectedCard).ToString();
            }

            if (sessionManager.TheDeck.StandCard.Rank == eCardRank.Nine ||
                sessionManager.TheDeck.StandCard.Rank == eCardRank.Ten)
            {
                labelWatch.Text = sessionManager.WatchOnOfOtherPlayerCards(1, otherSelectedCard).ToString();
            }

            if (sessionManager.TheDeck.StandCard.Rank == eCardRank.Jack ||
                sessionManager.TheDeck.StandCard.Rank == eCardRank.Queen)
            {
                sessionManager.BlindSwap(1, mySelectedCard , otherSelectedCard);
            }

            reffreshListBoxDropped();
            reffreshListBoxFresh();
            reffreshPlayerLists();
            reffreshStand();
           
        }
    }
}
