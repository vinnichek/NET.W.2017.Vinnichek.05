using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polynomial.Logic
{
    public class Polynomial : ICloneable
    {
        #region Public Fields
        /// <summary>
        /// Return degree of Polynomial.
        /// </summary>
        public int Degree { get { return coefficientArray.Length; } }
        #endregion

        #region Private Fields
        private readonly double[] coefficientArray;
        #endregion

        #region Ctors
        /// <summary>
        /// Ctor with parameter.
        /// </summary>
        /// <param name="coefficients">Array of coefficients.</param>
        public Polynomial(params double[] coefficients)
        {
            coefficientArray = new double[coefficients.Length];
            Array.Copy(coefficients, coefficientArray, coefficientArray.Length);
        }
        #endregion

        #region Public Methods

        #region Override Methods
        /// <summary>
        /// Converts polynom into string representation.
        /// </summary>
        /// <returns>String representation of polynom.</returns>
        override public string ToString()
        {
            StringBuilder result = new StringBuilder();
            for (int i = 0; i < coefficientArray.Length; i++)
            {
                if (coefficientArray[i] == 0) continue;
                if (coefficientArray[i] < 0) result.Append("(" + coefficientArray[i].ToString() + ")");
                if (coefficientArray[i] > 0) result.Append(coefficientArray[i].ToString());
                if (i != 0) result.Append("*" + "(x^" + i + ")");
                if (i != coefficientArray.Length - 1) result.Append(" + ");
            }
            return result.ToString() + " = 0";
        }

        /// <summary>
        /// Find sum of two polynomials.
        /// </summary>
        /// <param name="firstPolynomial">First polynomial.</param>
        /// <param name="secondPolynomial">Second polynomial.</param>
        /// <returns>Sum of two polynomials.</returns>
        public static Polynomial operator +(Polynomial firstPolynomial, Polynomial secondPolynomial)
        {
            CheckPolynomials(firstPolynomial, secondPolynomial);
            if (firstPolynomial.Degree == 0) return new Polynomial(secondPolynomial.coefficientArray);
            if (secondPolynomial.Degree == 0) return new Polynomial(firstPolynomial.coefficientArray);
            double[] arr;
            if (firstPolynomial.Degree > secondPolynomial.Degree)
            { 
                arr = new double[firstPolynomial.Degree];
                for (int i = 0; i < firstPolynomial.Degree; i++)
                    arr[i] = firstPolynomial.coefficientArray[i];
                for (int i = 0; i < secondPolynomial.Degree; i++)
                    arr[i] += secondPolynomial.coefficientArray[i];
            }
            else
            {
                arr = new double[secondPolynomial.Degree];
                for (int i = 0; i < secondPolynomial.Degree; i++)
                    arr[i] = secondPolynomial.coefficientArray[i];
                for (int i = 0; i < firstPolynomial.Degree; i++)
                    arr[i] += firstPolynomial.coefficientArray[i];
            }
            return new Polynomial(arr);
        }

        /// <summary>
        /// Find difference of two polynomials.
        /// </summary>
        /// <param name="firstPolynomial">First polynomial.</param>
        /// <param name="secondPolynomial">Second polynomial.</param>
        /// <returns>Difference of two polynomials.</returns>
        public static Polynomial operator -(Polynomial firstPolynomial, Polynomial secondPolynomial)
        {
            CheckPolynomials(firstPolynomial, secondPolynomial);
            if (firstPolynomial.Degree == 0) return new Polynomial(secondPolynomial.coefficientArray);
            if (secondPolynomial.Degree == 0) return new Polynomial(firstPolynomial.coefficientArray);
            double[] arr;
            if (firstPolynomial.Degree > secondPolynomial.Degree)
            {
                arr = new double[firstPolynomial.Degree];
                for (int i = 0; i < firstPolynomial.Degree; i++)
                    arr[i] = firstPolynomial.coefficientArray[i];
                for (int i = 0; i < secondPolynomial.Degree; i++)
                    arr[i] -= secondPolynomial.coefficientArray[i];
            }
            else
            {
                arr = new double[secondPolynomial.Degree];
                for (int i = 0; i < secondPolynomial.Degree; i++)
                    arr[i] = -secondPolynomial.coefficientArray[i];
                for (int i = 0; i < firstPolynomial.Degree; i++)
                    arr[i] += firstPolynomial.coefficientArray[i];
            }
            return new Polynomial(arr);
        }

        /// <summary>
        /// Find product of two polynomials.
        /// </summary>
        /// <param name="firstPolynomial">First polynomial.</param>
        /// <param name="secondPolynomial">Second polynomial.</param>
        /// <returns>Product of two polynomials.</returns>
        public static Polynomial operator *(Polynomial firstPolynomial, Polynomial secondPolynomial)
        {
            CheckPolynomials(firstPolynomial, secondPolynomial);
            if (firstPolynomial.Degree == 0 || secondPolynomial.Degree == 0) return new Polynomial();
            double[] arr = new double[firstPolynomial.Degree + secondPolynomial.Degree];
            for (int i = 0; i < firstPolynomial.Degree; i++)
                for (int j = 0; j < firstPolynomial.Degree; j++)
                {
                    arr[i + j] += firstPolynomial.coefficientArray[i] * secondPolynomial.coefficientArray[j];
                }
            return new Polynomial(arr);
        }

        /// <summary>
        /// Check for inequality of two polynomials.
        /// </summary>
        /// <param name="firstPolynomial">First polynomial.</param>
        /// <param name="secondPolynomial">Second polynomial.</param>
        /// <returns>True if objects aren't equal, and false if equal.</returns>
        public static bool operator !=(Polynomial firstPolynomial, Polynomial secondPolynomial)
        {
            CheckPolynomials(firstPolynomial, secondPolynomial);
            return !firstPolynomial.Equals(secondPolynomial);
        }

        /// <summary>
        /// Check for equality of two polynomials.
        /// </summary>
        /// <param name="firstPolynomial">First polynomial.</param>
        /// <param name="secondPolynomial">Second polynomial.</param>
        /// <returns>True if objects are equal, and false if not.</returns>
        public static bool operator ==(Polynomial firstPolynomial, Polynomial secondPolynomial)
        {
            CheckPolynomials(firstPolynomial, secondPolynomial);
            return firstPolynomial.Equals(secondPolynomial);
        }

        /// <summary>
        /// Checks for equality.
        /// </summary>
        /// <param name="polynomial">One of the objects.</param>
        /// <returns>True, if objects are equal, and false otherwise.</returns>
        public override bool Equals(object polynomial)
        {
            if (ReferenceEquals(polynomial, null)) return false;
            if (ReferenceEquals(polynomial, this)) return true;
            return Equals(polynomial as Polynomial);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
        #endregion

        private static void CheckPolynomials(Polynomial firstPolynomial, Polynomial secondPolynomial)
        {
            if (ReferenceEquals(firstPolynomial, null) && ReferenceEquals(secondPolynomial, null)) throw new ArgumentNullException($"{ nameof(firstPolynomial) } and { nameof(secondPolynomial) } are null.");
            if (ReferenceEquals(firstPolynomial, null)) throw new ArgumentNullException($"{ nameof(firstPolynomial) } is null.");
            if (ReferenceEquals(secondPolynomial, null)) throw new ArgumentNullException($"{ nameof(secondPolynomial) } is null.");
        }

        public object Clone()
        {
            return new Polynomial(coefficientArray);
        }
        #endregion
    }
}
