using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class SessionManager
    {
        public List<Player> Player { get; set; }
        public Deck TheDeck { get; set; }

        public SessionManager(List<Player> iPlayer)
        {
            Player = iPlayer;
            TheDeck = new Deck();
        }

        public void StartNewGame()
        {
            DevideCardsBeetweenPlayers();

        }

        private void DevideCardsBeetweenPlayers()
        {
            for (int i = 0; i < 4; i++)
            {
                foreach (Player player in Player)
                {
                    player.TakeOneCard(TheDeck.TakeAndDropTopFreshCard());
                }
            }
        }

        public void SwapStandCardWithPlayerHandCard(int playerTurnIndex, int indexCardToSwap)
        {
            if (Player[playerTurnIndex].PlayerHandCards.Count == 0)
            {
                Player[playerTurnIndex].TakeOneCard(TheDeck.StandCard);
                TheDeck.StandCard = null;
            }
            else
            {
                TheDeck.StandCard = Player[playerTurnIndex].SwapCardInMyHand(TheDeck.StandCard, indexCardToSwap);
                TheDeck.DropStandCard();
            }
        }

    }
   
}
