// <auto-generated />
namespace IronJS.Tests.UnitTests.Sputnik.Conformance.Expressions.PrimaryExpressions
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class IdentifierReferenceTests : SputnikTestFixture
    {
        public IdentifierReferenceTests()
            : base(@"Conformance\11_Expressions\11.1_Primary_Expressions\11.1.2_Identifier_Reference")
        {
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 11.1.2")]
        [Description("The result of evaluating an Identifier is always a value of type Reference")]
        public void S11_1_2_A1_T1()
        {
            RunFile(@"S11.1.2_A1_T1.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 11.1.2")]
        [Description("The result of evaluating an Identifier is always a value of type Reference")]
        public void S11_1_2_A1_T2()
        {
            RunFile(@"S11.1.2_A1_T2.js");
        }
    }
}