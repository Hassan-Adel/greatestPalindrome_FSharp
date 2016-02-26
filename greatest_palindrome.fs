//Name: Hassan Mohammad Adel
//ID: 20120154

let isPal num : bool = 
    let str = num.ToString()
    str |> Seq.toList = ((str |> Seq.toList) |> List.rev)

let getGreatestPal() : int =
    let mutable maxPal = 0
    let mutable first = 0
    let mutable second = 0
    for i = 999 downto 100 do
        for j = 999 downto 100 do
            if (isPal (i * j) && ((i * j) > maxPal)) then
                maxPal <- (i * j)
                first <- i
                second <- j
    
    printfn "%d %d" first second
    maxPal     

[<EntryPoint>]

let main argv =

    System.Console.WriteLine(getGreatestPal())

    System.Console.ReadKey() |> ignore
    0 // return an integer exit code