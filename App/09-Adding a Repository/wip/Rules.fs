module Transactions.Rules

open Transactions.Domain

module Accounts =
    let deposit amount account =
        { 
            account with 
                Balance = account.Balance + amount 
        }

    let withdraw amount account =
        { 
            account with 
                Balance = account.Balance - amount 
        }