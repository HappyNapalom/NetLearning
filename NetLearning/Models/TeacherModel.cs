using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace NetLearning.Models
{
    public class TeacherModel
    {

        public int ID { get; set; }
        public string Section1 { get; set; }
        public int grade1 { get; set; }

        public string Section2 { get; set; }
        public int grade2 { get; set; }

        public string Section3 { get; set; }
        public int grade3 { get; set; }

        public int overall { get; set; }

    }

    public class TeacherDBContext : DbContext
    {
        public DbSet<TeacherModel> Teacher { get; set; }

    }
}