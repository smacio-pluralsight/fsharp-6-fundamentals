module Transaction.Processor.Repository
open Transaction.Processor.Util.JsonSerialization

open System.IO
open Transaction.Processor.Domain

module Account =
    let (>>=) result func = Result.bind func result

    let private getAccountFileName (accountId:int) =
        $"account_{accountId}.json"

    let private getNextAccountId () =     
        let extractAccountId (filename:string) =
            let part1 = filename.Split('_')[1]
            let part2 = part1.Split('.')[0]
            int (part2)

        match Directory.GetFiles(".", "account_*.json") with
        | [||] -> 0
        | _ as files -> files |> Array.map extractAccountId |> Array.max |> (+) 1

    let exists accountId =
        File.Exists(getAccountFileName accountId)

    let private save account =
        File.WriteAllText(getAccountFileName account.Id, serializeAccount account)
        account

    let private getAccountData (accountId:int) =
        match exists accountId with
        | true -> Ok (File.ReadAllText (getAccountFileName accountId))
        | false -> Error $"Account file not found: {accountId}"

    let private buildAccount json =
        Ok (deserializeAccount json)

    let create () =
        let account = newAccount (getNextAccountId())
        (account |> save).Id

    let get accountId =         
        match exists accountId with
        | false -> Error $"Account not found: {accountId}"
        | true ->  accountId |> getAccountData >>= buildAccount 

    let put account = 
        try
            Ok (save account)
        with e -> Error e.Message