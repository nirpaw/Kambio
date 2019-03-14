using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FireSharp;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;

namespace ClassLibrary1
{
    public class SessionManager
    {
        public List<Player> Players { get; set; }
        public Deck TheDeck { get; set; }
        public int PlayerTurnIndex { get; set; }
        public int LastGameWinnerIndex { get; set; }
        public int GamesCounter { get; set; }
        public int SessionId { get; set; }

        public SessionManager(List<Player> iPlayers)
        {
            Players = iPlayers;
            GamesCounter = 0;
            SessionId = SessionIdFactory.getId();
      //      setFireBase();
        //    test();
        }


        public void StartNewGame()
        {
            TheDeck = new Deck();
            DevideCardsBeetweenPlayers();
            chooseWhoStart();
        }

        public async void test()
        {
           // SetResponse response = await Client.SetAsync(String.Format("Sessions/Session{0}",SessionId), this);
           // FirebaseResponse response = await Client.UpdateAsync(String.Format("Sessions/Session{0}",SessionId), this);
         //   SessionManager result = response.ResultAs<SessionManager>();

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

        /*
        private IFirebaseConfig _config = new FirebaseConfig
        {
            AuthSecret = "hz1Tc1YPQf5mNTRsd5qLitggAF3hHBlGJ4M0C82V",
            BasePath = "https://kambiotest.firebaseio.com/"

        };

        private IFirebaseClient Client;


        public void setFireBase()
        {
            Client = new FirebaseClient(_config);
            if (Client == null)
            {
                throw new Exception("cant set client");
            }

        }
        */
    }


}
