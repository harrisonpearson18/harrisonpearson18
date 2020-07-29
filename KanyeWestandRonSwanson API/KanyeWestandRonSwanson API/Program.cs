using System;
using System.Net.Http;
using Newtonsoft.Json.Linq;

namespace KanyeWestandRonSwanson_API
{
    class Program
    {
        static void Main(string[] args)
        {

            for(int i = 0; i < 10; i++)
            {
                if (i % 2 == 0)
                {
                    QuoteGenerator.KanyeQuote();
                }
                if (i % 2 == 1)
                {
                    QuoteGenerator.RonQuote();
                }
            }
        }
    }
}
