using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Histocity_Website.Models
{
    public class Question
    {
        public string questionID { get; set; }
        public string questionText { get; set; }
        public string goodAnswer { get; set; }
        public string wrongAnswer1 { get; set; }
        public string wrongAnswer2 { get; set; }
        public string createdAt { get; set; }
        public string eraName { get; set; }
        public string difficulty { get; set; }
        public string activeInGame { get; set; }

       public Dictionary<string, string> difficultyNames = new Dictionary<string, string>(){
           {"1", "Makkelijk"},
           {"2", "Gemiddeld"},
           {"3", "Moeilijk"}
            
        };
    }

    public class Questions
    {
        public List<Question> questions { get; set; }
    }
}
