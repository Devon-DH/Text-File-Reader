//Name: Devon Henry
//Class: 1322LW02
//Lab12
using System;
using System.IO;


namespace Lassingment11
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            StreamReader sr = null;
            int lines = 0;
            int characters= 0;
            int words= 0;
            string dataline = "";
            string str1;
            //on mac os it seem that it only works if you give the actual file path and not the name ex: /Users/RoyalSkyline 1/Projects/1322Lassingment11/1322Lassingment11/readMe.txt);
            Console.WriteLine("This program gives the number of words, characters and number of lines in a file.");
            try
            {
                Console.WriteLine("Type in the name of the file you want to get information on:");
                string textfile = Console.ReadLine();
                sr = new StreamReader(textfile);
                while (!sr.EndOfStream)
                {

                    lines++;
                    dataline = sr.ReadLine();
                   
                    words++;
                        for (int i = 0; i <dataline.Length; i++)
                        {
                            
                            str1 = dataline.Substring(i, 1);
                            if (str1 == " ")
                               words++;
                        if (str1 != " ")
                        {
                            characters++;
                        }
                    }


                    }
             


                Console.WriteLine("Total lines = " + lines);
                Console.WriteLine("total words = " + words);
                Console.WriteLine("Total chars = " + characters);
                Console.WriteLine("The file statistics are as follows:");
                Console.WriteLine("Total lines = " + lines);
                Console.WriteLine("total words = " + words);
                Console.WriteLine("Total chars = " + characters);

                StreamWriter sw = null;

                    sw = new StreamWriter("output.txt");
                sw.WriteLine("Total lines = " + lines);
                sw.WriteLine("total words = " + words);
               sw.WriteLine("Total chars = " + characters);
                sw.Close();

            }

                catch (FileNotFoundException) {
                Console.WriteLine("File doesn't exist.");
            }

            catch (IOException) {
                Console.WriteLine("File doesn't open.");
            }
            finally  {
                sr.Close();

            }

            }
      

    }
    
}
