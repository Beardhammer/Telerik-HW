using System;
using System.Text;

namespace _12_ParseUrl
{
    /*Problem 12. Parse URL

    Write a program that parses an URL address given in the format: [protocol]://[server]/[resource] and extracts from it the [protocol], [server] and [resource] elements.

Example:
URL 	Information
http://telerikacademy.com/Courses/Courses/Details/212 	[protocol] = http
[server] = telerikacademy.com
[resource] = /Courses/Courses/Details/212                                                   */
    class ParseUrl
    {
        static void Main()
        {
            Console.Write("Please enter your url and I will extract components from it\n-->");
            string url = Console.ReadLine();
                //@"Https://ExampleSite.com.bg/Studies/C#/Advanced/12";
                //@"http://telerikacademy.com/Courses/Courses/Details/212";

            StringBuilder extractor=new StringBuilder();
            int serverIndex = 0;
            int resourceIndex = 0;

            extractor.Append("[Protocol] = ");      
            for (int i = 0; i < url.Length; i++)    //Extracts until ":" of "://" is reached
            {
                if (url[i] == ':')
                {
                    serverIndex = i+3;
                    break;
                }
                extractor.Append(url[i]);
            }

            extractor.Append("\n[Server] = ");
            for (int i = serverIndex; i < url.Length; i++)  //Keeps extracting until "/" is reached
            {
                if (url[i] == '/')
                {
                    resourceIndex = i;
                    break;
                }
                extractor.Append(url[i]);
            }

            extractor.Append("\n[Resource] = ");
            for (int i = resourceIndex; i < url.Length; i++)    //Extracts everything else
            {
                extractor.Append(url[i]);
            }
            Console.WriteLine(extractor);
        }
    }
}
