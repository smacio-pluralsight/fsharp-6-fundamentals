// simple local level module declaration
module Mathematics =
    let add x y = x + y
    let subtract x y = x - y

//================================================================================

// using the Mathematics module

// fully qualified
let value1 = Mathematics.add 1 2
 
// or open the module
open Mathematics
let value2 = add 2 3

//================================================================================

// other module samples are in subfolder 05-modules

