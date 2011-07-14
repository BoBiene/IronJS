// Copyright 2009 the Sputnik authors.  All rights reserved.
// This code is governed by the BSD license found in the LICENSE file.

/**
 * @name: S15.9.4_A2;
 * @section: 15.9.4;
 * @assertion: The Date constructor has the property "parse";
 * @description: Checking existence of the property "parse";
 */


// Converted for Test262 from original Sputnik source

ES5Harness.registerTest( {
id: "S15.9.4_A2",

path: "TestCases/15_Native/15.9_Date_Objects/15.9.4_Properties_of_the_Date_Constructor/S15.9.4_A2.js",

assertion: "The Date constructor has the property \"parse\"",

description: "Checking existence of the property \"parse\"",

test: function testcase() {
   if(!Date.hasOwnProperty("parse")){
  $ERROR('#1: The Date constructor has the property "parse"');
}


 }
});
