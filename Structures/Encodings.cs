﻿using System.Text;
using System.Collections.Generic;

namespace rMOD.Structures
{
    public class Encodings
    {
        private static List<EncodingInfo> encodings = new List<EncodingInfo>()
        {
            new EncodingInfo() { Name = "Western Europe", Value = 1252 },
            new EncodingInfo() { Name = "Arabic", Value = 1256  },
            new EncodingInfo() { Name = "Cyrillic", Value = 1251 },
            new EncodingInfo() { Name = "Korean", Value = 949 },
            new EncodingInfo() { Name = "Central Europe", Value = 1250 }
        };

        public static string[] Names { get
            {
                string[] names = new string[encodings.Count];
                for (int i = 0; i < names.Length; i++) { names[i] = encodings[i].Name; }
                return names;
            } }

        public static Encoding GetByName(string name) { return Encoding.GetEncoding(encodings.Find(e => e.Name == name).Value); }
    }

    public class EncodingInfo
    {
        public string Name;
        public int Value;
    }
}
