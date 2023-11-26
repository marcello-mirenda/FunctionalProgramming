// For more information see https://aka.ms/fsharp-console-apps

let l = [1;2;3]
let add1 = (+) 1

let x = List.map add1
let res = x l


printfn "%A" res
