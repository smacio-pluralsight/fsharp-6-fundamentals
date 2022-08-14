module Transactions.Interaction 

open Transactions.Operations.Accounts.Commands
open Transactions.Operations.Accounts.Processors

open System

let getTransactionAmountFromUser () =
    Console.Write "Amount: "
    Console.ReadLine() |> Decimal.Parse
    
let buildAccountCommand accountId = 
    let action =
        Console.Write "(d)eposit, (w)ithdraw or e(x)it: "
        Console.ReadLine()

    match action with 
    | "w" -> Withdraw (accountId, getTransactionAmountFromUser())
    | "d" -> Deposit (accountId, getTransactionAmountFromUser())
    | _ -> Invalid

let mainLoop () =
    let rec loop () =
        let account = Repository.Account.get 0
        printfn "Current balance: %A" account.Balance

        execute (buildAccountCommand 0) |> ignore

        loop ()
    loop ()
