open System

let rec check number =
    if number < 0 then
        check (abs number)  
    elif number < 10 then  
        number % 2 = 0      
    else check (number / 10)  

[<EntryPoint>]
let main args = 
    printfn "Введите число:"
    let number = int(Console.ReadLine())
    printfn "Результат: %A" (check number)
    0
