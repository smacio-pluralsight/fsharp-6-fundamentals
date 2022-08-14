module Transactions.Operations

open Transactions.Domain

module Accounts =
    let deposit account amount=
        { account with Balance = account.Balance + amount }

    let withdraw account amount =
        { account with Balance = account.Balance - amount }

