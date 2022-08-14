module Transactions.Interaction 

open Transactions.Domain
open Transactions.Operations.Accounts.Commands
open Transactions.Operations.Accounts.Processors

open System

let getTransactionAmountFromUser () =
    Console.Write "Amount: "
    Console.ReadLine() |> Decimal.Parse

let getActionFromUser () =
    Console.Write "(d)eposit, (w)ithdraw or e(x)it: "
    Console.ReadLine()

let dumpAccount account =
    printfn "Id       %A" account.Id
    printfn "Balance: %A" account.Balance
    account.Transactions |> List.iter (fun t -> printfn "    %A %A %A" t.Id t.Type t.Amount)

let performAction action accountId =
    match action with
    | "w" -> Withdraw (accountId, getTransactionAmountFromUser())
    | "d" -> Deposit (accountId, getTransactionAmountFromUser())
    | _ -> Invalid
    |> execute |> ignore

let mainLoop () =
    let rec loop account =
        dumpAccount account

        let action = getActionFromUser()
        match action with
        | "x" -> printfn "Bye!"
        | "d" | "w"-> 
            performAction action account.Id
            loop (Repository.Account.get account.Id)
        | _ -> 
            printfn "Invalid action entered"
            loop account

    loop (Repository.Account.get 0)