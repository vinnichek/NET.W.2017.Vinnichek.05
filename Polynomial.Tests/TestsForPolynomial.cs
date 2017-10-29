using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Polynomial.Logic;

namespace Polynomial.Tests
{
    [TestFixture]
    public class TestsForPolynomial
    {
        [TestCase(2, 3, 1, 2, ExpectedResult = "2 + 3*(x^1) + 1*(x^2) + 2*(x^3) = 0")]
        [TestCase(1, 2, 3, 4, ExpectedResult = "1 + 2*(x^1) + 3*(x^2) + 4*(x^3) = 0")]
        public string ToString_For_Polynomial(params double[] coefficientArray)
        {
            Polynomial pol = new Polynomial(coefficientArray);
            return pol.ToString();
        }

        [TestCase(ExpectedResult = "3 + 5*(x^1) + 4*(x^2) + 6*(x^3) = 0")]
        public string Sum_For_Two_Polynomials()
        {
            Polynomial pol1 = new Polynomial(2, 3, 1, 2);
            Polynomial pol2 = new Polynomial(1, 2, 3, 4);
            Polynomial pol3 = pol1 + pol2;
            return pol3.ToString();
        }

        [TestCase(ExpectedResult = "2 + 7*(x^1) + 13*(x^2) + 21*(x^3) + 19*(x^4) + 10*(x^5) + 8*(x^6) + = 0")]
        public string Multiplication_For_Two_Polynomials()
        {
            Polynomial pol1 = new Polynomial(2, 3, 1, 2);
            Polynomial pol2 = new Polynomial(1, 2, 3, 4);
            Polynomial pol3 = pol1 * pol2;
            return pol3.ToString();
        }

        [TestCase(ExpectedResult = "1 + 1*(x^1) + (-2)*(x^2) + (-2)*(x^3) = 0")]
        public string Substraction_For_Two_Polynomials()
        {
            Polynomial pol1 = new Polynomial(2, 3, 1, 2);
            Polynomial pol2 = new Polynomial(1, 2, 3, 4);
            Polynomial pol3 = pol1 - pol2;
            return pol3.ToString();
        }

        public void Equals_For_Two_Polynomials()
        {
            Polynomial pol1 = new Polynomial(1, 2, 1, 2);
            Polynomial pol2 = (Polynomial)pol1.Clone();
            Assert.AreEqual(true, pol2.Equals(pol1));
        }
    }
}
