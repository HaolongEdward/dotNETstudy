using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace attempt_1.Models
{
    public class Building
    {
        //using the same layout from json

        public int Building_Id { get; set; }
        public String Building_name { get; set; }
        public String City { get; set; }
        public String State { get; set; }
        public String Country { get; set; }

        public static String URL = "http://jobs.mapsted.com/";
        public static String urlParameters = "api/Values/GetBuildingData";

        //public Building(String id, String) { }
    }
}