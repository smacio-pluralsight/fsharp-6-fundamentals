module MyModule =
    let w = 1
    let public x = 2
    let private y = 3
    let internal z = 4

module AnotherModule =
    open MyModule
    MyModule.w
    MyModule.x
    MyModule.y
    MyModule.z

// in another assembly
module ModuleInAnotherAssembly =
    open MyModule
    MyModule.w
    MyModule.x
    MyModule.y
    MyModule.z
