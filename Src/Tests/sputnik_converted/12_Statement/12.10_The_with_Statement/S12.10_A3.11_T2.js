// Copyright 2009 the Sputnik authors.  All rights reserved.
// This code is governed by the BSD license found in the LICENSE file.

/**
 * @name: S12.10_A3.11_T2;
 * @section: 12.10;
 * @assertion: No matter how control leaves the embedded 'Statement', 
 * the scope chain is always restored to its former state;
 * @description: Calling a function within "with" statement declared without the statement, leading to normal completion by "return";
 * @strict_mode_negative
 */

// Converted for Test262 from original Sputnik source

ES5Harness.registerTest( {
id: "S12.10_A3.11_T2",

path: "TestCases/12_Statement/12.10_The_with_Statement/S12.10_A3.11_T2.js",

assertion: "No matter how control leaves the embedded \'Statement\',",

description: "Calling a function within \"with\" statement declared without the statement, leading to normal completion by \"return\"",

test: function testcase() {
   this.p1 = 1;
var result = "result";
var value = "value";
var myObj = {p1: 'a', 
             value: 'myObj_value',
             valueOf : function(){return 'obj_valueOf';}
}

var f = function(){
  p1 = 'x1';
  return value;
}

with(myObj){
  result = f();
}

if(!(p1 === "x1")){
  $ERROR('#1: p1 === "x1". Actual:  p1 ==='+ p1  );
}

if(!(myObj.p1 === "a")){
  $ERROR('#2: myObj.p1 === "a". Actual:  myObj.p1 ==='+ myObj.p1  );
}

if(!(result === "value")){
  $ERROR('#3: result === "value". Actual:  result ==='+ result  );
}

 }
});
