using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scte35Monitor.Vo
{
    internal class LogItem
    {
        public string Name { get; set; }
        public string Ip { get; set; }
        public string EventId { get; set; }
        public string EventTime { get; set; }
        public string EventType { get; set; }
        public string Direction { get; set; }
        public int Preroll { get; set; }
    }
}