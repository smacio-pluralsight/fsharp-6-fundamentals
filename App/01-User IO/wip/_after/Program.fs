open System

[<EntryPoint>]
let main argv = 
    printfn "Transaction processor online"

    let mutable balance = 0.0m

    let mutable running = true
    while running do
        printfn "Current balance: %A" balance

        let action = 
            Console.Write("(d)eposit, (w)ithdraw or e(x)it: ")
            Console.ReadLine()
    
        printfn "%A" action

        running <- action <> "x"

    printfn "Bye!"
    
    0
