using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PickRandomCardUI

{
    class CardPicker
    {
       static Random random =  new Random();
        
        public static string [] pickSomeCards(int numOfCards)
        {
            string[] pickedCards = new string[numOfCards];

            for (int i = 0; i < numOfCards; i++)
            {
                pickedCards[i] = RandomValue() + " of " + RandomSuit();
            }
            return pickedCards;
            
    }

        private static string RandomSuit()
        {
            int value = random.Next(1, 5);
            if (value == 1) return "Spades";
            if (value == 2) return "Heart";
            if (value == 3) return "Club";
            return "Diamonds";
            
             

        }

        private static string RandomValue()
        {
            int value = random.Next(1, 14);
            if (value == 1) return "Ace";
            if (value == 11) return "Jack";
            if (value == 12) return "Queen";
            if (value == 13) return "King";
            return value.ToString();
        }

        
        }
        
    }

