using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                ShowDefault();
            }
            else
            {
                switch (args[0])
                {
                    case "-c":
                        ShowCurrentDirectory();
                        break;
                    case "-f":
                        ShowAllFilesInCurrentDirectory();
                        break;
                    case "-k":
                        ChangeColor();
                        break;
                    case "-d":
                        ShowAlleSubDirsInCurrentDir();
                        break;
                    default:
                        Console.WriteLine("Unknown argument");
                        break;
                }
            }

        }
        static void ShowDefault()
        {
            Console.WriteLine("Current Directory:");
            ShowCurrentDirectory();
            Console.WriteLine("All  Subdirs:");
            ShowAlleSubDirsInCurrentDir();
            Console.WriteLine("All files:");
            ShowAllFilesInCurrentDirectory();
        }
        static void ShowCurrentDirectory()
        {

            Console.WriteLine("Current Directory:" + Directory.GetCurrentDirectory());

        }
        static void ShowAllFilesInCurrentDirectory()
        {

            string[] dirs = Directory.GetFiles(Environment.CurrentDirectory);
            foreach (string dir in dirs)
            {
                Int64 fileSizeInBytes = new FileInfo(dir).Length;
                Console.WriteLine(Path.GetFileName(dir) + "         " + fileSizeInBytes + " bytts");
            }
            Console.WriteLine();
        }
        static void ChangeColor()
        {
            Console.WriteLine("Welke kleur zal ik kiezen?");
            Console.WriteLine("keuze: zwart, magenta en blauw.");
            string kleur = Console.ReadLine();
            switch (kleur)
            {
                case "Zwart":
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.ForegroundColor = ConsoleColor.White;
                    break;

                case "Magenta":
                    Console.BackgroundColor = ConsoleColor.Magenta;
                    Console.ForegroundColor = ConsoleColor.Black;
                    break;
                case "Blauw":
                    Console.BackgroundColor = ConsoleColor.Blue;
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
            }

        }
        static void ShowAlleSubDirsInCurrentDir()
        {

            string[] fileArray = Directory.GetDirectories(Environment.CurrentDirectory);
            for (int i = 0; i < fileArray.Length; i++)
            {

                Console.WriteLine(Path.GetFileName(fileArray[i]));
            }
        }






    }
}

    

