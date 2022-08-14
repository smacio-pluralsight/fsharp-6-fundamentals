printfn "HI!" // val it : unit = ()

let myFunWithUnit a b =
    printfn "%A" (a+b)
    () // not strictly needed as printfn also returns ()

myFunWithUnit 1 2 // val it : unit = () 
3 
