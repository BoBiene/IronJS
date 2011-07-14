// Copyright 2009 the Sputnik authors.  All rights reserved.
// This code is governed by the BSD license found in the LICENSE file.

/**
 * @name: S12.13_A2_T7;
 * @section: 12.13;
 * @assertion: "throw Expression" returns (throw, GetValue(Result(1)), empty), where 1 evaluates Expression;
 * @description: Throwing Array;
 */


// Converted for Test262 from original Sputnik source

ES5Harness.registerTest( {
id: "S12.13_A2_T7",

path: "TestCases/12_Statement/12.13_The_throw_statement/S12.13_A2_T7.js",

assertion: "\"throw Expression\" returns (throw, GetValue(Result(1)), empty), where 1 evaluates Expression",

description: "Throwing Array",

test: function testcase() {
   var mycars = new Array();
mycars[0] = "Saab";
mycars[1] = "Volvo";
mycars[2] = "BMW";

var mycars2 = new Array();
mycars2[0] = "Mercedes";
mycars2[1] = "Jeep";
mycars2[2] = "Suzuki";

// CHECK#1
try{
  throw mycars;
}
catch(e){
  for (var i=0;i<3;i++){
    if (e[i]!==mycars[i]) $ERROR('#1.'+i+': Exception['+i+'] === mycars['+i+']. Actual:  Exception['+i+'] ==='+ e[i]  );
  }
}

 }
});
