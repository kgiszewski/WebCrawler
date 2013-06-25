using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using FastCache;

namespace Crawler
{
    class Program
    {
        static void Main(string[] args)
        {

            if (args.Length == 0)
            {

                Console.WriteLine("This will crawl and rebuild your cache.  Press any key to continue...");
                Console.ReadLine();

                Console.WriteLine("Enter a domain (i.e. http://mydomain.com)");
                string domain = Console.ReadLine();

                Console.WriteLine("Would you like to build the cache for this domain (" + domain + ") Y/N?");
                string answer = Console.ReadLine();

                if (answer.ToLower() == "y")
                {
                    Console.WriteLine("Building the cache...");
                    Crawl(domain);

                    Console.WriteLine("Complete.  Press any key to exit.");
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Cache not rebuilt.");
                }

            }
            else
            {
                Crawl(args[0]);
            }
        }

        static void Crawl(string domain)
        {
            FastCache.Crawler crawler = new FastCache.Crawler();
            crawler.Crawl(domain);
        }
    }
}
