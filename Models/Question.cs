using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Histocity_Website.Models
{
    public class Question
    {
        public string QuestionID { get; set; }
        public string QuestionText { get; set; }
        public string GoodAnswer{ get; set; }
        public string WrongAnswer1 { get; set; }
        public string WrongAnswer2 { get; set; }
        public string CreatedAt { get; set; }
        public string EraName { get; set; }
        public string Difficulty { get; set; }
        
        public string ActiveInGame { get; set; }
    }
}
