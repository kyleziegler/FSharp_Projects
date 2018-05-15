//Kyle Ziegler 2018
//F# functional programming practice.
//Problems solved from https://wiki.haskell.org/99_questions/1_to_10

open System

//All list problems
module Lists =
    //Return the last element in a list
    let rec lastListElement list=
        match list with
        | [] -> failwith "List empty"
        | [last] -> last //When we only have one item in the list, return it.
        | _::remainingList -> lastListElement remainingList //call the function with the remaining list 

    let test1 = lastListElement [1 .. 100]
    printfn "Result = %i" test1

    //Return the second to last element in a list
    //Fail on empty sets and single element sets
    let rec secondToLast list = 
        match list with
        | [] -> failwith "Empty list"
        | [a] -> failwith "Only one element in the list"
        | [e;_] -> e //found the right one
        | _::remainingList -> secondToLast remainingList

    let test2 = secondToLast [1 .. 100]
    printfn "Result = %i" test2

    //Count the elements in a list
    let rec numElements list sum = 
        match list with 
        | [] -> sum
        | _::restOfList -> numElements restOfList (sum+1)

    let test3 = numElements [1 .. 100] 0
    printfn "Result = %i" test3

    let flattenList l = List.concat l

    //Replace a list of lists with a singular flat list.
    //let rec flattenList l acc= 
        //match (l,acc) with
        //| ([],[]) -> failwith "List empty"
        //| ([],acc) -> acc
        //| (x::xs, acc) -> flattenList xs List.append(x,acc)

    
    let test4 = flattenList [[1;2;3];[4;5;6];[7;8;9]]
    test4 |> List.iter (fun x -> printf "%d " x)

