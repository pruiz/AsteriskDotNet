namespace Asterisk.NET.Manager.Event
{
	/// <summary>
	/// A CelEvent is triggered when a CEL event is transmitted thru AMI.<br/>
	/// To enable CelEvents you have to add <code>enabled = yes</code> to the manger section in
	/// <code>cel.conf</code>.<br/>
	/// This event is implemented in <code>cel/cel_manager.c</code>
	/// </summary>
	public class CelEvent : ManagerEvent
	{
		public string EventName { get; set; }
		public string AccountCode { get; set; }
		public string CallerIDnum  { get; set; }
		public string CallerIDname { get; set; }
		public string CallerIDani { get; set; }
		public string CallerIDrdnis { get; set; }
		public string CallerIDdnid { get; set; }
		public string Exten { get; set; }
		public string Context { get; set; }
		public string Application { get; set; }
		public string AppData { get; set; }
		public string EventTime { get; set; }
		public string AMAFlags { get; set; }
		public string UserField { get; set; }
		public string Peer { get; set; }

		public CelEvent(ManagerConnection source)
			: base(source)
		{
		}

	}
}