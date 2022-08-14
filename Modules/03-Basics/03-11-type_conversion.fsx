float "1.23"

int "1"

string 1.23

float 1

//================================================================================

// note: the following does not work outside a web project
let mapResult (x:ControllerBase) result =
    match result with
    | Ok data -> x.Ok(data) :> IActionResult // otherwise OkObjectResult
    | Error msg -> x.Problem(msg) :> IActionResult // otherwise ObjectResult

