using System;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;

namespace Packt.duwl.InteractiveLibrary
{
    public static class StringExtensions
    {
        public static bool IsValidPassword(this string input)
        {
            return Regex.IsMatch(input, "^[a-zA-Z0-9_-]{8,}$");
        }
    }
}
