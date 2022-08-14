module Transactions.Operations

open System

open Transactions.Domain

module Accounts =
    let private deposit amount account=
        { account with Balance = account.Balance + amount }

    let private withdraw amount account =
        { account with Balance = account.Balance - amount }
        
    module Commands =
        type AccountCommands = | Withdraw of int * decimal | Deposit of int * decimal | Invalid

    module Processors =
        open Commands

        let execute command =
            match command with
                | Withdraw (accountId, amount) ->
                    int accountId |> Repository.Account.get |> deposit amount |> Repository.Account.put
                    true
                | Deposit (accountId, amount) ->
                    int accountId |> Repository.Account.get |> withdraw amount |> Repository.Account.put
                    true
                | Invalid -> false

                    

