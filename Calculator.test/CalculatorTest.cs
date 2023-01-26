using Calculatoor.app;
using Newtonsoft.Json.Linq;
using Xunit;
namespace Calculator.test;

 public class CalculatorTest
 {
     [Fact]
     
     public void Sum_SendEmpty_ReceiveZero()
     {

         var calculator = new CalculatorSystem();


         var result = calculator.Sum("");


         Assert.Equal(0, result);



     }

    [Theory]

   [InlineData("1,2", 3)]
   [InlineData("5,5", 10)]
   [InlineData("3,4", 7)]
   [InlineData("-1,4;5;6|7", 21)]



    public void Sum_SendValuesSeparatedByComma_ReturnSumOfValues(string values, int SumOfValues)
    {
        //arrange

        var calculator = new CalculatorSystem();

        //act
        var result = calculator.Sum(values);

        //assert
        Assert.Equal(SumOfValues, result);

    }
    [Theory]

    [InlineData("-1")]
    [InlineData("-3")]
    [InlineData("-4")]
    [InlineData("-5")]
    [InlineData("-6")]




    public void Sum_Numernegativo_Exeption(string numerosNegativos)
    {
        //arrange
        var calculator = new CalculatorSystem();

        //act
        

        //assert
        Assert.Throws<Exception>(() => calculator.NumerosNegativos( numerosNegativos));

    }

    [Theory]

    [InlineData("100")]

    public void Sum_NumerosMayorACien(string NumerosMayorACien)
    {

        var calculator = new CalculatorSystem();

        //act


        //assert

        Assert.Throws<Exception>(() => calculator.NumerosMayorACien(NumerosMayorACien));



    }
   

}
