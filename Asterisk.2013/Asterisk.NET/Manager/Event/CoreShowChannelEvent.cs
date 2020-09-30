namespace AsterNET.Manager.Event
{
    public class CoreShowChannelEvent : ResponseEvent
    {
        public int ChannelState { get; set; }

        public string ChannelStateDesc { get; set; }

        public string CallerIDNum { get; set; }

        public string CallerIDName { get; set; }

        public string ConnectedLineNum { get; set; }

        public string ConnectedLineName { get; set; }

        public string Language { get; set; }

        public string AccountCode { get; set; }

        public string Context { get; set; }

        public string Exten { get; set; }

        public string Priority { get; set; }

        public string Uniqueid { get; set; }

        public string Linkedid { get; set; }

        public string BridgeId { get; set; }

        public string Application { get; set; }

        public string ApplicationData { get; set; }

        public string Duration { get; set; }

        public CoreShowChannelEvent(ManagerConnection source) : base(source)
        {
        }
    }
}