using Google.Apis.Customsearch.v1;
using Google.Apis.Customsearch.v1.Data;
using Google.Apis.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoogleApi
{
    class GoogleSearch
    {
        //API Key
        private static string API_KEY = "...";

        //The custom search engine identifier
        private static string cx = "...";

        public static CustomsearchService Service = new CustomsearchService(
            new BaseClientService.Initializer
            {
                ApplicationName = "IWSocialSearch",
                ApiKey = API_KEY,
            });
        
        public static IList<Result> Search(string query)
        {
          //  Console.WriteLine("CRM NAME: {0} ...", query);

            CseResource.ListRequest listRequest = Service.Cse.List(query);
            listRequest.Cx = cx;

            Search search = listRequest.Execute();
            return search.Items;
        }
    }
}
