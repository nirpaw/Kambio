using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{

    public class Card
    {
        public eCardRank Rank { get; set; }
        public eCardSuits Suit { get; set; }
        public int CardValue { get; set; }

        public Card(eCardRank iRank, eCardSuits iSuite)
        {
            Rank = iRank;
            Suit = iSuite;
            CardValue = getCardRealValue();
        }

        private int getCardRealValue()
        {
            int realValue;
            // Special value cards
            if (Rank == eCardRank.Joker)
            {
                realValue = 0;
            }

            else if (Rank == eCardRank.King && (Suit == eCardSuits.Heart || Suit == eCardSuits.Diamond))
            {
                realValue = -1;
            }

            //Simple value cards
            else if ((int)Rank > 10)
            {
                realValue = 10;
            }
            else
            {
                realValue = (int)Rank;
            }

            return realValue;
        }


        public override string ToString()
        {
            return string.Format("{0} {1}", Rank.ToString(), Suit.ToString());
        }
    }
}

public enum eCardSuits
{
    Spade, // ale
    Heart,
    Diamond,
    Club, // tiltan
}

public enum eCardRank
{
    Joker, Ace , Two, Tree, Four, Five, Six, Seven, Eight, Nine, Ten,
    Jack, Queen, King 
}

