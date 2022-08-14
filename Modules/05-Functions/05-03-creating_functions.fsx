// calculate area from two variables
10 * 10 // expression calculating square of 10

// function parameterizes the expression
let square x = 
    x * x

//================================================================================

let square x = 
    let result = x * x
    result

//================================================================================

square 3
square 3 + 1
square (3 + 1)

//================================================================================

// error
square 3.

//================================================================================

let square (x: float) = x * x
square 3.
square 3

//================================================================================

let square x: float = x * xZ
square 3
square 3.

//================================================================================

let add x y = x + y 
add 1 2

let add (x:int) (y:int) : float =
    x + y

//================================================================================

let getInput =
    System.Console.Write("enter x to exit")
    System.Console.ReadLine() <> "x"

let mainLoop =
    while getInput do () // infinite loops
mainLoop

//================================================================================

let getInput() =
    System.Console.Write("enter x to exit")
    System.Console.ReadLine() = "x"

let mainLoop() =
    while getInput() do () // infinite loops
mainLoop()