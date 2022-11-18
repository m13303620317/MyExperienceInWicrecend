using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyExperienceInWicrecend.Models
{
    public class Reporter
    {
        public string Name { get; set; }
    }

    public class ReporterManager
    {
        public static List<Reporter> GetReporters()
        {
            List<Reporter> reporters = new List<Reporter>();

            reporters.Add(new Reporter { Name = "刘佳霖(Jialin Liu)" });

            return reporters;
        }
    }
}
