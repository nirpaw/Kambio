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
        public int PlayerTurnIndex { get; set; }

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
            if (Player[PlayerTurnIndex].PlayerHandCards.Count == 0)
            {
                Player[PlayerTurnIndex].TakeOneCard(TheDeck.StandCard);
                TheDeck.StandCard = null;
            }
            else
            {
                TheDeck.StandCard = Player[playerTurnIndex].SwapCardInMyHand(TheDeck.StandCard, indexCardToSwap);
                TheDeck.DropStandCard();
            }
        }

        public Card WatchOneOfYourCards(int indexCardToWatch)
        {
            Card cardToWatch;
            if (Player[PlayerTurnIndex].PlayerHandCards.Count != 0)
            {
                cardToWatch = Player[PlayerTurnIndex].PlayerHandCards[indexCardToWatch];
            }
            else
            {
                cardToWatch = null;
            }

            return cardToWatch;
        }

        public Card WatchOnOfOtherPlayerCards(int indexOtherPlayer, int indexCardToWatch)
        {
            return Player[indexOtherPlayer].PlayerHandCards[indexCardToWatch];
        }

        public void BlindSwap(int indexOtherPlayer, int indexMyCard, int indexOtherCard)
        {
            Card temp = Player[PlayerTurnIndex].PlayerHandCards[indexMyCard];
            Player[PlayerTurnIndex].PlayerHandCards[indexMyCard] = Player[indexOtherPlayer].PlayerHandCards[indexOtherCard];
            Player[indexOtherPlayer].PlayerHandCards[indexOtherCard] = temp;
        }

    }
   
}
