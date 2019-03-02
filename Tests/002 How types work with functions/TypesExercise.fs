module TypesExercise

let testA   = float 2                       // val testA : float = 2.0
let testB x = float 2                       // val testB : (x:'a -> float)
let testC x = float 2 + x                   // val testC : (x:float -> float)
let testD x = x.ToString().Length           // val testD : (x:'a -> int)
let testE (x:float) = x.ToString().Length   // val testE : (x:float -> int)
let testF x = printfn "%s" x                // val testF : (x:string -> unit)
let testG x = printfn "%f" x                // val testG : (x:float -> unit)
let testH   = 2 * 2 |> ignore               // val testH : unit = () 
let testI x = 2 * 2 |> ignore               // val testI : (x:'a -> unit)
let testJ (x:int) = 2 * 2 |> ignore         // val testJ : (x:int -> unit)
let testK   = "hello"                       // val testK : string = "hello"
let testL() = "hello"                       // val testL : (unit -> string)
let testM x = x = x                         // val testM : (x:'a -> bool)
let testN x = x 1                           // val testN : (x:(int -> 'a) -> 'a)
let testO x:string = x 1                    // val testO : (x:(int -> string) -> string)