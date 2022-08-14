module Transactions.Interaction

open System

let private promptuser () =
    Console.Write("(d)eposit, (w)ithdraw or e(x)it: ")
    Console.ReadLine()

let private getAmount () =
    Console.Write("Enter the amount of the transaction: ")
    Console.ReadLine() |> Decimal.Parse

let mainLoop () =
    Console.WriteLine("Hello from the transaction processor!")

    let mutable balance = 0.0m

    let mutable running = true
    while running do
        printfn "Balance: %A" balance

        let action = promptuser()
        printfn "You told me to do this: %A" action

        balance <-
            match action with 
            | "d" | "w" ->
                match action with
                | "d" -> balance + getAmount()
                | _ -> balance - getAmount()
            | _ -> balance

        running <- action <> "x"

    Console.WriteLine("Bye!")
    0