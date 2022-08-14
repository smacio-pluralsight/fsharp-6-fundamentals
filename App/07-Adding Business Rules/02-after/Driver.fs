module Transactions.Driver

open System

open Transactions.Domain
open Transactions.Rules.Accounts

module UserConsole =
    let private promptuser () =
        Console.Write("(d)eposit, (w)ithdraw or e(x)it: ")
        Console.ReadLine()

    let private getAmount () =
        Console.Write("Enter the amount of the transaction: ")
        Console.ReadLine() |> Decimal.Parse

    let run () =
        let rec loop account =
            printfn "Balance: %A" account.Balance

            let action = promptuser()
            printfn "You told me to do this: %A" action

            match action with
            | "d" -> loop (deposit (getAmount()) account)
            | "w" -> loop (withdraw (getAmount()) account)
            | "x" -> ()
            | _ ->
                printfn $"Invalid action: {action}"
                loop account

        loop Account.Default
        ()