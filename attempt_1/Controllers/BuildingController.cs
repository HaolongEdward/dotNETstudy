using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using attempt_1.Models;

namespace attempt_1.Controllers
{
    public class BuildingController : Controller
    {
        // GET: Building
        public ActionResult Random()
        {
            //    public int Building_Id { get; set; }
            //public String Building_name { get; set; }
            //public String City { get; set; }
            //public String State { get; set; }
            //public String Country { get; set; }
            var building = new Building()
            {
                Building_Id = 1,
                State = "Quebec",
                City = "Montreal",
                Building_name = "Centre Eaton - Montreal",
                Country = "Canada"
            }; 
            return View(building);
        }
    }
}