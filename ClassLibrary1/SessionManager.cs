using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class SessionManager
    {
        public List<Player> Players { get; set; }
        public Deck TheDeck { get; set; }
        public int PlayerTurnIndex { get; set; }
        public int LastGameWinnerIndex { get; set; }
        public int GamesCounter { get; set; }

        public SessionManager(List<Player> iPlayers)
        {
            Players = iPlayers;
            GamesCounter = 0;
        }

        public void StartNewGame()
        {
            TheDeck = new Deck();
            DevideCardsBeetweenPlayers();
            chooseWhoStart();
        }

        private void chooseWhoStart()
        {
            if (GamesCounter == 0)
            {
                PlayerTurnIndex = 0; // TODO: choose randomly instead of 0
            }
            else
            {
                PlayerTurnIndex = LastGameWinnerIndex;
            }
        }

        private void DevideCardsBeetweenPlayers()
        {
            for (int i = 0; i < 4; i++)
            {
                foreach (Player player in Players)
                {
                    player.TakeOneCard(TheDeck.TakeAndDropTopFreshCard());
                }
            }
        }

        public void SwapStandCardWithPlayerHandCard(int playerTurnIndex, int indexCardToSwap)
        {
            if (Players[PlayerTurnIndex].PlayerHandCards.Count == 0)
            {
                Players[PlayerTurnIndex].TakeOneCard(TheDeck.StandCard);
                TheDeck.StandCard = null;
            }
            else
            {
                TheDeck.StandCard = Players[playerTurnIndex].SwapCardInMyHand(TheDeck.StandCard, indexCardToSwap);
                TheDeck.DropStandCard();
            }
        }

        public Card WatchOneOfYourCards(int indexCardToWatch)
        {
            Card cardToWatch;
            if (Players[PlayerTurnIndex].PlayerHandCards.Count != 0)
            {
                cardToWatch = Players[PlayerTurnIndex].PlayerHandCards[indexCardToWatch];
            }
            else
            {
                cardToWatch = null;
            }

            return cardToWatch;
        }

        public Card WatchOnOfOtherPlayerCards(int indexOtherPlayer, int indexCardToWatch)
        {
            return Players[indexOtherPlayer].PlayerHandCards[indexCardToWatch];
        }

        public void BlindSwap(int indexOtherPlayer, int indexMyCard, int indexOtherCard)
        {
            Card temp = Players[PlayerTurnIndex].PlayerHandCards[indexMyCard];
            Players[PlayerTurnIndex].PlayerHandCards[indexMyCard] = Players[indexOtherPlayer].PlayerHandCards[indexOtherCard];
            Players[indexOtherPlayer].PlayerHandCards[indexOtherCard] = temp;
        }

    }
   
}
