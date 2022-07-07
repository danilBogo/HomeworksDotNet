module Tests.Tests

open System
open Homework4
open Xunit
        
[<Theory>]
[<InlineData(15, 5, CalculatorOperation.Plus, 20)>]
[<InlineData(15, 5, CalculatorOperation.Minus, 10)>]
[<InlineData(15, 5, CalculatorOperation.Multiply, 75)>]
[<InlineData(15, 5, CalculatorOperation.Divide, 3)>]
let ``TestAllOperations`` (value1, value2, operation, expectedValue) =
    let result = Calculator.calculate value1 operation value2
    Assert.Equal(expectedValue, result)
    
[<Fact>]
let ``TestDividingByZero`` () =
    Assert.Throws<DivideByZeroException>(fun _ -> Calculator.calculate 15 CalculatorOperation.Divide 0 |> ignore) 
