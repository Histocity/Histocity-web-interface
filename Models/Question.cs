using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Histocity_Website.Models
{
    public class Question
    {
        public int QuestionID { get; set; }
        public string QuestionText { get; set; }
        public string GoodAnswer{ get; set; }
        public string WrongAnswer1 { get; set; }
        public string WrongAnswer2 { get; set; }
        public string CreatedAt { get; set; }
    }
}
