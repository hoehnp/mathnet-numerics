﻿using System.Numerics;

namespace MathNet.Numerics
{
    /// <summary>
    /// This partial implementation of the SpecialFunctions class contains all methods related to the Bessel functions.
    /// </summary>
    public static partial class SpecialFunctions
    {
        /// <summary>
        /// Bessel function of the first kind, J(v, z).
        /// <p/>
        /// If expScaled is true, returns Exp(-Abs(y)) * J(v, z) where y = z.Imaginary.
        /// </summary>
        /// <param name="v">The order of the Bessel function</param>
        /// <param name="z">The value to compute the Bessel function of.</param>
        /// <param name="expScaled">If true, returns exponentially-scaled Bessel function</param>
        /// <returns></returns>
        public static Complex BesselJ(double v, Complex z, bool expScaled = false)
        {
            return (expScaled) ? Amos.ScaledCbesj(v, z) : Amos.Cbesj(v, z);
        }

        /// <summary>
        /// Bessel function of the first kind, J(v, z).
        /// <p/>
        /// If expScaled is true, returns Exp(-Abs(y)) * J(v, z) where y = z.Imaginary.
        /// </summary>
        /// <param name="v">The order of the Bessel function</param>
        /// <param name="z">The value to compute the Bessel function of.</param>
        /// <param name="expScaled">If true, returns exponentially-scaled Bessel function</param>
        /// <returns></returns>
        public static double BesselJ(double v, double z, bool expScaled = false)
        {
            return (expScaled) ? Amos.ScaledCbesj(v, z) : Amos.Cbesj(v, z);
        }

        /// <summary>
        /// Bessel function of the second kind, Y(v, z).
        /// <p/>
        /// If expScaled is true, returns Exp(-Abs(y)) * Y(v, z) where y = z.Imaginary.
        /// </summary>
        /// <param name="v">The order of the Bessel function</param>
        /// <param name="z">The value to compute the Bessel function of.</param>
        /// <param name="expScaled">If true, returns exponentially-scaled Bessel function</param>
        /// <returns></returns>
        public static Complex BesselY(double v, Complex z, bool expScaled = false)
        {
            return (expScaled) ? Amos.ScaledCbesy(v, z) : Amos.Cbesy(v, z);
        }

        /// <summary>
        /// Bessel function of the second kind, Y(v, z).
        /// <p/>
        /// If expScaled is true, returns Exp(-Abs(y)) * Y(v, z) where y = z.Imaginary.
        /// </summary>
        /// <param name="v">The order of the Bessel function</param>
        /// <param name="z">The value to compute the Bessel function of.</param>
        /// <param name="expScaled">If true, returns exponentially-scaled Bessel function</param>
        /// <returns></returns>
        public static double BesselY(double v, double z, bool expScaled = false)
        {
            return (expScaled) ? Amos.ScaledCbesy(v, z) : Amos.Cbesy(v, z);
        }

        /// <summary>
        /// Modified Bessel function of the first kind, I(v, z).
        /// <p/>
        /// If expScaled is true, returns Exp(-Abs(x)) * I(v, z) where x = z.Real.
        /// </summary>
        /// <param name="v">The order of the Bessel function</param>
        /// <param name="z">The value to compute the Bessel function of.</param>
        /// <param name="expScaled">If true, returns exponentially-scaled Bessel function</param>
        /// <returns></returns>
        public static Complex BesselI(double v, Complex z, bool expScaled = false)
        {
            return (expScaled) ? Amos.ScaledCbesi(v, z) : Amos.Cbesi(v, z);
        }

        /// <summary>
        /// Modified Bessel function of the first kind, I(v, z).
        /// <p/>
        /// If expScaled is true, returns Exp(-Abs(x)) * I(v, z) where x = z.Real.
        /// </summary>
        /// <param name="v">The order of the Bessel function</param>
        /// <param name="z">The value to compute the Bessel function of.</param>
        /// <param name="expScaled">If true, returns exponentially-scaled Bessel function</param>
        /// <returns></returns>
        public static double BesselI(double v, double z, bool expScaled = false)
        {
            if (expScaled)
            {
                return Amos.ScaledCbesi(v, z);
            }
            else
            {
                return BesselI(v, new Complex(z, 0), expScaled).Real;
            }
        }

        /// <summary>
        /// Modified Bessel function of the second kind, K(v, z).
        /// <p/>
        /// If expScaled is true, returns Exp(z) * K(v, z).
        /// </summary>
        /// <param name="v">The order of the Bessel function</param>
        /// <param name="z">The value to compute the Bessel function of.</param>
        /// <param name="expScaled">If true, returns exponentially-scaled Bessel function</param>
        /// <returns></returns>
        public static Complex BesselK(double v, Complex z, bool expScaled = false)
        {
            return (expScaled) ? Amos.ScaledCbesk(v, z) : Amos.Cbesk(v, z);
        }

        /// <summary>
        /// Modified Bessel function of the second kind, K(v, z).
        /// <p/>
        /// If expScaled is true, returns Exp(z) * K(v, z).
        /// </summary>
        /// <param name="v">The order of the Bessel function</param>
        /// <param name="z">The value to compute the Bessel function of.</param>
        /// <param name="expScaled">If true, returns exponentially-scaled Bessel function</param>
        /// <returns></returns>
        public static double BesselK(double v, double z, bool expScaled = false)
        {
            return (expScaled) ? Amos.ScaledCbesk(v, z) : Amos.Cbesk(v, z);
        }
    }
}
