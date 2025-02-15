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

        public void parseData(string line, string location, int CR, List<Monster> list)//also accept the class array for memory allocation
        {
            /*
             var fields = line.Split(",");

	        //Process the fields
	        Console.WriteLine($"Processed movie {fields[0]} ({fields[1]})");
             */
            var fields = line.Split(',');
            if (location == fields[23] && CR <= Convert.ToDouble(fields[18]))
            {
                //allocate the memory and input the thing
            }
        }

        public void readData(string location, int CR, List<Monster> list)
        {
            StreamReader sr = new StreamReader("datafile.csv");
            sr.BaseStream.Seek(0, SeekOrigin.Begin);//start reading the file from the top
            //from user input we will filter out options
            string str = sr.ReadLine();
            str = sr.ReadLine();//omits the first line, which should be the header and starts at the second line
            while(str != null)
            {
                //parsing here
                parseData(str, location, CR, list);


                //end of loop, last condition
                str = sr.ReadLine();
            }

            sr.Close();

        }
    }
}
