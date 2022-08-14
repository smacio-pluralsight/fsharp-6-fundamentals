let tuple1 = 1, "a" 
let tuple2 = (1, "a") 
let tuple3 = (1, "b")
let tuple4 = (1, "a", 2.0, true)
tuple1 = tuple2 
tuple1 = tuple3 
tuple1 = tuple4 

//================================================================================

let tuple = (1, "a")
fst tuple 
snd tuple 

let third (_, _, c) = c
let tuple3 = (1, "b", 2.0)
third tuple3

//================================================================================

let (a, b, c) = (1, "b", 2.0)
let (_, b, _) = (1, "b", 2.0)

let print tuple = 
    match tuple with
    | (a, b) -> printfn "%A %A" a b
print (1, "a") // 1 “a”

//================================================================================

let divRem a b =
    let x = a / b
    let y = a % b
    (x, y)
let (roundedResult, remainder) = divRem 11 2
roundedResult 
remainder 
