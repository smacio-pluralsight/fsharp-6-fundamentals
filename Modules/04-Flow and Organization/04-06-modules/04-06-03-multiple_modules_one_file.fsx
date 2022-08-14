module ARequiredTopeLevelModuleName =

module Mathematics = 
    let add x y = x + y
    let subtract x y = x - y

module OtherCodeThatUsesMathematics =
    let value1 = Mathematics.add 1 2

    open Mathematics
    let value2 = add 2 3
