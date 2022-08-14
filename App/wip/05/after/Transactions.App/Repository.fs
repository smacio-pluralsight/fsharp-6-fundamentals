module Transactions.Repository

open Transactions.Domain

module Account =
    let mutable private account = { Balance = 0.0m }

    let get () = account
    let put accountToPut = account <- accountToPut
