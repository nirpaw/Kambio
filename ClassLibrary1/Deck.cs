using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Deck
    {

        public List<Card> ListOfFreshCards { get; set; }
        public List<Card> ListOfDroppedCards { get; set; }
        public Boolean LastCardIsPasted { get; set; }
        public Card StandCard { get; set; }

        public Deck()
        {
            setDeckForNewGame();
        }

        public void DropStandCard()
        {
            ListOfDroppedCards.Add(StandCard);
            StandCard = null;
        }
        public void ChooseTopDroppedCard()
        {
            if (!LastCardIsPasted)
            {
                StandCard = ListOfDroppedCards[ListOfDroppedCards.Count - 1];
                removeTopDroppedCard();
            }
            else
            {
                throw new  Exception("You can not choose pasted card");
            }
        }
        private void removeTopDroppedCard()
        {
            ListOfDroppedCards.RemoveAt(ListOfDroppedCards.Count - 1);
        }
        public void ChooseTopFreshCard()
        {
            StandCard = ListOfFreshCards[ListOfFreshCards.Count - 1];
            removeTopFreshCard();
        }
        public Card TakeAndDropTopFreshCard()
        {
            Card takenCard = ListOfFreshCards[ListOfFreshCards.Count - 1];
            removeTopFreshCard();
            return takenCard;
        }

        private void removeTopFreshCard()
        {
            ListOfFreshCards.RemoveAt(ListOfFreshCards.Count - 1);
        }
        private void setDeckForNewGame()
        {
            setAndsShuffleCards();
            ListOfDroppedCards = new List<Card>();
            LastCardIsPasted = false;
        }

        private void setAndsShuffleCards()
        {
            ListOfFreshCards = new List<Card>();
            setCards();
            ShufflleCards();

        }

        public void ShufflleCards()
        {
            Random rng = new Random();

            int n = ListOfFreshCards.Count;
            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                Card value = ListOfFreshCards[k];
                ListOfFreshCards[k] = ListOfFreshCards[n];
                ListOfFreshCards[n] = value;
            }

        }

        private void setCards()
        {
            foreach (eCardSuits suit in Enum.GetValues(typeof(eCardSuits)))
            {
                foreach (eCardRank rank in Enum.GetValues(typeof(eCardRank)))
                {
                    if (rank != eCardRank.Joker)
                    {
                        ListOfFreshCards.Add(new Card(rank, suit));
                    }
                }
            }
            ListOfFreshCards.Add(new Card(eCardRank.Joker, eCardSuits.Diamond));
            ListOfFreshCards.Add(new Card(eCardRank.Joker, eCardSuits.Diamond));
        }
    }
}
