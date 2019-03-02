// Mega Hello World
//
// Take two command-line parameters and then print
// them along with the current time to the console.

open System

[<EntryPoint>]
let main (argv : string[]) = 
    if argv.Length <> 2 then
        failwith "Error : Expected arguments <greeting> and <thing>"
    
    let greeting, thing = argv.[0], argv.[1]
    let timeOfDay = DateTime.Now.ToString("hh:mm tt")

    printfn "%s, %s at %s" greeting thing timeOfDay

    //Program exit code
    0