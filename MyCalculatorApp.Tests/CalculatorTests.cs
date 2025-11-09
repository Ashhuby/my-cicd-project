using MyCalculatorApp;

namespace MyCalculatorApp.Tests;

public class CalculatorTests
{
    [Fact] // This attribute means this method is a testdotnet
    public void Test_Add_Returns_Correct_Sum()
    {
        // ARRANGE - Set up the test
        var calculator = new Calculator();
        int a = 5;
        int b = 10;
        
        // ACT - Run the code to be tested
        var result = calculator.Add(a, b);

        // ASSERT - Check if the result is correct
        Assert.Equal(15, result);
    }

    [Fact]
    public void Test_Subtract_Returns_Correct_Difference()
    {
        // Arrange
        var calculator = new Calculator();
        int a = 20;
        int b = 8;
        
        // Act
        var result = calculator.Subtract(a, b);

        // Assert
        Assert.Equal(12, result);
    }
}