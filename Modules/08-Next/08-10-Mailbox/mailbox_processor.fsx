type Message = Set of float | Get of AsyncReplyChannel<float> | Half | Small | Large 
let item1 = MailboxProcessor<Message>.Start(fun inbox ->
    let rec loop state = async {
        printfn "State is: %A" state
        let! msg = inbox.Receive()
        match msg with
        | Set v -> do! loop v
        | Get replyChannel -> 
            replyChannel.Reply state
            do! loop state
        | Half -> do! loop (state / 2.0)
        | Small -> do! loop (state - 1.0)
        | Large -> do! loop (state - 10.0)
    }
    loop 0.0)

item1.Post(Set 100.0)
item1.Post(Half)
item1.Post(Small)
item1.Post(Large)

item1.PostAndReply(Get)


