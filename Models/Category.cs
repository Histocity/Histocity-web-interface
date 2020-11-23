using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Histocity_Website.Models
{
    public class Category
    {
        public int CategoryID { get; set; }
        public string CategoryDescription { get; set; }
        public string CategoryDifficulty { get; set; }
        public string EraID { get; set; }

        public readonly Dictionary<string, string> Difficulty = new Dictionary<string, string>
            {
            {"1", "Makkelijk" },
            {"2", "Gemiddeld" },
            {"3", "Moeilijk" },
            };

    }
}
