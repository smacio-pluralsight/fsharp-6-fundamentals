open System

open Transaction.Processor.Api

[<EntryPoint>]
let main argv = 
    let accountId = create ()
    deposit accountId 100m |> ignore
    withdraw accountId 50m |> ignore
    printfn "%A" (get accountId)
    0