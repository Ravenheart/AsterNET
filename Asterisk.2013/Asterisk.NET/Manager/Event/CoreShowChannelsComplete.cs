namespace AsterNET.Manager.Event
{
    public class CoreShowChannelsComplete : ResponseEvent
    {
        public string EventList { get; set; }

        public int ListItems { get; set; }

        public CoreShowChannelsComplete(ManagerConnection source) : base(source)
        {
        }
    }
}