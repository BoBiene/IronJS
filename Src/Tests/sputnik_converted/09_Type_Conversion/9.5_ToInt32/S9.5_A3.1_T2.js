// Copyright 2009 the Sputnik authors.  All rights reserved.
// This code is governed by the BSD license found in the LICENSE file.

/**
 * @name: S9.5_A3.1_T2;
 * @section: 9.5;
 * @assertion: Operator uses ToNumber;
 * @description: Type(x) is Number; 
*/


// Converted for Test262 from original Sputnik source

ES5Harness.registerTest( {
id: "S9.5_A3.1_T2",

path: "TestCases/09_Type_Conversion/9.5_ToInt32/S9.5_A3.1_T2.js",

assertion: "Operator uses ToNumber",

description: "Type(x) is Number",

test: function testcase() {
   // CHECK#1
if ((new Number(1) << 0) !== 1) {
  $ERROR('#1: (new Number(1) << 0) === 1. Actual: ' + ((new Number(1) << 0)));
}

// CHECK#2
if ((-1.234 << 0) !== -1) {
  $ERROR('#2: (-1.234 << 0) === -1. Actual: ' + ((-1.234 << 0)));
}

 }
});
