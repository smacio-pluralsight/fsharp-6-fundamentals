module TippyTopModule 
let mult x y = x * y

module Mathematics = // Mathematics, not TippyTopModule.Mathematics
    let add x y = x + y
    let subtract x y = x - y

printfn "%A" (mult 2 3) // mult, not TippyTopModule.mult
printfn "%A" (Mathematics.add 1 2) // no TippyTopModule either