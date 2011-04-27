using System;
namespace Asterisk.NET
{
	public interface ILogger
	{
		void Debug(object o);
		void Debug(string format, params object[] args);
		void Debug(string msg);
		void Debug(string msg, Exception ex);
		void Error(object o);
		void Error(string format, params object[] args);
		void Error(string msg);
		void Error(string msg, Exception ex);
		void Info(object o);
		void Info(string format, params object[] args);
		void Info(string msg);
		void Info(string msg, Exception ex);
		bool IsVisible(Logger.MessageLevel messageLevel, string classMethod);
		void Warning(object o);
		void Warning(string format, params object[] args);
		void Warning(string msg);
		void Warning(string msg, Exception ex);
	}
}
