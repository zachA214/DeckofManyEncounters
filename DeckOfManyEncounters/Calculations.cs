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

        //want case for if we make it to end of list and we still need more

        //case for if we only have one monster
        public static Encounter singleMonster(double CR, List<Monster> list)
        {
            Encounter encounter = new Encounter();
            Shuffle(list);

            for(int i = 0, j = 0; i < 1; j++)
            {
                if(CR == list[j].ChallengeRating)
                {
                    i++;
                    encounter.AddMonster(list[j]);
                }
                if(j == list.Count() - 1)
                {
                    j = 0;
                    Shuffle(list);
                    CR--;
                }
            }
            return encounter;
        }
        //method 1: assuming CR already modified by difficulty, given # of enemies (k)
        /*
        Takes max (CR), doubles it, divides by number of creatures, rounds it
        That is the CR of the monsters we pull
        CR 12, 3 monsters. 3 CR 8 monsters
         */
        //edge case for if CR is 1 so we can get enough lower CR combined for this???
        public static Encounter methodOne(double CR, int numEnemies, List<Monster> list)
        {
            Encounter encounter = new Encounter { };
            double mCR = (CR * 2) / numEnemies;
            int monsterCR = (int)Math.Round(mCR);
            Shuffle(list);
            for(int i = 0, j = 0; i < numEnemies; j++)
            {
                if (list[j].ChallengeRating == monsterCR)
                {
                    i++;
                    encounter.AddMonster(list[j]);
                }
                if(j == list.Count - 1)
                {
                    j = 0;
                    Shuffle(list);
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
        public static Encounter methodTwo(double CR, int numEnemies, List<Monster> list)
        {
            Encounter encounter = new Encounter { };
            Random rand = new Random();
            Shuffle(list);

            int smallGuys = (int)Math.Round(CR / 2);
            int num = numEnemies - 1;//max - remaining
            //between 1 and max - remaining
            //loop to get the big guy
            for(int i = 0, j = 0; i<1; j++)
            {
                if (list[j].ChallengeRating == CR)
                {
                    i++;
                    encounter.AddMonster(list[j]);
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
                    encounter.AddMonster(list[j]);
                    targetCR = smallGuys - (num - 1);
                }
                if (j == list.Count - 1)
                {
                    j = 0;
                    Shuffle(list);
                }
            }
            return encounter;
        }

        public static List<Encounter> impossible(List<Monster> list)
        {
            Encounter encounter = new Encounter();
            List<Encounter> encounterList = new List<Encounter> { };
            int j = 0;
            
            for(int i = 0; i < 1;)
            {
                if (list[j].Name == "Tarrasque")
                {
                    i++;
                }
                else if(j == list.Count)
                {
                    return encounterList;
                }
                else
                {
                    j++;
                }
            }
            for(int i = 0; i < 6; i++)
            {
                encounter.AddMonster(list[j]);
                encounterList.Add(encounter);
            }
            return encounterList;
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
