module Transactions.Repository

open Transactions.Domain

module Account =
    let mutable private accounts = [|{ Id = 0; Balance = 0.0m }|]

    let get accountId = accounts[int accountId]
    let put account = accounts[account.Id] <- account
