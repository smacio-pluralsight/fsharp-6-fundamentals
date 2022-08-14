open System

[<EntryPoint>]
let main argv = 
    printfn "Hello from the transaction processor"

    Transactions.Interaction.mainLoop()

    0
