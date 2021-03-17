using AsterNET.Manager.Action;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsterNET.Manager.Event
{
    public class EndpointListEvent : ResponseEvent
    {
        public string ObjectType { get; set; }

        public string ObjectName { get; set; }

        public string Transport { get; set; }

        public string Aor { get; set; }

        public string Auths { get; set; }

        public string OutboundAuths { get; set; }

        public string DeviceState { get; set; }

        public string ActiveChannels { get; set; }

        public EndpointListEvent(ManagerConnection source) : base(source)
        {
        }
    }
}
