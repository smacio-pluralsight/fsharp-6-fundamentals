let a = 1 // top level – cannot be repurposed

let afunction x =
    printfn "%A" a // prints 1 on the console.  Please never do this!
    printfn "%A" (x + 10) // prints x+20 on the console
    let x = 10 // repurpose x as int = 10 (parameter x is shadowed)
    printfn "%A" (x + 10) // prints 30 on the console
    let x = "Hello!" // x = 10 is shadowed
    let x = 100.0 // x = "Hello!" is shadowed
    x * 10.0 // returns 1000.0
afunction 5 // prints 1, 15, 20, returns 1000.0

//================================================================================

let a = "Can't do this" // duplicate definition

let afunction () = 
    let a = 10
    let subfunction x = a * x
    // subfunction has closed a, is x = 10 * x
    printfn "%A" (subfunction 1) // 10 * 1
    let a = 5 // this is a different a, subfunction closed the previous a
    printfn "%A" (subfunction 2) // 10 * 2 = 20, not 
afunction ()


//================================================================================

let a = 2 // val it : int = 2
let b = 3 // val it : int = 3
let a = 4 in a*b // val it: int = 12
let a = 5 in let b = 6 in a*b // val it: int = 30
a // val it: int = 2
