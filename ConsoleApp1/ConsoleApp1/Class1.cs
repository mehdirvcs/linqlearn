using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    // Custom comparer for use with ordering operators
    public class CaseInsensitiveComparer : IComparer<string>
    {
        public int Compare(string x, string y) =>
            string.Compare(x, y, StringComparison.OrdinalIgnoreCase);
    }
}
