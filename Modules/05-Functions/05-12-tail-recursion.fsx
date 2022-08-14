// non-tail recursive sum
let rec sum items = 
    match items with
    | [] -> 0
    | head::tail -> head + sum tail
sum [1..100000]  
// blows up the terminal

// non-tail recursive sum
let rec sum running_total items = 
    match items with
    | [] -> running_total
    | head::tail -> 
        sum (running_total + head) tail
sum 0 [1..100000]
// val it: int = 705082704

//================================================================================

// imperative
let mutable state = 0
let mutable running = true

while running do
    printfn $"State: {state}"
    let i = System.Console.ReadLine()
    let (s, v) = System.Int32.TryParse i
    match s with
    | true -> state <- state + v
    | false -> if i = "x" then 
                   running <- false

// tail-recursive
let rec appLoop state =
    printfn $"State: {state}"
    let i = System.Console.ReadLine()
    let (s, v) = System.Int32.TryParse i
    match s with
    | true -> appLoop (state + v)
    | _ -> if i <> "x" then appLoop state
appLoop 0

