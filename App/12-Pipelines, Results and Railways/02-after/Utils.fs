module Transactions.Utils

module Railway =
    let (>>=) result func = Result.bind func result
    let (>>>) result func = Result.map func result

module Json =
    module Serialization =
        open System.Text.Json
        open System.Text.Json.Serialization

        let private jsonOptions () =
            let options = JsonSerializerOptions()
            options.Converters.Add(JsonFSharpConverter())
            options

        let serialize object = 
            JsonSerializer.Serialize( object, jsonOptions() )

        let deserialize (json:string) : 'a=
            JsonSerializer.Deserialize<'a> (json, jsonOptions())