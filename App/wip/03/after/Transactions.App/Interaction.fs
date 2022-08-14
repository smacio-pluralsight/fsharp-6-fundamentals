module Transactions.Interaction

open System

let private getAction () = 
    Console.Write "(d)eposit, (w)ithdraw or e(x)it: "
    Console.ReadLine()

let private getAmount () = 
    Console.Write "Amount: "
    Console.ReadLine() |> Decimal.Parse

let mainLoop () =
    printfn "Hello from the transaction processor"

    let mutable balance = 0.0m

    let mutable running = true
    while running do
        printfn "Current balance: %A" balance

        let action = getAction()    

        balance <- 
            if action = "d" || action = "w" then
                let amount = getAmount()
                if action = "d" then balance + amount
                else balance - amount
            else balance

        running <- action <> "x"