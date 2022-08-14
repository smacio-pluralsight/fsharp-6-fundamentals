module Mathematics = 
    let add x y = x + y
    let subtract x y = x - y

    // Nested module within Mathematics
    module FloatingPoint =
        let add x y :float = x + y
        let subtract x y :float = x-y

let result1 = Mathematics.add 1 2 // val result1: int = 3
let result2 = Mathematics.FloatingPoint.add 2. 3. // val result1: float = 5
