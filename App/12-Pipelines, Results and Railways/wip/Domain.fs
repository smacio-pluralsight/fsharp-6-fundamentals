module Transactions.Domain

type TransactionType = Deposit | Withdraw
type Transaction = {
    Id: int
    Type: TransactionType
    Amount: decimal
}
with static member New id transactionType amount =
        { Id = id; Type = transactionType; Amount = amount }
     static member NewDeposit id amount = Transaction.New id Deposit amount
     static member NewWithdraw id amount = Transaction.New id Withdraw amount

type Account = {
    Id: int
    Balance: decimal
    Transactions: Transaction list
}
with static member Default = Account.New 0 0m []
     static member New id balance transactions = 
        { Id = id; Balance = balance; Transactions = transactions }
     static member NewId id = Account.New id 0m []

