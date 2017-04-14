using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

// A Model class representing data models for the database, views and controllers
// Data annotations before each variable is used to dynamicly display it the way we want in the views instead of using static HTML
namespace DAS.Models
{
    public class DocumentModels1
    {
        public int id { get; set; }
        [Display(Name ="Cips")]
        public bool cips { get; set; }
        [Display(Name ="Citizenship")]
        public bool citizenship { get; set; }
        [Display(Name ="Passport")]
        public bool passport { get; set; }
        [Display(Name="Crime record")]
        public bool crimerecord { get; set; }
        [Display(Name ="First name")]
        public string name { get; set; }
        [Display(Name ="Last name")]
        public string surName { get; set; }
        [Display(Name ="Identity number")]
        public int identityNo { get; set; }
        [Display(Name ="Street address")]
        public string streetAddress { get; set; }
        [Display(Name ="City")]
        public string city { get; set; }
        [Display(Name ="Cantoon")]
        public string cantoon { get; set; }
        [Display(Name ="ZIP / postal code")]
        public int zipCode { get; set; }
    }
}