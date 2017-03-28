using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DAS.Models
{
    public class DocumentModels1
    {
        public int id { get; set; }
        public bool cips { get; set; }
        public bool citizenship { get; set; }
        public bool passport { get; set; }
        public bool crimerecord { get; set; }
        public string name { get; set; }
        public string surName { get; set; }
        public int identityNo { get; set; }
        public string streetAddress { get; set; }
        public string city { get; set; }
        public string cantoon { get; set; }
        public int zipCode { get; set; }
    }
}