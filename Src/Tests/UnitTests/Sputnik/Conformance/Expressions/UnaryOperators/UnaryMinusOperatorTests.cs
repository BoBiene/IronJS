// <auto-generated />
namespace IronJS.Tests.UnitTests.Sputnik.Conformance.Expressions.UnaryOperators
{
    using System;
    using NUnit.Framework;

    [TestFixture]
    public class UnaryMinusOperatorTests : SputnikTestFixture
    {
        public UnaryMinusOperatorTests()
            : base(@"Conformance\11_Expressions\11.4_Unary_Operators\11.4.7_Unary_minus_Operator")
        {
        }

        [Test]
        [Category("Sputnik Conformance")]
        [Category("ECMA 11.4.7")]
        [Category("ECMA 7.2")]
        [Category("ECMA 7.3")]
        [TestCase("S11.4.7_A1.js", Description = "White Space and Line Terminator between \"-\" and UnaryExpression are allowed")]
        public void WhiteSpaceAndLineTerminatorBetweenAndUnaryExpressionAreAllowed(string file)
        {
            RunFile(file);
        }

        [Test]
        [Category("Sputnik Conformance")]
        [Category("ECMA 11.4.7")]
        [TestCase("S11.4.7_A2.1_T1.js", Description = "Operator -x uses GetValue")]
        [TestCase("S11.4.7_A2.1_T2.js", Description = "Operator -x uses GetValue")]
        public void OperatorXUsesGetValue(string file)
        {
            RunFile(file);
        }

        [Test]
        [Category("Sputnik Conformance")]
        [Category("ECMA 11.4.7")]
        [Category("ECMA 8.6.2.6")]
        [TestCase("S11.4.7_A2.2_T1.js", Description = "Operator -x uses [[Default Value]]")]
        public void OperatorXUsesDefaultValue(string file)
        {
            RunFile(file);
        }

        [Test]
        [Category("Sputnik Conformance")]
        [Category("ECMA 11.4.7")]
        [TestCase("S11.4.7_A3_T1.js", Description = "Operator -x returns -ToNumber(x)")]
        [TestCase("S11.4.7_A3_T2.js", Description = "Operator -x returns -ToNumber(x)")]
        [TestCase("S11.4.7_A3_T3.js", Description = "Operator -x returns -ToNumber(x)")]
        [TestCase("S11.4.7_A3_T4.js", Description = "Operator -x returns -ToNumber(x)")]
        [TestCase("S11.4.7_A3_T5.js", Description = "Operator -x returns -ToNumber(x)")]
        public void OperatorXReturnsToNumberX(string file)
        {
            RunFile(file);
        }

        [Test]
        [Category("Sputnik Conformance")]
        [Category("ECMA 11.4.7")]
        [TestCase("S11.4.7_A4.1.js", Description = "If x is NaN, operator -x returns NaN")]
        public void IfXIsNaNOperatorXReturnsNaN(string file)
        {
            RunFile(file);
        }

        [Test]
        [Category("Sputnik Conformance")]
        [Category("ECMA 11.4.7")]
        [TestCase("S11.4.7_A4.2.js", Description = "Negating +0 produces -0, negating -0 produces +0")]
        public void Negating0Produces0Negating0Produces0(string file)
        {
            RunFile(file);
        }
    }
}