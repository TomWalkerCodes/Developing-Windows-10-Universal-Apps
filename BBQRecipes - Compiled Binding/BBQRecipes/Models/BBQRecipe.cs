using System;
using System.Collections.Generic;
using System.Text;

namespace HowToBBQ.Models
{
    public class BBQRecipe
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ShortDesc { get; set; }
        public string Ingredients { get; set; }
        public string Directions { get; set; }
        public int PrepTime { get; set; }
        public int TotalTime { get; set; }
        public int Serves { get; set; }
        public string ImageSource { get; set; }
    }

}
