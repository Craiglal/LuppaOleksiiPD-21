using System;
using System.Collections.Generic;
using System.Text;

namespace Lab11
{
    class Patien
    {
        public bool MRT { get; set; }
        public bool KT { get; set; }
        public bool XRAY { get; set; }
        public bool LOR { get; set; }
        public bool UZI { get; set; }
        public bool RH_Tests { get; set; }

        public void info()
        {
            Console.WriteLine($"MRT: {(MRT ? "done": "undone")}");
            Console.WriteLine($"KT: {(KT ? "done" : "undone")}");
            Console.WriteLine($"XRAY: {(XRAY ? "done" : "undone")}");
            Console.WriteLine($"LOR: {(LOR ? "done" : "undone")}");
            Console.WriteLine($"UZI: {(UZI ? "done" : "undone")}");
            Console.WriteLine($"RH_Tests: {(RH_Tests ? "done" : "undone")}");
        }
    }
}
