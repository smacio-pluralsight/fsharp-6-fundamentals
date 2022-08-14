exception Error1 of string * int 
exception Error2 of string * int * int
let function1 x y =
    try
        if x = y then raise (Error1($"Values are equal", x))
        else raise (Error2($"Values are not equal", x, y))
    with
        | Error1(str, x) -> printfn $"{str} {x}"
        | Error2(str, x, y) -> printfn $"{str} {x} {y}"
function1 10 10
function1 9 2

//================================================================================

let function1 x y =
    try
        try
            if x = y then raise (Error1($"Values are equal", x))
            else raise (Error2($"Values are not equal", x, y))
        with
            | Error1(str, x) -> printfn $"{str} {x}"
    finally
        printfn "all done"

function1 10 10
function1 9 2

