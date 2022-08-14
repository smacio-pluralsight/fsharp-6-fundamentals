module Transactions.Interaction

open Transactions.Domain
open System

let private promptuser () =
    Console.Write("(d)eposit, (w)ithdraw or e(x)it: ")
    Console.ReadLine()

let private getAmount () =
    Console.Write("Enter the amount of the transaction: ")
    Console.ReadLine() |> Decimal.Parse

let private take action account =
    match action with
    | "d" -> { account with Balance = account.Balance + getAmount() }
    | "w" -> { account with Balance = account.Balance - getAmount() }
    | _ -> account

let mainLoop () =
    Console.WriteLine("Hello from the transaction processor!")

    let rec loop account =
        printfn "Balance: %A" account.Balance

        let action = promptuser()
        printfn "You told me to do this: %A" action

        match action with
        | "d" | "w" -> loop (take action account)
        | "x" -> ()
        | _ ->
            printfn "Unknown command: %A" action
            loop account

    loop { Id=0; Balance=0m }

    Console.WriteLine("Bye!")
    0