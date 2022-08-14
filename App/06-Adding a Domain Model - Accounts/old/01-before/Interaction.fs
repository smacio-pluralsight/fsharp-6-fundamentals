module Transactions.Interaction

open System

let private promptuser () =
    Console.Write("(d)eposit, (w)ithdraw or e(x)it: ")
    Console.ReadLine()

let private getAmount () =
    Console.Write("Enter the amount of the transaction: ")
    Console.ReadLine() |> Decimal.Parse

let private take action balance =
    match action with
    | "d" -> balance + getAmount()
    | "w" -> balance + getAmount()
    | _ -> balance

let mainLoop () =
    Console.WriteLine("Hello from the transaction processor!")

    let rec loop balance =
        printfn "Balance: %A" balance

        let action = promptuser()
        printfn "You told me to do this: %A" action

        match action with
        | "d" | "w" -> loop (take action balance)
        | "x" -> ()
        | _ ->
            printfn "Unknown command: %A" action
            loop balance

    loop 0m

    Console.WriteLine("Bye!")
    0