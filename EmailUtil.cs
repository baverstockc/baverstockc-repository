using System;
using System.Text.RegularExpressions;

namespace Adastra.General
{
	/// <summary>
	/// General email address utilities
	/// </summary>
	public class EmailUtil
	{
        Regex match;
		/// <summary>
		/// Specifies whether the string is a valid represenation of an email address
		/// </summary>
		/// <param name="inString">The string to be validated</param>
		/// <returns>True or False to indicate whether the string is a valid email representation</returns>
		public static bool isValidEmailString(string inString)
		{
			string regexString = @"^([a-z\d_\-\.]+)@((\[\d{1,3}\.\d{1,3}\.\d{1,3}\.)|(([a-z\d\-]+\.)+))([a-z]{2,4}|\d{1,3})(\]?)$";
            MakeNewRegex(regexString, RegexOptions.IgnoreCase);
			Match f = match.Match(inString);
            //Return
			return f.Success;
		}

        /// <summary>
        /// Stuff going on the probably won't compile. C'est la vie.
        /// </summary>
        /// <param name="s">A string</param>
        /// <param name="t">Whatever RegexOptions.IgnoreCase is</param>
        /// <returns></returns>
        public string MakeNewRegex(string s, object t)
        {
            match = new Regex(s, t);
        }
		
	}
}
