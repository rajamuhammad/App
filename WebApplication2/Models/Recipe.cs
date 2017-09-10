using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication2.Models
{
    public class Recipe
    {
        public int Id { get; set; }
        public String Name { get; set; }
        public String Ingredients { get; set; }
        public String Method { get; set; }
    }
}