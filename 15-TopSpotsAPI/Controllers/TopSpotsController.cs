using Newtonsoft.Json.Serialization;
using _15_TopSpotsAPI.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Web.Http;

namespace _15_TopSpotsAPI.Controllers
{
    public class TopSpotsController : ApiController
    {
        // GET: api/TopSpots
        public IEnumerable<TopSpot> Get()
        {


            return JsonConvert.DeserializeObject<List<TopSpot>>(File.ReadAllText(@"C:\dev\15-TopSpotsAPI\15-TopSpotsAPI\App_Start\TopSpots.json"));
        }
        // GET: api/TopSpots/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/TopSpots
        public TopSpot Post(TopSpot topspot)
        {
            
    }
                
        }

        // PUT: api/TopSpots/5
        public void Put(TopSpot  topspot)
        {
        string result = "";
        using (var client = new WebClient())
    //    {
    //        client.Headers[HttpRequestHeader.ContentType] = "application/json";
    //        result = client.UploadString(@"C:\dev\15-TopSpotsAPI\15-TopSpotsAPI\App_Start\TopSpots.json", "PUT");
    //    }
    //}
   
    //    return topspot;
        }

        // DELETE: api/TopSpots/5
        public void Delete(int id)
        {
        }



    }
   
}
