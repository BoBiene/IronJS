// Copyright 2009 the Sputnik authors.  All rights reserved.
// This code is governed by the BSD license found in the LICENSE file.

/**
 * @name: S15.8.2.13_A12;
 * @section: 15.8.2.13;
 * @assertion: If x is +Infinity and y<0, Math.pow(x,y) is +0;
 * @description: Checking if Math.pow(x,y) equals to +0, where x is +Infinity and y<0;
 */
 

// Converted for Test262 from original Sputnik source

ES5Harness.registerTest( {
id: "S15.8.2.13_A12",

path: "TestCases/15_Native/15.8_The_Math_Object/15.8.2_Function_Properties_of_the_Math_Object/15.8.2.13_pow/S15.8.2.13_A12.js",

assertion: "If x is +Infinity and y<0, Math.pow(x,y) is +0",

description: "Checking if Math.pow(x,y) equals to +0, where x is +Infinity and y<0",

test: function testcase() {
   // CHECK#1

x = +Infinity;
y = new Array();
y[0] = -Infinity;
y[1] = -1.7976931348623157E308; //largest (by module) finite number
y[2] = -1;
y[3] = -0.000000000000001;
ynum = 4;

for (i = 0; i < ynum; i++)
{
	if (Math.pow(x,y[i]) !== +0)
	{
		$ERROR("#1: Math.pow(" + x + ", " + y[i] + ") !== +0");
	}
}

 }
});
