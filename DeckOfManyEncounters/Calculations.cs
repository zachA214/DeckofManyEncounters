﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            int intCR = (int)Math.Round(CR);
            int adder = 0;
            Shuffle(list);

            for(int i = 0, j = 0; i < 1; j++)
            {
                if ((intCR + adder) >= list.Count - 1 || (intCR - adder) < 1)
                {
                    //hmm
                    return encounter;
                }
                if ((intCR + adder) == Convert.ToInt32(Math.Round(list[j].ChallengeRating)) ||
                    (intCR - adder) == Convert.ToInt32(Math.Round(list[j].ChallengeRating)))
                {
                    i++;
                    encounter.AddMonster(list[j]);
                }
                if(j == (list.Count - 1))
                {
                    adder++;
                    Shuffle(list);
                    j = 0;
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
                    if(monsterCR > 1)
                    {
                        monsterCR--;
                    }
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
            CR = (int)Math.Round(CR);
            Encounter encounter = new Encounter { };
            Random rand = new Random();
            Shuffle(list);
            double ogCR = CR;

            int smallGuys = Math.Max(1, (int)Math.Round(CR / 2));
            int num = numEnemies - 1;//max - remaining
            //between 1 and max - remaining
            //loop to get the big guy
            for(int i = 0, j = 0; i<1; j++)
            {
                if (list[j].ChallengeRating == (int)CR)
                {
                    i++;
                    encounter.AddMonster(list[j]);
                }
                if (j == (list.Count - 1))
                {
                    j = 0;
                    Shuffle(list);
                    if (CR > 1)
                    {
                        CR--;
                    }
                }
            }


            //little guys
            int targetCR = Math.Max(1, smallGuys - (num - 1));
            //cr to look for smallGuys - num - 1
            for (int i = 0, j = 0; i < num; j++)
            {
                if ((int)Math.Round(list[j].ChallengeRating) == targetCR)
                {
                    num--;
                    encounter.AddMonster(list[j]);
                    targetCR = Math.Max(1, smallGuys - (Math.Max(0, num - 1)));
                }
                if (j == list.Count - 1)
                {
                    if(targetCR > 1)
                    {
                        targetCR--;
                    }
                    j = 0;
                    Shuffle(list);
                }
            }
            return encounter;
        }

        public static List<Encounter> impossible(List<Monster> list, int enemyCount)
        {
            Encounter encounter = new Encounter();
            List<Encounter> encounterList = new List<Encounter> { };
            Monster temp = new Monster
            {
                Name = "Tarrasque",
                Size = "gargantuan",
                Type = "Monstrosity",
                Alignment = "U",
                AC = 25,
                HP = 676,
                Speed = "40",
                STR = 30,
                DEX = 11,
                CON = 30,
                Intelligence = 3,
                WIS = 11,
                CHA = 11,
                SavThrows = "INT;WIS;CHA",
                Skills = "None",
                WRI = "Fireimmu;poisonimmu;nonmagicalimmu;charmedimmu;frightenedimmu;paralyzedimmu;poisonedimmu",
                Senses = "Blindsight 120",
                Languages = "None",
                ChallengeRating = 30.0,
                Additional = "Legendary;Magic Resistance;Reflective Carapace;Siege Monster",
                Realm = "Monster Manual",
                HasFly = false,
                HasSwim = false };
            /*
            int j = 0;
            Shuffle(list);
            
            for(int i = 0; i < 1;)
            {
                if (list[j].Name == "Tarrasque")
                {
                    i++;
                }
                else if(j == (list.Count - 1))
                {
                    return encounterList;
                }
                else
                {
                    j++;
                }
            }*/
            for (int k = 0; k < enemyCount; k++)
            {
                encounter.AddMonster(temp);
            }
            for (int i = 0; i < 6; i++)
            {
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
