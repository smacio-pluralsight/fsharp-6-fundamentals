// top level module, no =, and code is not indented (Mathematics.fs)
module Mathematics 
let add x y = x + y // Mathematics.Add
let subtract x y = x - y // Mathematics.subtract
let addResult = add 1 2 // Mathematics.addResult

// nested module (s) 
// Mathematics.FloatingPointMathematics
module FloatingPoint = 
    let add x y :float = x + y // Mathematics.FloatingPoint.add
    let subtract x y :float = x - y // Mathematics.FloatingPoint.subtract

// Mathematics.AnotherModule
module AnotherModule = 
    let value1 = add 2 3 // Mathematics not needed
    let value2 = FloatingPoint.subtract 2. 1. // Part of the Mathematics module
