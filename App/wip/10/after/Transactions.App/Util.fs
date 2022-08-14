module Transaction.Processor.Util

module JsonSerialization =
    open System.Text.Json.Serialization
    open System.Text.Json
    open Transaction.Processor.Domain

    let private jsonOptions =
        let options = JsonSerializerOptions()
        options.Converters.Add(JsonFSharpConverter())
        options

    let serializeAccount account = 
        JsonSerializer.Serialize( account, jsonOptions )

    let deserializeAccount (json:string) =
        JsonSerializer.Deserialize<Account> (json, jsonOptions)