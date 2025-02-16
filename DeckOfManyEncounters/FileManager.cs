﻿using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeckOfManyEncounters
{
    class FileManager
    {

        public void parseData(string line, string location, int CR, List<Monster> list, bool fly, bool swim, string alignment)//also accept the class array for memory allocation
        {
            //takes the current line in the file, splits it, then inserts it into the monster
            //list if it fits within the CR and is of the desired location
            var fields = line.Split(',');//splits the line into an array, using ',' as the delimiter

            //condition filters out to the enemies that are desired based on CR and location
            if (((location == fields[23] && CR >= Convert.ToDouble(fields[18])) || 
                (location == "Any" && CR >= Convert.ToDouble(fields[18]))) && getAlignment(fields[3], alignment) == 1)
            {
                //Empty conditionals so that we skip past flying or swimming enemies if user wants to omit them
                if (fly == true && Convert.ToBoolean(Convert.ToInt32(fields[24])) == true);
                else if (swim == true && Convert.ToBoolean(Convert.ToInt32(fields[25])) == true);
                else
                {
                    //allocate the memory and input the thing
                    Monster temp = new Monster { };
                    //yay adding the data is so not tedious at all
                    temp.Name = fields[0];
                    temp.Size = fields[1].ToLower();
                    temp.Type = fields[2];
                    temp.Alignment = fields[3];
                    temp.AC = Convert.ToInt32(fields[4]);
                    temp.HP = Convert.ToInt32(fields[5]);
                    temp.Speed = fields[6];
                    temp.STR = Convert.ToInt32(fields[7]);
                    temp.DEX = Convert.ToInt32(fields[8]);
                    temp.CON = Convert.ToInt32(fields[9]);
                    temp.Intelligence = Convert.ToInt32(fields[10]);
                    temp.WIS = Convert.ToInt32(fields[11]);
                    temp.CHA = Convert.ToInt32(fields[12]);
                    temp.SavThrows = fields[13];
                    temp.Skills = fields[14];
                    temp.WRI = fields[15];
                    temp.Senses = fields[16];
                    temp.Languages = fields[17];
                    temp.ChallengeRating = Convert.ToDouble(fields[18]);
                    temp.Additional = fields[19];
                    temp.Realm = fields[23];
                    temp.HasFly = Convert.ToBoolean(Convert.ToInt32(fields[24]));
                    temp.HasSwim = Convert.ToBoolean(Convert.ToInt32(fields[25]));
                    list.Add(temp);
                }
                
            }
        }

        public void readData(string location, int CR, List<Monster> list, bool fly, bool swim, string alignment)
        {
            StreamReader sr = new StreamReader("datafile.csv");
            sr.BaseStream.Seek(0, SeekOrigin.Begin);//start reading the file from the top
            string str = sr.ReadLine();
            str = sr.ReadLine();//omits the first line, which should be the header and starts at the second line
            while(str != null)
            {
                //parsing here
                parseData(str, location, CR, list, fly, swim, alignment);


                //end of loop, last condition
                str = sr.ReadLine();
            }

            sr.Close();

        }

        //getAlignment takes in the al (alignment) and compares it with the desired alignment
        //it returns 1 if the alignment matches, a 0 if it doesn't
        public int getAlignment(string al, string desired)
        {
            int alignment = 0;
            if (al.Contains("E") && desired == "Evil")
            {
                alignment = 1;
            }
            else if(al == "NOT GOOD" && (desired == "Neutral" || desired == "Evil"))
            {
                alignment = 1;
            }
            else if((al == "NOT LAWFUL" || al.Contains("ANY") || al == "U"))
            {
                alignment = 1;
            }
            else if(al.Contains("G") && desired == "Good")
            {
                alignment = 1;
            }
            else if(al.Contains("N") && desired == "Neutral")
            {
                alignment = 1;
            }
            else if(desired == "Any")
            {
                alignment = 1;
            }

                return alignment;
        }
    }

}
