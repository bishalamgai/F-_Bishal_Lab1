// For more information see https://aka.ms/fsharp-console-apps
printfn "Hello! I'm Bishal Amgai."
let rec factorial number accumalotor =
    if number = 0 then
        accumalotor
    else
        factorial (number - 1) (accumalotor * number)

let result = factorial 7 1
printfn "Factorial of 7 is: %d" result

