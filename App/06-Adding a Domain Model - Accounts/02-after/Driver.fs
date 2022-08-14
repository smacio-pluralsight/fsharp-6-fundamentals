module Transactions.Driver

open System

open Transactions.Domain

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
            | "d" -> loop ({ Id = account.Id; Balance = account.Balance + getAmount() })
            | "w" -> loop ({ Id = account.Id; Balance = account.Balance - getAmount() })
            | "x" -> ()
            | _ ->
                printfn $"Invalid action: {action}"
                loop account

        loop Account.Default
        ()