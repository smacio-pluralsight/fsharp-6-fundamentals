module Transactions.Domain

type Account = {
    Id: int
    Balance: decimal
}
with static member New id balance = { Id = id; Balance = balance }
     static member Default = Account.New 0 0m
