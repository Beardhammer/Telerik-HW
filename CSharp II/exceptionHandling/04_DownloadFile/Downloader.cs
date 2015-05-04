using System;
using System.Net;

namespace _04_DownloadFile
{
    /*Problem 4. Download file

    Write a program that downloads a file from Internet (e.g. Ninja image) and stores it the current directory.
    Find in Google how to download files in C#.
    Be sure to catch all exceptions and to free any used resources in the finally block.
                                                                                                                */
    class Downloader
    {
        static void Main()
        {
            Console.Write("Please enter a valid file url, and I'll download it to my current directory\n-->");
            while (true)
            {
                WebClient downloader = new WebClient();
                try
                {
                    downloader.DownloadFile(Console.ReadLine(), @"..\..\..\NinjaImage.png");
                }
                catch (WebException)
                {
                    Console.WriteLine("I could not find that file");
                }
                catch (UnauthorizedAccessException)
                {
                    Console.WriteLine("You don't seem to have access to that...Are you trying to make me a criminal?!");
                }
                catch (ArgumentException)
                {
                    Console.WriteLine("Mate, your url is umm... uhh erm EMPTY DAMNIT!");
                }
                catch (NotSupportedException)
                {
                    Console.WriteLine("I do not support that operation");
                }
                catch (Exception)
                {
                    Console.WriteLine("Congratulations. You leveled up! Do you want to become a level 67 virgin? y/n");
                }
                finally
                {
                    downloader.Dispose();
                }
                Console.Write("Do you vvant to try with another url?\n-->");
            }
        }
    }
}
