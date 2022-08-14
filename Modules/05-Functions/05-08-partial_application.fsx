let add x y = x + y 
let add x = fun y -> x + y
add 5 2
(add 5) 2
(fun y -> 5 + y) 2

//================================================================================

let add x y = x + y 
let add x = fun y -> x + y

let add5 = add 5


//================================================================================


let add x y z = x + y + z

let add x =
    fun y ->
        fun z -> x + y + z
add 1 2 3
        
