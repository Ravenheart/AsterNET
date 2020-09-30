namespace AsterNET.Manager.Event
{
	/// <summary>
	/// A HangupEvent is triggered when a channel is hung up.<br/>
	/// It is implemented in channel.c
	/// </summary>
	public class HangupEvent : AbstractChannelEvent
	{
		private int cause;
		private string causeTxt;

		/// <summary>
		/// Get/Set the cause of the hangup.
		/// </summary>
		public int Cause
		{
			get { return cause; }
			set { this.cause = value; }
		}
		/// <summary>
		/// Get/Set the textual representation of the hangup cause.
		/// </summary>
		public string CauseTxt
		{
			get { return causeTxt; }
			set { this.causeTxt = value; }
		}

		public string Language { get; set; }

		public string Context { get; set; }

		public string Exten { get; set; }

		public string Priority { get; set; }

		public string LinkedId { get; set; }

		public HangupEvent(ManagerConnection source)
			: base(source)
		{
		}
	}
}