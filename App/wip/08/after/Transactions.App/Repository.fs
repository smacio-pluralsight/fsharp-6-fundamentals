module Transactions.Repository

open System.IO
open System.Text.Json
open Transactions.Domain

module Account =
    open System.Text.Json.Serialization

    let private jsonOptions =
        let options = JsonSerializerOptions()
        options.Converters.Add(JsonFSharpConverter())
        options

    let get accountId = 

        let getNextAccountId () =     
            let extractAccountId (filename:string) =
                let part1 = filename.Split('_')[1]
                let part2 = part1.Split('.')[0]
                int (part2)

            match Directory.GetFiles(".", "account_*.json") with
            | [||] -> 0
            | _ as files -> files |> Array.map extractAccountId |> Array.max |> (+) 1
        
        let fileName = $"account_{accountId}.json"
        match File.Exists(fileName) with
        | false -> newAccount (getNextAccountId())
        | true ->  JsonSerializer.Deserialize<Account>(File.ReadAllText $"account_{accountId}.json", jsonOptions) 

    let put account = 
        File.WriteAllText($"account_{account.Id}.json", JsonSerializer.Serialize( account, jsonOptions ))
