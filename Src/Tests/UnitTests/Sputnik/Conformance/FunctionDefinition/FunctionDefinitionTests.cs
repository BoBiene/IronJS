// <auto-generated />
namespace IronJS.Tests.UnitTests.Sputnik.Conformance.FunctionDefinition
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class FunctionDefinitionTests : SputnikTestFixture
    {
        public FunctionDefinitionTests()
            : base(@"Conformance\13_Function_Definition")
        {
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 13")]
        [Description("\"x=function y(){}\" statement does not store a reference to the new function in the varaible y(Identifier)")]
        public void S13_A1()
        {
            RunFile(@"S13_A1.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 13")]
        [Description("Function is a data")]
        public void S13_A10()
        {
            RunFile(@"S13_A10.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 13")]
        [Description("Since arguments property has attribute { DontDelete }, only its elements can be deleted")]
        public void S13_A11_T1()
        {
            RunFile(@"S13_A11_T1.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 13")]
        [Description("Since arguments property has attribute { DontDelete }, only its elements can be deleted")]
        public void S13_A11_T2()
        {
            RunFile(@"S13_A11_T2.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 13")]
        [Description("Since arguments property has attribute { DontDelete }, only its elements can be deleted")]
        public void S13_A11_T3()
        {
            RunFile(@"S13_A11_T3.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 13")]
        [Description("Since arguments property has attribute { DontDelete }, only its elements can be deleted")]
        public void S13_A11_T4()
        {
            RunFile(@"S13_A11_T4.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 13")]
        [Description("Function declarations in global or function scope are {DontDelete}")]
        public void S13_A12_T1()
        {
            RunFile(@"S13_A12_T1.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 13")]
        [Description("Function declarations in global or function scope are {DontDelete}")]
        public void S13_A12_T2()
        {
            RunFile(@"S13_A12_T2.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 13")]
        [Description("Deleting arguments[i] leads to breaking the connection to local reference")]
        public void S13_A13_T1()
        {
            RunFile(@"S13_A13_T1.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 13")]
        [Description("Deleting arguments[i] leads to breaking the connection to local reference")]
        public void S13_A13_T2()
        {
            RunFile(@"S13_A13_T2.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 13")]
        [Description("Deleting arguments[i] leads to breaking the connection to local reference")]
        public void S13_A13_T3()
        {
            RunFile(@"S13_A13_T3.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 13")]
        [Description("Unicode symbols in function name are allowed")]
        public void S13_A14()
        {
            RunFile(@"S13_A14.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 13")]
        [Description("\'\'arguments\'\' variable overrides ActivationObject.arguments")]
        public void S13_A15_T1()
        {
            RunFile(@"S13_A15_T1.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 13")]
        [Description(" \'\'arguments\'\' variable overrides ActivationObject.arguments")]
        public void S13_A15_T2()
        {
            RunFile(@"S13_A15_T2.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 13")]
        [Description("\'\'arguments\'\' variable overrides ActivationObject.arguments")]
        public void S13_A15_T3()
        {
            RunFile(@"S13_A15_T3.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 13")]
        [Description("\'\'arguments\'\' variable overrides ActivationObject.arguments")]
        public void S13_A15_T4()
        {
            RunFile(@"S13_A15_T4.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 13")]
        [Description("\'\'arguments\'\' variable overrides ActivationObject.arguments")]
        public void S13_A15_T5()
        {
            RunFile(@"S13_A15_T5.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 13")]
        [Description("Any separators are admitted between declaration chunks")]
        public void S13_A16()
        {
            RunFile(@"S13_A16.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 13")]
        [Description("Function call cannot appear in the program before the FunctionExpression appears")]
        public void S13_A17_T1()
        {
            RunFile(@"S13_A17_T1.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 13")]
        [Description("Function call cannot appear in the program before the FunctionExpression appears")]
        public void S13_A17_T2()
        {
            RunFile(@"S13_A17_T2.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 13")]
        [Description("Closures are admitted")]
        public void S13_A18()
        {
            RunFile(@"S13_A18.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 13,13.2")]
        [Description("\"var\" does not override function declaration")]
        public void S13_A19_T1()
        {
            RunFile(@"S13_A19_T1.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 13,13.2")]
        [Description("\"var\" does not override function declaration")]
        public void S13_A19_T2()
        {
            RunFile(@"S13_A19_T2.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 13")]
        [Description("function must be evaluated inside the expression")]
        public void S13_A2_T1()
        {
            RunFile(@"S13_A2_T1.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 13")]
        [Description("function must be evaluated inside the expression")]
        public void S13_A2_T2()
        {
            RunFile(@"S13_A2_T2.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 13")]
        [Description("function must be evaluated inside the expression")]
        public void S13_A2_T3()
        {
            RunFile(@"S13_A2_T3.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 13")]
        [Description("The Identifier in a FunctionExpression can be referenced from inside the FunctionExpression\'s FunctionBody to allow the function calling itself recursively")]
        public void S13_A3_T1()
        {
            RunFile(@"S13_A3_T1.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 13")]
        [Description("The Identifier in a FunctionExpression can be referenced from inside the FunctionExpression\'s FunctionBody to allow the function calling itself recursively")]
        public void S13_A3_T2()
        {
            RunFile(@"S13_A3_T2.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 13")]
        [Description("The Identifier in a FunctionExpression can be referenced from inside the FunctionExpression\'s FunctionBody to allow the function calling itself recursively")]
        public void S13_A3_T3()
        {
            RunFile(@"S13_A3_T3.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 13")]
        [Description("The production FunctionDeclaration: \"function Identifier ( FormalParameterList_opt ) { FunctionBody }\" is processed by function declarations")]
        public void S13_A4_T1()
        {
            RunFile(@"S13_A4_T1.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 13")]
        [Description("The production FunctionDeclaration: \"function Identifier ( FormalParameterList_opt ) { FunctionBody }\" is processed by function declarations")]
        public void S13_A4_T2()
        {
            RunFile(@"S13_A4_T2.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 13")]
        [Description("The production FunctionDeclaration: \"function Identifier ( FormalParameterList_opt ) { FunctionBody }\" is processed by function declarations")]
        public void S13_A4_T3()
        {
            RunFile(@"S13_A4_T3.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 13")]
        [Description("The production FunctionDeclaration: \"function Identifier ( FormalParameterList_opt ) { FunctionBody }\" is processed by function declarations")]
        public void S13_A4_T4()
        {
            RunFile(@"S13_A4_T4.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 13")]
        [TestCategory("ECMA 10.1.2")]
        [Description("Only FormalParameterList as arguments list is allowed")]
        public void S13_A5()
        {
            RunFile(@"S13_A5.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 13")]
        [Description("FunctionDeclaration can be overrided by other FunctionDeclaration with the same Identifier")]
        public void S13_A6_T1()
        {
            RunFile(@"S13_A6_T1.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 13")]
        [Description("FunctionDeclaration can be overrided by other FunctionDeclaration with the same Identifier")]
        public void S13_A6_T2()
        {
            RunFile(@"S13_A6_T2.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 13")]
        [Description("The FunctionBody must be SourceElements")]
        public void S13_A7_T1()
        {
            RunFile(@"S13_A7_T1.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 13")]
        [Description("The FunctionBody must be SourceElements")]
        public void S13_A7_T2()
        {
            RunFile(@"S13_A7_T2.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 13")]
        [Description("The FunctionBody must be SourceElements")]
        public void S13_A7_T3()
        {
            RunFile_ExpectException(@"S13_A7_T3.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 13")]
        [Description("Arguments property of activation object contains real params to be passed")]
        public void S13_A8_T1()
        {
            RunFile(@"S13_A8_T1.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 13")]
        [Description("Arguments property of activation object contains real params to be passed")]
        public void S13_A8_T2()
        {
            RunFile(@"S13_A8_T2.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 13")]
        [Description("Function can be passed as argument")]
        public void S13_A9()
        {
            RunFile(@"S13_A9.js");
        }
    }
}