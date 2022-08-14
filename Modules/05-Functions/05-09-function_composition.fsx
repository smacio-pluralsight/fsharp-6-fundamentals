let f x  = x * x
let g x = x + 1
g (f 3)
let f_g x = g(f(x))
f_g 3

//================================================================================

f >> g
(f >> g) 3
(>>) f g 3

let composed_right = f >> g // notice, no parameter
composed_right 3

let composed_left = g << f
composed_left 3

//================================================================================

let add x y = x + y
let add1 = add 1
add1 10

let times2 x = x * 2
let add1thenTimes2 = add1 >> times2
add1thenTimes2 5

let times2thenAdd1 = add1 << times2
times2thenAdd1 5
