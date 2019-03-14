using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Player
    {
        public User TheUser { get; set; }
        public List<Card> PlayerHandCards { get; set; }

        public Player()
        {
            PlayerHandCards = new List<Card>();
        }

        public Card SwapCardInMyHand(Card standCard, int index)
        {
            Card oldCard = PlayerHandCards[index];
            PlayerHandCards[index] = standCard;
            return oldCard;
        }
        public void TakeOneCard(Card card)
        {
            PlayerHandCards.Add(card);
        }

        
    }
}
