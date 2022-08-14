type TransactionTypes = Deposit | Withdrawal 
type Transaction = { Year:int; Amount:float; Type: TransactionTypes }
let transactions = [ 
    {Year=2021; Amount=100; Type=Deposit }
    {Year=2022; Amount=50; Type=Deposit } 
    {Year=2022; Amount=25; Type=Withdrawal} ]

//================================================================================

let printTransaction transaction = printfn "%A" transaction
List.iter printTransaction transactions

//================================================================================

List.iter (fun transaction -> printfn "%A" transaction) transactions

//================================================================================

transactions |> List.map printTransaction

//================================================================================

List.filter (fun transaction -> transaction.Year = 2022) transactions

//================================================================================

let transactionInYear year transaction = transaction.Year = year
List.filter (transactionInYear 2022) transactions
transactions |> List.filter (transactionInYear 2022)

//================================================================================

let getTransactionYear transaction = transaction.Year
let getTransactionAmount transaction = transaction.Amount
let getTransactionType transaction = transaction.Type
transactions |> List.map getTransactionAmount
transactions |> List.map getTransactionYear
transactions |> List.map getTransactionType

//================================================================================

transactions |> List.groupBy getTransactionYear

//================================================================================

transactions |> List.map getTransactionAmount 
transactions |> List.map getTransactionAmount |> List.sum

//================================================================================

let adjustAmountForType transaction=
    match transaction.Type with
    | Withdrawal -> -transaction.Amount
    | Deposit -> transaction.Amount

transactions
    |> List.map adjustAmountForType
    |> List.sum

//================================================================================

let netOfTransactions transactions = 
    transactions
        |> List.map adjustAmountForType
        |> List.sum

transactions
    |> List.groupBy getTransactionYear
    |> List.map (fun (year, transactionsForYear) -> 
        (year, transactionsForYear |> netOfTransactions))

