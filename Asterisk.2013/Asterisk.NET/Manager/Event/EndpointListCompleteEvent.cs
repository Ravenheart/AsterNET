using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsterNET.Manager.Event
{
    public class EndpointListCompleteEvent : ResponseEvent
    {
        public string EventList { get; set; }

        public int ListItems { get; set; }

        public EndpointListCompleteEvent(ManagerConnection source) : base(source)
        {
        }
    }
}
