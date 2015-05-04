using System;
using System.IO;
using System.Security;

namespace _03_ReadFileContents
{
    /*Problem 3. Read file contents

    Write a program that enters file name along with its full file path (e.g. C:\WINDOWS\win.ini), reads its contents and prints it on the console.
    Find in MSDN how to use System.IO.File.ReadAllText(…).
    Be sure to catch all possible exceptions and print user-friendly error messages.
                                                                                                                        */
    class ReadFileContents
    {
        static void Main()
        {
            Console.Write("Please enter the location of a file, and I'll print it on the console, or I'll handle an exception\nEither way, you win\n-->");

            string x = string.Empty;
            while (true)
            {
                try
                {
                    //Choose one of the two methods for reading files and uncomment it, or I won't print anything good

                    //1st method:
                    //using (StreamReader readFiles = new StreamReader(Console.ReadLine()))
                    //{
                    //    x = readFiles.ReadToEnd();
                    //}

                    //2nd method:
                    //x=File.ReadAllText(Console.ReadLine());

                    Console.WriteLine(x);
                }
                catch (PathTooLongException)    //These are all possible exceptions for File.ReadAllText() and StreamReader.ReadToEnd()
                {
                    Console.WriteLine("The path to the file is too long. Please try again with a shorter path");
                }
                catch (SecurityException)
                {
                    Console.WriteLine("you do not have the permission to access that resource");                    
                }
                catch (NotSupportedException)
                {
                    Console.WriteLine("This functionality is not supported");
                }
                catch (DirectoryNotFoundException)
                {
                    Console.WriteLine("I could not find that directory");
                }
                catch (FileNotFoundException)
                {
                    Console.WriteLine("I could not find that file");
                }
                catch (IOException)
                {
                    Console.WriteLine("Uknown IO exception caught. Really, I have no idea how you managed to get here");    //No idea what to write when a general IO exception occurs
                }
                catch (UnauthorizedAccessException)
                {
                    Console.WriteLine("You either do not have the permissions to do that, or your path is a directory");
                }
                catch (ArgumentNullException)
                {
                    Console.WriteLine("Please do not input empty locations");                    
                }
                catch (ArgumentException)
                {
                    Console.WriteLine("Please enter a non-empty location");
                }
                catch (Exception et)
                {
                    Console.WriteLine("Caught an unhandled exception: "+et.Message);
                    //throw;
                }

                Console.Write("Wanna try again?\n-->");
            }
        }
    }
}
