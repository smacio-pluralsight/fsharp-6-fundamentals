let func1 x =
    x + 1

let func2 x =
    func1 1 * 2 |> ignore  // ok
    func3 x * 2  // compile error – func3 undefined
    
let func3 x =
    x * x
