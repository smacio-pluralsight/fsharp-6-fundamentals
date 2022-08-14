open Finance
let explicitTransactionCreate = { Id = 0; Amount = 5.0 }
printfn "%A" explicitTransactionCreate
let transaction = Operations.createTransaction 1 100.0
printfn "%A" transaction
