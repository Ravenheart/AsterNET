namespace AsterNET.Manager.Event
{
    /// <summary>
    /// A NewStateEvent is triggered when the state of a channel has changed.<br/>
    /// It is implemented in channel.c
    /// </summary>
    public class NewStateEvent : AbstractChannelEvent
    {
        public string Language { get; set; }

        public string Context { get; set; }

        public string Exten { get; set; }

        public string Priority { get; set; }

        public string LinkedId { get; set; }

        public NewStateEvent(ManagerConnection source)
            : base(source)
        {
        }
    }
}