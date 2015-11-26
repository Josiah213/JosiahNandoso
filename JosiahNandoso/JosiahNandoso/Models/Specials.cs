using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Newtonsoft.Json;

namespace JosiahNandoso.Models
{
    public class Specials
    {
        public int ID { get; set; }
        public string SpecialName { get; set; }
        public string SpecialPrice { get; set; }
        public string SpecialDescription { get; set; }
    }
}