// <auto-generated />
namespace IronJS.Tests.UnitTests.Sputnik.Conformance.NativeECMAScriptObjects.ArrayObjects.PropertiesOfTheArrayPrototypeObject
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class PropertiesOfTheArrayPrototypeObjectTests : SputnikTestFixture
    {
        public PropertiesOfTheArrayPrototypeObjectTests()
            : base(@"Conformance\15_Native_ECMA_Script_Objects\15.4_Array_Objects\15.4.4_Properties_of_the_Array_Prototype_Object")
        {
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 15.4.4")]
        [TestCategory("ECMA 15.2.4.5")]
        [Description("The value of the internal [[Prototype]] property of the Array prototype object is the Object prototype object")]
        public void S15_4_4_A1_1_T1()
        {
            RunFile(@"S15.4.4_A1.1_T1.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 15.4.4")]
        [TestCategory("ECMA 11.4.1")]
        [Description("The value of the internal [[Prototype]] property of the Array prototype object is the Object prototype object")]
        public void S15_4_4_A1_1_T2()
        {
            RunFile(@"S15.4.4_A1.1_T2.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 15.4.4")]
        [TestCategory("ECMA 15.2.4.6")]
        [Description("The value of the internal [[Prototype]] property of the Array prototype object is the Object prototype object")]
        public void S15_4_4_A1_1_T3()
        {
            RunFile(@"S15.4.4_A1.1_T3.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 15.4.4")]
        [TestCategory("ECMA 15.2.4.2")]
        [Description("The [[Class]] property of the Array prototype object is set to \"Array\"")]
        public void S15_4_4_A1_2_T1()
        {
            RunFile(@"S15.4.4_A1.2_T1.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 15.4.4")]
        [Description("Array prototype object has length property whose value is +0")]
        public void S15_4_4_A1_3_T1()
        {
            RunFile(@"S15.4.4_A1.3_T1.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 15.4.4")]
        [TestCategory("ECMA 15.2.4.5")]
        [Description("The Array prototype object does not have a valueOf property of its own")]
        public void S15_4_4_A2_1_T1()
        {
            RunFile(@"S15.4.4_A2.1_T1.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 15.4.4")]
        [Description("The Array prototype object does not have a valueOf property of its own")]
        public void S15_4_4_A2_1_T2()
        {
            RunFile(@"S15.4.4_A2.1_T2.js");
        }
    }
}