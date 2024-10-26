using System;
using System.Diagnostics;

namespace TshirtSpace {
    class Tshirt {
        static string Size(int cms) {
            if(cms < 38) {
                return "S";
            } else if(cms > 38 && cms < 42) {
                return "M";
            } else {
                return "L";
            }
        }
        static void Main(string[] args) {
            Debug.Assert(Size(38) == "S");
            Debug.Assert(Size(0) == "M");
            Debug.Assert(Size(5) == "L");
            Console.WriteLine( "All is well (maybe!)");
        }
    }
}
