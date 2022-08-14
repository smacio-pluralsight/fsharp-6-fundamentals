1 + 3

(+);;
(+) 1 3
((+) ((+) 1 2) 3) 

let add1 = (+) 1
add1 5
// val it: 6

//================================================================================

let distance x y = if x>y then x-y else y-x

let (|><|) x y = distance x y

9 |><| 3
9 |><| 3 |><| 10 // left associative
(|><|) 3 10
