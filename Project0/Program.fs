//Kyle Ziegler 2018
//F# functional programming practice.

open System

//Find the last element in a given list.
module Lists =
    let rec lastListElement list=
        match list with
        | [] -> failwith "List empty"
        | [last] -> last //When we only have one item in the list, return it.
        | _::remainingList -> lastListElement remainingList //call the function with the remaining list 

    //Print the integer result
    let test1 = lastListElement [1 .. 100]
    printfn "Result = %i" test1

    let rec secondToLast list = 
        match list with
        | [] -> failwith "Empty list"
        | [a] -> failwith "Only one element in the list"
        | [e;_] -> e //found the right one
        | _::remainingList -> secondToLast remainingList

    let test2 = secondToLast [1 .. 100]
    printfn "Result = %i" test2

    let rec numElements list sum = 
        match list with 
        | [] -> sum
        | _::restOfList -> numElements restOfList (sum+1)

    let test3 = numElements [1 .. 100] 0
    printfn "Result = %i" test3