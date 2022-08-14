open System

let promptuser () =
    Console.Write("(d)eposit, (w)ithdraw or e(x)it: ")
    Console.ReadLine()

let getAmount () =
    Console.Write("Enter the amount of the transaction: ")
    Console.ReadLine() |> Decimal.Parse

[<EntryPoint>]
let main argv =
    Console.WriteLine("Hello from the transaction processor!")

    let mutable balance = 0m

    let mutable running = true
    while running do
        printfn "Balance: %A" balance

        let action = promptuser()
        printfn "You told me to do this: %A" action

        balance <- 
            match action with
            | "d" -> balance + getAmount()
            | "w" -> balance - getAmount()
            | _ ->
                running <- action <> "x"
                balance

    Console.WriteLine("Bye!")
    0