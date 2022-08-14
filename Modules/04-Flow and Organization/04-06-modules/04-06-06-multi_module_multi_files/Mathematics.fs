// if both module defs are in the same file, we need a top level module (or namespace)
module ARequiredTopLevelModuleName

module Mathematics = // ARequiredTopLevelModuleName.AnotherModule
    let add x y = x + y
    let subtract x y = x - y
module AnotherModule = // ARequiredTopLevelModuleName.AnotherModule
    let value1 = Mathematics.add 1 2
    open Mathematics
    let value2 = add 2 3
