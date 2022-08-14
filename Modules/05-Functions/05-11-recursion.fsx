let sum_imperative items =
    let mutable total = 0 // uh oh, explicit state tracking with a mutable
    for item in items do total <- total + item
    total
sum_imperative [1..3]

//================================================================================

let rec sum items = 
    match items with
    | [] -> 0  // root stop recursing
    | head::tail -> 
        head + (sum tail) // value of head + sum of the tail
sum [1..3]

//================================================================================

let rec sum = function
    | [] -> 0
    | head::tail -> head + (sum tail)
sum [1..3]

//================================================================================

let sum items = 
    let rec loop items accumulator =
        match items with
        | [] -> accumulator
        | head::tail -> loop tail (accumulator  + head)
    loop items 0

sum [1..3]

//================================================================================

List.fold 
    (+)
    0
    [1;2;3]

//================================================================================

