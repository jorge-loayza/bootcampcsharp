using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDExercise
{
    class Email
    {
        public string id { get; set; }
        public string originIp { get; set; }
        public string from { get; set; }
        public string to { get; set; }
        public string subject { get; set; }
        public string CC { get; set; }
        public string body { get; set; }
        public DateTime date { get; set; }
    }
}
