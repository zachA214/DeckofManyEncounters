using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeckOfManyEncounters
{
    class Calculations
    {
        //list should be filled at this point, we now get to work with it
        //these can take the monster list as an input

        //method 1: assuming CR already modified by difficulty, given # of enemies (k)
        /*
        Takes max (CR), doubles it, divides by number of creatures, rounds it
        That is the CR of the monsters we pull
        CR 12, 3 monsters. 3 CR 8 monsters
         */
        public static List<Monster> methodOne(double CR, int numEnemies, List<Monster> list)
        {
            List<Monster> encounter = new List<Monster> { };
            double monsterCR = (CR * 2) / numEnemies;
            monsterCR = Math.Round(monsterCR);
            Shuffle(list);
            for(int i = 0, j = 0; i < numEnemies; j++)
            {
                if (list[j].ChallengeRating == monsterCR)
                {
                    i++;
                    encounter.Add(list[j]);
                }
            }

            return encounter;
        }

        //method 2:
        /*
         One guy who's best
        One that's equal to max
        One guy with CR 12, leftovers where total CR adds up to 12 (maybe half?)
         */
        public static List<Monster> methodTwo(double CR, int numEnemies, List<Monster> list)
        {
            List<Monster> encounter = new List<Monster> { };
            Random rand = new Random();
            Shuffle(list);

            double smallGuys = Math.Round(CR / 2);
            int num = numEnemies - 1;//max - remaining
            //between 1 and max - remaining
            //loop to get the big guy
            for(int i = 0, j = 0; i<1; j++)
            {
                if (list[j].ChallengeRating == CR)
                {
                    i++;
                    encounter.Add(list[j]);
                }
            }

            //little guys
            double targetCR = smallGuys - (num - 1);
            //cr to look for smallGuys - num - 1
            for (int i = 0, j = 0; i < num; j++)
            {
                if (list[j].ChallengeRating == targetCR)
                {
                    num--;
                    encounter.Add(list[j]);
                    targetCR = smallGuys - (num - 1);
                }
            }
            return encounter;
        }



        private static void Shuffle<T>(List<T> list)
        {
            Random rng = new Random();
            int n = list.Count;
            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                T value = list[k];
                list[k] = list[n];
                list[n] = value;
            }
        }
    }
}
