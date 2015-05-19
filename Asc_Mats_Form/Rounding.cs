using System;

namespace AscendedMaterialsForm
{
    internal static class Rounding
    {
        public static decimal RoundUp(decimal number, int places)
        {
            var factor = RoundFactor(places);
            number *= factor;
            number = Math.Ceiling(number);
            number /= factor;
            return number;
        }

        public static decimal RoundDown(decimal number, int places)
        {
            var factor = RoundFactor(places);
            number *= factor;
            number = Math.Floor(number);
            number /= factor;
            return number;
        }

        internal static decimal RoundFactor(int places)
        {
            var factor = 1m;

            if (places < 0)
            {
                places = -places;
                for (var i = 0; i < places; i++)
                    factor /= 10m;
            }
            else
            {
                for (var i = 0; i < places; i++)
                    factor *= 10m;
            }

            return factor;
        }
    }
}