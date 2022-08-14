let add x y = x + y 
let add = fun x -> fun y -> x + y
add 5 2
(fun x -> fun y -> x + y) 5 2
(fun y -> 5 + y) 2
5 + 2

//================================================================================

let add x y z = x + y + z

// identical to:
let add = fun x -> fun y -> fun z -> x + y + z

// add 1 = fun y -> fun z -> 1 + y + z
// add 1 2 = fun z -> 1 + 2 + z
// add 1 2 3 = 1 + 2 + 3


        
