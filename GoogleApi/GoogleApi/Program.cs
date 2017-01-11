using Google.Apis.Customsearch.v1.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;

//GOOGLE SEARCH API
namespace GoogleApi
{
    class Program
    {
        static void Main(string[] args)
        {
            var query = "joao lucas bontorin linkedin";               // LOOKING FOR THIS CONTENT IN QUERY
            var results = GoogleSearch.Search(query);
            if (results != null)
            {
                Console.WriteLine("Query: " + query);

                foreach (Result result in results)
                {                   
                    if (result.Link.Contains("linkedin.com"))
                    {
                        Console.WriteLine("-----------------------------------");
                        Console.WriteLine("Título:{0}", result.Title);
                        Console.WriteLine("URL: {0}", result.Link);
                    }
                    else
                    {
                        Console.Write("Linkedin não encontrado");
                        Console.WriteLine();
                    }
                    break;
                }
            }
            Console.ReadLine();
        }
    }
}

