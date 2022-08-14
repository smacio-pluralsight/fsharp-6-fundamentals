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
        let input = Console.ReadLine() 
        let (success, value) = input |> Decimal.TryParse
        match success with
        | true -> Ok value
        | false -> Error $"Parse of amount failed: {input}"

    let run () =
        let rec loop account =
            printfn "Balance: %A" account.Balance

            let action = promptuser()
            printfn "You told me to do this: %A" action

            match action with
            | "d" | "w" ->
                match getAmount() with
                | Ok value ->
                    match action with
                    | "d" -> loop (deposit value account)
                    | "w" -> loop (withdraw value account)
                    | _ -> loop account
                | Error e ->
                    printfn "%A" e
                    loop account
            | "x" -> ()
            | _ ->
                printfn $"Invalid action: {action}"
                loop account

        loop Account.Default
        ()