let compare x y = 
    if x = y then $"{x} equals {y}"
    else if x < y then $"{x} is less than {y}"
    else $"{x} is greater than {y}"
// val compare: x: 'a -> y: 'a -> string when 'a: comparison

compare 1 2 // val it: string = "1 is less than 2"
compare 2 1 // val it: string = "2 is greater than 1"
compare 2 2 // val it: string = "2 equals 2"

//================================================================================

let a = 2
let x = if a=1 then "a is one" // invalid F#
if a=2 then printfn "a is 2" // is valid without else because unit


