using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeckOfManyEncounters
{
    class FileManager
    {

        public void parseData(string line)//also accept a struct as a parameter
        {
            /*
             var fields = line.Split(",");

	        //Process the fields
	        Console.WriteLine($"Processed movie {fields[0]} ({fields[1]})");
             */



        }

        public void readData()
        {
            StreamReader sr = new StreamReader("datafile.csv");
            sr.BaseStream.Seek(0, SeekOrigin.Begin);//start reading the file from the top
            //from user input we will filter out options
            string str = sr.ReadLine();
            while(str != null)
            {
                //parsing here
                parseData(str);


                //end of loop, last condition
                str = sr.ReadLine();
            }

            sr.Close();

        }
    }
}
