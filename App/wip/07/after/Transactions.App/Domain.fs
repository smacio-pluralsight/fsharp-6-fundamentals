module Transactions.Domain

type TransactionType = Deposit | Withdraw
type Transaction = {
    Id: int
    Type: TransactionType
    Amount: decimal
}

type Account = {
    Id: int
    Balance: decimal
    Transactions: Transaction list
}
