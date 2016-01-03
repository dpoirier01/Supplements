using Supplements.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Supplements.Business
{
    public class SupplementsService
    {

        string baseUrl = "http://localhost:50195/api/Supplement/";
        HttpClient client;

        public SupplementsService()
        {
            client = new HttpClient();
            client.BaseAddress = new Uri(baseUrl);
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
        }


        public List<SupplementType> GetSupplements()
        {

            HttpResponseMessage response = client.GetAsync("GetSupplements").Result;

            if (response.IsSuccessStatusCode)
            {
                return response.Content.ReadAsAsync<IEnumerable<SupplementType>>().Result.ToList();
              
            }

            return null;
        }


    }
}
