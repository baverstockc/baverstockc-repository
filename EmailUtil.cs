using System;
using System.Text.RegularExpressions;

namespace Adastra.General
{
	/// <summary>
	/// General email address utilities
	/// </summary>
	public class EmailUtil
	{
		/// <summary>
		/// Specifies whether the string is a valid represenation of an email address
		/// </summary>
		/// <param name="inString">The string to be validated</param>
		/// <returns>True or False to indicate whether the string is a valid email representation</returns>
		public static bool isValidEmailString(string inString)
		{
			string regexString = @"^([a-z\d_\-\.]+)@((\[\d{1,3}\.\d{1,3}\.\d{1,3}\.)|(([a-z\d\-]+\.)+))([a-z]{2,4}|\d{1,3})(\]?)$";
			Regex  match = new Regex(regexString, RegexOptions.IgnoreCase);
			Match f = match.Match(inString);
			return f.Success;
		}	
		
	}
}
