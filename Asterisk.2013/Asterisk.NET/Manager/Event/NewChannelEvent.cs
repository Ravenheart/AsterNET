namespace AsterNET.Manager.Event
{
    /// <summary>
    /// A NewChannelEvent is triggered when a new channel is created.<br/>
    /// It is implemented in channel.c
    /// </summary>
    public class NewChannelEvent : AbstractChannelEvent
    {
        public string Context { get; set; }

        public string Exten { get; set; }

        public string Priority { get; set; }

        public string LinkedId { get; set; }

        public NewChannelEvent(ManagerConnection source)
            : base(source)
        {
        }
    }
}