using System;
using System.IO;
using Newtonsoft.Json.Linq;

namespace GUI {
    class FormatHelper {
        public static readonly string DateFormat;

        static FormatHelper() {
            JToken token = JToken.Parse(File.ReadAllText(@"Format\DateFormat.json"));

            DateFormat = token["DateFormat"].ToString();
        }
    }
}
