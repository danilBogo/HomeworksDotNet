module Homework4.Calculator

open System
open Homework4

let calculate value1 operation value2 =
    let value1d = value1 |> double
    let value2d = value2 |> double
    if value2d = 0 && operation = CalculatorOperation.Divide then
        DivideByZeroException() |> raise
    match operation with
    | CalculatorOperation.Plus -> value1d + value2d
    | CalculatorOperation.Minus -> value1d - value2d
    | CalculatorOperation.Multiply -> value1d  * value2d
    | CalculatorOperation.Divide -> value1d / value2d
