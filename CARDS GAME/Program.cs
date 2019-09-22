using System;
using static System.Console;

namespace CARDS_GAME
{
     class Program
    {
        static void Main(string[] args)
        {
            string[] CardNumbers =
            {
                "JS", "KS", "QS", "AS", "2S", "3S", "4S", "5S", "6S", "7S", "8S", "9S", "10S", "JD", "KD", "QD", "AD",
                "2D", "3D", "4D", "5D", "6D", "7D", "8D", "9D", "10D",
                "JF", "KF", "QF", "AF", "2F", "3F", "4F", "5F", "6F", "7F", "8F", "9F", "10F", "JH", "KH", "QH", "AH",
                "2H", "3H", "4H", "5H", "6H", "7H", "8H", "9H", "10H"
            };

            string ValueOfCard;
            var shuffledCards = new string[52];
            int counter = 0;
            while (counter < 52)
            {
                var random = new Random();
                var x = random.Next(0, 52);
                ValueOfCard = CardNumbers[x];
                shuffledCards[counter] = ValueOfCard;
                Write($"{ValueOfCard}, ");
                counter++;
            }

            var DivideCards = shuffledCards[0];
                

            ReadKey();

        }

        
    }
}
