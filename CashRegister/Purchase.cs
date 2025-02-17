using System;

namespace CashRegister
{
	public class Purchase : IPurchase
	{
		private readonly string content;

		public Purchase()
		{
			content = "content";
		}

		public string AsString()
		{
			return content + Timestamp();
		}

		private string Timestamp()
		{
			return DateTime.Now.ToString("fff");
		}
	}
}
