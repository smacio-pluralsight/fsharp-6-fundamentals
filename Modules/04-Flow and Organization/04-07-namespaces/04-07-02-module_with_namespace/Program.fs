module Finance.Repository.Json 

let put transaction =
    printfn "Save the transaction"

// same as

namespace Finance.Repository
module Json = 
    let put transaction =
        printfn "Save the transaction"
