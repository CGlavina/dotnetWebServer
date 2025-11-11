using System;
using System.IO;


namespace File.IO
{

    public static class FileFunctions
    {




        public static void ReadFileToConsole(string path)
        {
            StreamReader sr = new StreamReader(path);
            string line;

            while ((line = sr.ReadLine()) != null)
            {
                Console.WriteLine(line);
            }

            Console.WriteLine("\n");

        }

















    }

}