using System;
using System.IO;
using System.Runtime.InteropServices;
using File.IO;


namespace EntryPointNamespace
{
    class EntryPoint
    {

        static void Main(string[] args)
        {


            Console.WriteLine("Starting the webserver App\n");

            string basePath = "c:/src/TextRessources/";


            //Console.WriteLine("Starting the webserver App\n");
            while (true)
            {
                try
                {
                    Console.Write("Enter file name of a ressources to read: ");
                    string ressourcePath = Console.ReadLine();
                    string path = basePath + ressourcePath;
                    FileFunctions.ReadFileToConsole(path);
                }
                catch (Exception e)
                {
                    Console.WriteLine("Error: " + e);
                }
            }

        }



    }
}

