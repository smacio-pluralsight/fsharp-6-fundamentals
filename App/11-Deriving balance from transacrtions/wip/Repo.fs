module Transactions.Repository

open Transactions.Domain

open System.IO

module Account =
    open Transactions.Utils.Json.Serialization

    let private getAccountFileName accountId =
        $"account_{accountId}.json"

    let private getAccountData accountId =
        getAccountFileName accountId |> File.ReadAllText

    let private buildAccount json : Account=
        json |> deserialize

    let private save account =
        (getAccountFileName account.Id, serialize account)
        |> File.WriteAllText

    let get (accountId:int) : Account =
        accountId |> getAccountData |> buildAccount

    let put account =
        account |> save
        account
