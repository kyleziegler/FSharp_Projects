//Kyle Ziegler 2018
//F# functional programming practice.

open System


//Find the last element in a given list.
module Lists =
    let rec lastListElement list=
        match list with
        | [] -> failwith "List empty"
        | [item] -> item //When we only have one item in the list, return it.
        | _::remainingList -> lastListElement remainingList //call the function with the remaining list 

    //Print the integer result
    let run = lastListElement [1;2;3;]
    printfn "Result = %i" run

