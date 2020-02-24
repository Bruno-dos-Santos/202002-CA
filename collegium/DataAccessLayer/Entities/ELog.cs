using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Entities
{
    class ELog
    {
        public int LogID { get; set; }
        public string LoginName { get; set; }
        public DateTime EventDateTime { get; set; }
        public string TypeEvent { get; set; }
        public string Operation { get; set; }
        public string TableName { get; set; }
        public string EventInfo { get; set; }


    }
}
