using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using SoloCapstoneProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace SoloCapstoneProject.Services
{
    public class GeocodingService
    {

        public GeocodingService()
        {

        }
        
        public string GetGeocodingURL(Consumer consumer) //takes the consumer information so the API can build the URL.
        {

            return $"https://maps.googleapis.com/maps/api/geocode/json?address={consumer.Address}+{consumer.City}+{consumer.State}&key=AIzaSyAMsdaoeePqO9F_hpJsr3xJSPbPfF7dW0U";
        
        }


        public async Task<Consumer> GetGeoCoding(Consumer consumer)
        {

            string apiUrl = GetGeocodingURL(consumer); //API returns with all the information..

            using (HttpClient client = new HttpClient()) //httpclient makes web requests..
            {

                client.BaseAddress = new Uri(apiUrl);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

                HttpResponseMessage response = await client.GetAsync(apiUrl); //passes in our return URL with all the requested info..

                if (response.IsSuccessStatusCode) //if the request is normal/successs
                    
                    //will search for only the relative info that we are looking for (long. and Lat.)
                {

                    string data = await response.Content.ReadAsStringAsync(); //grabs the content "response" and return as string "data"
                    JObject jsonResults = JsonConvert.DeserializeObject<JObject>(data); //deserializes/converts and returns as a json object..
                    JToken results = jsonResults["results"][0]; //returns the "0" index of results from the JSON object
                    JToken location = results["geometry"]["location"]; //returns geometry/location from results.. 4 levels deep.. JSON "INCEPTION"

                    //Json uses bracket notations [""] instead of dot notation.

                    consumer.Latitude = (double)location["lat"]; //converts string "lat" to double.
                    consumer.Longitude = (double)location["lng"];

                }

            }

            return consumer;

        }







    }
}
