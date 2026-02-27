open System

let check number = 
    [
        for i in 1.. number do
            printf "введите число: "
            let number = int(Console.ReadLine())
            if number = 0
            then yield 0
            else yield number / 2
    ]

[<EntryPoint>]
let main args = 
    printfn "введите кол-во чисел для списка"
    let number = int(Console.ReadLine())
    printfn "список:  %A" (check number)
    0