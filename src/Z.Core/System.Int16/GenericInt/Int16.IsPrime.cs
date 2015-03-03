using System;

public static partial class Extensions
    {
        /// <summary>
        ///     An Int16 extension method that query if '@this' is prime.
        /// </summary>
        /// <param name="this">The @this to act on.</param>
        /// <returns>true if prime, false if not.</returns>
        public static bool IsPrime(this Int16 @this)
        {
            if (@this == 1 || @this == 2)
            {
                return true;
            }

            if (@this%2 == 0)
            {
                return false;
            }

            var sqrt = (Int16) Math.Sqrt(@this);
            for (Int64 t = 3; t <= sqrt; t = t + 2)
            {
                if (@this%t == 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
