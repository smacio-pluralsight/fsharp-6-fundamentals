open System

[<EntryPoint>]
let main argv =
    Console.WriteLine("Hello from the transaction processor!")

    Transactions.Driver.UserConsole.userLoop()

    Console.WriteLine("Bye!")
    0