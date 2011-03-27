// <auto-generated />
namespace IronJS.Tests.UnitTests.Sputnik.Conformance.NativeECMAScriptObjects.ArrayObjects.PropertiesOfTheArrayPrototypeObject
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class ArrayPrototypeConstructorTests : SputnikTestFixture
    {
        public ArrayPrototypeConstructorTests()
            : base(@"Conformance\15_Native_ECMA_Script_Objects\15.4_Array_Objects\15.4.4_Properties_of_the_Array_Prototype_Object\15.4.4.1_Array_prototype_constructor")
        {
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 15.4.4.1")]
        [Description("The initial value of Array.prototype.constructor is the built-in Array constructor")]
        public void S15_4_4_1_A1_T1()
        {
            RunFile(@"S15.4.4.1_A1_T1.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 15.4.4.1")]
        [TestCategory("ECMA 15.2.4.7")]
        [TestCategory("ECMA 12.6.4")]
        [Description("The constructor property of Array has the attribute DontEnum")]
        public void S15_4_4_1_A2()
        {
            RunFile(@"S15.4.4.1_A2.js");
        }
    }
}