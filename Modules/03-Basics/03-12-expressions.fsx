let IfAsExpression aBool =
    if aBool then
        42
    else 
        0

let IfAsExpressionShortend aBool =
    if aBool then 42 else 0

//================================================================================

let result = IfAsExpressionShortend true // var result: int = 42

//================================================================================

let square x = x * x

let result = square 5 // ok, binds 25 to result 
square 5 // compile warning, the result is not handled

ignore (square 5) // ok, result was “handled” by explicitly ignoring it

square 5 |> ignore // A nicer syntax using the forward pipe operator
