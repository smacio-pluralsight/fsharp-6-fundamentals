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

    let private buildNewAccount account transaction =
        let transactions = List.append account.Transactions [transaction]
        let balance =
            transactions
            |> List.map (fun t -> 
                match t.Type with
                | Deposit -> t.Amount
                | Withdraw -> -t.Amount)
            |> List.sum
        {
            account with    
                Balance = balance
                Transactions = transactions
        }

    let deposit amount account = 
        let newtransaction = Transaction.NewDeposit (nextTransactionId account) amount 
        buildNewAccount account newtransaction

    let withdraw amount account = 
        let newtransaction = Transaction.NewWithdraw (nextTransactionId account) amount 
        buildNewAccount account newtransaction
