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
        let updatedAccount = depositOrWithdraw action account 
        Transactions.Repository.Account.put updatedAccount
        updatedAccount
    | _ -> account


let mainLoop () =
    let rec loop (account:Domain.Account) =
        printfn "Current balance: %A" account.Balance

        let action =
            Console.Write "(d)eposit, (w)ithdraw or e(x)it: "
            Console.ReadLine()

        match action with
        | "x" -> ()
        | "d" | "w" -> 
            let updatedAccount = take action account
            loop updatedAccount
        | _ -> loop account

    let account = Transactions.Repository.Account.get()
    loop account
            

