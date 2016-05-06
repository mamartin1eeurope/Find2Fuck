using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Find2Fuck.Interfaces.Logger;

namespace Find2Fuck.BL.Logger
{
	public class Ui2DbLogger : ILogger
	{
		public void Log(string message)
		{
			Console.WriteLine(message);
			//BaseObject.LogMessage(message);
		}
		public void Log(Exception ex)
		{
			Console.WriteLine(ex.Message);
			//BaseObject.LogMessage(ex);
		}
	}
}
