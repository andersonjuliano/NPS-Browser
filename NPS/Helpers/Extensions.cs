using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace NPS.Helpers
{
    public static class Extensions
    {

        public static string removeIllegalCharsFromPath(this string s)
        {
            string legal = string.Empty;
            string regexSearch = new string(Path.GetInvalidFileNameChars()) + new string(Path.GetInvalidPathChars());
            Regex r = new Regex(string.Format("[{0}]", Regex.Escape(regexSearch)));
            legal = r.Replace(s, "");
            return legal;
        }

    }
}
