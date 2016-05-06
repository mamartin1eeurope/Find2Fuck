using System;

namespace Find2Fuck.Interfaces.Logger
{
	public interface ILogger
	{
		void Log(string message);
		void Log(Exception ex);
	}
}
