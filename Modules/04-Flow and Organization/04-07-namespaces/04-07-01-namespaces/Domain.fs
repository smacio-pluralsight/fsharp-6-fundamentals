namespace Finance
// can't put other bindings here
// let a = 1 // works in a module but not a namespace

// a type in the namespace is fine
type Transaction = { Id:int; Amount:float}

module Operations =
    let createTransaction id amount = { Id = id; Amount = amount }

