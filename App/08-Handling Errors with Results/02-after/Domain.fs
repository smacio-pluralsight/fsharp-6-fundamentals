module Transactions.Domain

type Account = {
    Id: int
    Balance: decimal
}
with static member New id balance transactions = 
        { Id = id; Balance = balance; Transactions = transactions }
     static member Default = Account.New 0 0m []
