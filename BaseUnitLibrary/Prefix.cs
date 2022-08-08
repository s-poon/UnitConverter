using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseUnitLibrary {
    public static class Prefix {
        public static double NanoTo(double nano) { return nano / 1e9; }
        public static double MicroTo(double micro) { return micro / 1e6; }
        public static double MilliTo(double milli) { return milli / 1e3; }
        public static double CentiTo(double centi) { return centi / 100; }
        public static double KiloTo(double kilo) { return kilo * 1e3; }
        public static double MegaTo(double mega) { return mega * 1e6; }
        public static double GigaTo(double giga) { return giga * 1e9; }

        public static double ToNano (double baseUnit){ return baseUnit * 1e9; }
        public static double ToMicro (double baseUnit){ return baseUnit * 1e6; }
        public static double ToMilli (double baseUnit){ return baseUnit * 1e3; }
        public static double ToCenti (double baseUnit){ return baseUnit * 100; }
        public static double ToKilo (double baseUnit){ return baseUnit / 1e3; }
        public static double ToMega (double baseUnit){ return baseUnit / 1e6; }
        public static double ToGiga (double baseUnit){ return baseUnit / 1e9; }
    }
}
