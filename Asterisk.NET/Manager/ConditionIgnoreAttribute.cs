using System;
using System.Collections.Generic;
using System.Text;

namespace Asterisk.NET.Manager
{
	/// <summary>
	/// Indicates that an ManagerEvent's property should be ignored during command creation 
	/// if properties' value equals "Value".
	/// </summary>
	[AttributeUsage(AttributeTargets.Property, AllowMultiple=true, Inherited=true)]
	public class ConditionIgnoreAttribute : Attribute
	{
		public readonly object Value;

		public ConditionIgnoreAttribute(int integerValue)
		{
			Value = integerValue;
		}

		public ConditionIgnoreAttribute(double doubleValue)
		{
			Value = doubleValue;
		}

		public ConditionIgnoreAttribute(string stringValue)
		{
			Value = stringValue;
		}
	}
}
