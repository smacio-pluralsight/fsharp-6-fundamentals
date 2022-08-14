module Transactions.Interaction

open System
open Transactions.Repository

let private depositOrWithdraw action account =
    let amount = 
        Console.Write "Amount: "
        Console.ReadLine() |> Decimal.Parse
    match action with
        | "w" -> Transactions.Operations.Accounts.withdraw account amount
        | "d" -> Transactions.Operations.Accounts.deposit account amount
        | _ -> account

let private take action account =
    match action with
    | "d" | "w" -> 
        let updated = depositOrWithdraw action account 
        Transactions.Repository.Account.put updated
        true
    | "x" -> false
    | _ -> true

let mainLoop () =
    let mutable running = true
    while running do
        let account = Account.get()
        printfn "Current balance: %A" account.Balance

        let action =
            Console.Write "(d)eposit, (w)ithdraw or e(x)it: "
            Console.ReadLine()

        running <- 
            match action with
            | "d" | "w" -> 
                take action account |> ignore
                true 
            | "x" -> false
            | _ -> true

        printfn "%A" running
