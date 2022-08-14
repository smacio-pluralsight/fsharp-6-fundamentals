namespace Finance

module Transaction =
    type T = { Id: int; Amount: float}

    let create id amount = { Id = id; Amount = amount }