[<RequireQualifiedAccess>]
module Finance
[<RequireQualifiedAccess>]
module Domain =
    type Transaction = { 
        Id: int
        Amount: float
    }
    type Account = { 
        Id: int
        Transactions: Transaction list
    }
 
    // indentation here is important 
    let createTransaction id amount=
        { Id = id; Amount = amount }
    let createAccount id transactions = 
        { Id = id; Transactions = transactions }
