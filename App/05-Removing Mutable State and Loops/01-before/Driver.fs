module Transactions.Driver

open System

module UserConsole =
    let private promptuser () =
        Console.Write("(d)eposit, (w)ithdraw or e(x)it: ")
        Console.ReadLine()

    let private getAmount () =
        Console.Write("Enter the amount of the transaction: ")
        Console.ReadLine() |> Decimal.Parse

    let run () =
        let rec loop balance =
            printfn "Balance: %A" balance

            let action = promptuser()
            printfn "You told me to do this: %A" action

            match action with
            | "d" -> loop (balance + getAmount())
            | "w" -> loop (balance - getAmount())
            | "x" -> ()
            | _ ->
                printfn $"Invalid action: {action}"
                loop balance

        loop 0m
        ()