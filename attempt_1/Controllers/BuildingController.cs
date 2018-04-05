using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using System.Web.Mvc;
using attempt_1.Models;

namespace attempt_1.Controllers
{
    public class BuildingController : Controller
    {
        //issue http client
        static HttpClient client = new HttpClient();

        // GET: Building
        public ActionResult Random()
        {
            client.DefaultRequestHeaders.Accept.Add(
            new MediaTypeWithQualityHeaderValue("application/json"));

            var response = client.GetStringAsync(new Uri(Building.URL + Building.urlParameters)).Result;

            var jsonData = JArray.Parse(response);

            List<Building> buildings = new List<Building>();

            foreach (JObject item in jsonData) {
                buildings.Add(new Building()
                {
                    Building_Id = (int)item.GetValue("building_id"),
                    Building_name = (String)item.GetValue("building_name"),
                    City = (String)item.GetValue("city"),
                    State = (String)item.GetValue("state"),
                    Country = (String)item.GetValue("country")
                });
            }

            var building = new Building()
            {
                Building_Id = 1,
                State = "Quebec",
                City = "Montreal",
                Building_name = "Centre Eaton - Montreal",
                Country = "Canada"
            }; 
            return View(buildings.ElementAt((new Random()).Next(0, buildings.Count()-1)));
        }
    }
}