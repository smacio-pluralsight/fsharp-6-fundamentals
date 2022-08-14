module Transaction.Processor.Api

open Transaction.Processor.Domain

open Transaction.Processor.CompositionRoot
open Transaction.Processor
open Transaction.Processor.Operations.Accounts.Commands
open Transaction.Processor.Operations.Accounts.Processors
open Transaction.Processor.Util.JsonSerialization

let (>>=) result func = Result.bind func result

let private validateAccountId (accountId, amount) =
    match accountId >=0 with
    | true -> Ok (accountId, amount)
    | false -> Error "Account id must be >=0"

let private validateAmount (accountId, amount) =
    match amount >= 0m with
    | true -> Ok (accountId, amount)
    | false -> Error "Account id must be >=0"

let private executeDepositWithResult (accountId, amount) =
    execute (Deposit (accountId, amount)) 

let private executeWithdrawWithResult (accountId, amount) =
    execute (Withdraw (accountId, amount))

let create () =
    Repository.Account.create()

let exists accountId =
    Repository.Account.exists accountId

let get (accountId:int) =
    Repository.Account.get accountId 

let withdraw accountId amount =
    (Ok (accountId, amount) )
        >>= validateAccountId 
        >>= validateAmount
        >>= executeWithdrawWithResult 

let deposit accountId amount =
    (Ok (accountId, amount) )
        >>= validateAccountId 
        >>= validateAmount
        >>= executeDepositWithResult 
