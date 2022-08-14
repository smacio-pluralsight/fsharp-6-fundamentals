open Finance.Domain

let transactions = [ 
    { Id = 0; Amount = 100.0 } 
    { Id = 1; Amount = -50.0 } 
]

let account = {
    Id = 0 
    Transactions = transactions
}