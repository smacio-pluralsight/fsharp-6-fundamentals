open System

let promptuser () =
    Console.Write("(d)eposit, (w)ithdraw or e(x)it: ")
    Console.ReadLine()

[<EntryPoint>]
let main argv =
    Console.WriteLine("Hello from the transaction processor!")

    let mutable running = true
    while running do
        let action = promptuser()
        printfn "You told me to do this: %A" action

        running <- action <> "x"

    Console.WriteLine("Bye!")
    0