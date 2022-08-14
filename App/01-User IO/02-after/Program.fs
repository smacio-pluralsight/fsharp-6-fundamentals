open System

[<EntryPoint>]
let main argv =
    Console.WriteLine("Hello from the transaction processor!")

    Console.Write("(d)eposit, (w)ithdraw or e(x)it: ")
    let action = Console.ReadLine()
    printfn "You told me to do this: %A" action

    Console.WriteLine("Bye!")
    0