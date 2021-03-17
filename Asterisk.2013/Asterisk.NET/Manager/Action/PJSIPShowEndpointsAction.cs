using AsterNET.Manager.Event;
using System;

namespace AsterNET.Manager.Action
{
    /// <summary>
    /// Lists PJSIP endpoints
    /// </summary>
    public class PJSIPShowEndpointsAction : ManagerActionEvent
    {
        /// <summary>
        /// Get the name of this action, i.e. "PJSIPShowEndpoints".
        /// </summary>
        public override string Action => "PJSIPShowEndpoints";

        public override Type ActionCompleteEventClass()
        {
            return typeof(EndpointListCompleteEvent);
        }
    }
}
