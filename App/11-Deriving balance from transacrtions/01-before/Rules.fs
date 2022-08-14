module Transactions.Rules

open Transactions.Domain

module Accounts =
    let private nextTransactionId account = 
        match account.Transactions with
        | [] -> 0
        | _ ->
            account.Transactions 
            |> List.map (fun t -> t.Id)
            |> List.max
            |> (+) 1

    let private buildNewAccount account amount transaction =
        {
            account with    
                Balance = account.Balance + amount
                Transactions = List.append account.Transactions [transaction]
        }

    let deposit amount account = 
        let newtransaction = Transaction.NewDeposit (nextTransactionId account) amount 
        buildNewAccount account amount newtransaction

    let withdraw amount account = 
        let newtransaction = Transaction.NewWithdraw (nextTransactionId account) amount 
        buildNewAccount account -amount newtransaction
