open Finance.Domain

let transaction = Finance.Domain.createTransaction 0 100.0
let account = Finance.Domain.createAccount 1 [transaction]

printfn "%A" account
