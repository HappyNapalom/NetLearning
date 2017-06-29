using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NetLearning.Models
{
    public class UserGrade
    {
        [AllowHtml]
        public string Section1 { get; set; }
        public string Section2 { get; set; }
        public string Section3 { get; set; }
        public string FinalQuiz { get; set; }


    }
}