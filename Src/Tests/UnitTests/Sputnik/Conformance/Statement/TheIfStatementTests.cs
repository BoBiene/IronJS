// <auto-generated />
namespace IronJS.Tests.UnitTests.Sputnik.Conformance.Statement
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class TheIfStatementTests : SputnikTestFixture
    {
        public TheIfStatementTests()
            : base(@"Conformance\12_Statement\12.5_The_if_Statement")
        {
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 12.5")]
        [Description("0, null, undefined, false, empty string, NaN in expression is evaluated to false")]
        public void S12_5_A1_1_T1()
        {
            RunFile(@"S12.5_A1.1_T1.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 12.5")]
        [Description("0, null, undefined, false, empty string, NaN in expression is evaluated to false")]
        public void S12_5_A1_1_T2()
        {
            RunFile(@"S12.5_A1.1_T2.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 12.5")]
        [Description("1, true, non-empty string and others in expression is evaluated to true when using operator \"new\"")]
        public void S12_5_A1_2_T1()
        {
            RunFile(@"S12.5_A1.2_T1.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 12.5")]
        [Description("1, true, non-empty string and others in expression is evaluated to true when using operator \"new\"")]
        public void S12_5_A1_2_T2()
        {
            RunFile(@"S12.5_A1.2_T2.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 12.5")]
        [Description("1, true, non-empty string in expression is evaluated to true")]
        public void S12_5_A1_T1()
        {
            RunFile(@"S12.5_A1_T1.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 12.5")]
        [Description("1, true, non-empty string in expression is evaluated to true")]
        public void S12_5_A1_T2()
        {
            RunFile(@"S12.5_A1_T2.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 12.5")]
        [Description("Function expession inside the \"if\" expression is allowed")]
        public void S12_5_A10_T1()
        {
            RunFile(@"S12.5_A10_T1.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 12.5")]
        [Description("Function expession inside the \"if\" expression is allowed")]
        public void S12_5_A10_T2()
        {
            RunFile(@"S12.5_A10_T2.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 12.5")]
        [Description("{} within the \"if\" expression is not allowed")]
        public void S12_5_A11()
        {
            RunFile_ExpectException(@"S12.5_A11.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 12.5")]
        [Description("Embedded \"if/else\" constructions are allowed")]
        public void S12_5_A12_T1()
        {
            RunFile(@"S12.5_A12_T1.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 12.5")]
        [Description("Embedded \"if/else\" constructions are allowed")]
        public void S12_5_A12_T2()
        {
            RunFile(@"S12.5_A12_T2.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 12.5")]
        [Description("Embedded \"if/else\" constructions are allowed")]
        public void S12_5_A12_T3()
        {
            RunFile(@"S12.5_A12_T3.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 12.5")]
        [Description("Embedded \"if/else\" constructions are allowed")]
        public void S12_5_A12_T4()
        {
            RunFile(@"S12.5_A12_T4.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 12.5")]
        [Description("In the \"if\" Statement eval in Expression is admitted")]
        public void S12_5_A2()
        {
            RunFile_ExpectException(@"S12.5_A2.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 12.5")]
        [Description("When the production \"IfStatement: if ( Expression ) Statement else Statement\" is evaluated, Expression is evaluated first")]
        public void S12_5_A3()
        {
            RunFile(@"S12.5_A3.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 12.5")]
        [Description("When the production \"IfStatement: if ( Expression ) Statement else Statement\" is evaluated, Statement(s) is(are) evaluated second")]
        public void S12_5_A4()
        {
            RunFile(@"S12.5_A4.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 12.5")]
        [Description("FunctionDeclaration inside the \"if\" Expression is evaluated as true and function will not be declarated")]
        public void S12_5_A5()
        {
            RunFile(@"S12.5_A5.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 12.5")]
        [Description("In the If statement expression must be enclosed in braces")]
        public void S12_5_A6_T1()
        {
            RunFile_ExpectException(@"S12.5_A6_T1.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 12.5")]
        [Description("In the If statement expression must be enclosed in braces")]
        public void S12_5_A6_T2()
        {
            RunFile_ExpectException(@"S12.5_A6_T2.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 12.5")]
        [Description("In the \"if\" statement empty statement is allowed and is evaluated to \"undefined\"")]
        public void S12_5_A7()
        {
            RunFile(@"S12.5_A7.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 12.5")]
        [Description("In the \"if\" Statement empty expression is not allowed")]
        public void S12_5_A8()
        {
            RunFile_ExpectException(@"S12.5_A8.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 12.5")]
        [Description("Function declaration within an \"if\" statement is not allowed")]
        public void S12_5_A9_T1()
        {
            RunFile_ExpectException(@"S12.5_A9_T1.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 12.5")]
        [Description("Function declaration within an \"if\" statement is not allowed")]
        public void S12_5_A9_T2()
        {
            RunFile_ExpectException(@"S12.5_A9_T2.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 12.5")]
        [Description("Function declaration within an \"if\" statement is not allowed")]
        public void S12_5_A9_T3()
        {
            RunFile_ExpectException(@"S12.5_A9_T3.js");
        }
    }
}