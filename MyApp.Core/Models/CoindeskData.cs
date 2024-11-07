using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp.Core.Models
{
    public class CoindeskData
    {
        public TimeOnly Time { get; set; }
        public string Disclaimer { get; set; }
        public string ChartName { get; set; }
        public Bpi Bpi { get; set; }
    }

    public class Time
    { 
        public string Updated { get; set; }
        public DateTime UpdatedISD { get; set; }
        public string Updateduk { get; set; }
    }

    public class  Bpi
    {
        public decimal USD { get; set; }
        public decimal GBP { get; set; }
        public decimal EUR { get; set; }
    }
}
