module Transactions.Domain

type TransactionType = Deposit | Withdraw
type Transaction = {
    Id: int
    Type: TransactionType
    Amount: decimal
}

let newTransaction id transactionType amount = { Id = id; Type = transactionType; Amount = amount }
let newDeposit id amount = { Id = id; Type = Deposit; Amount = amount }
let newWithdraw id amount = { Id = id; Type = Withdraw; Amount = amount }

type Account = {
    Id: int
    Balance: decimal
    Transactions: Transaction list
}
 
let newAccount id = { Id = id; Balance = 0m; Transactions = [] }