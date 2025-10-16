using App.Core;
namespace App.Tests;

public class UnitTest1
{
    private Caladora _calc = null!;//null! para evitar aviso de null


    [SetUp]//Executado antes de cada teste
    public void Setup()//Arrange
    {
        _calc = new Caladora();
    }


    [Test]//Teste simples
    public void Test1()//Arrange
    {
        Assert.Pass();
    }

    //------------------------------------------------------------------------------

    //Sum com varios cenarios 
    //Arrange
    [TestCase(1, 1, 2)]//caso normal
    [TestCase(-2, 2, 0)]//caso negativo
    [TestCase(10, -3, 7)]//caso negativo
    public void Sum_VariosCenarios(int a, int b, int esperado)//Act
    {
        var calc = new Caladora();//Arrange
        var result = calc.soma(a, b);//Act
        Assert.That(result, Is.EqualTo(esperado));//Assert
    }

    //------------------------------------------------------------------------------

    //Subt com varios cenarios
    //Arrange
    [TestCase(1, 1, 0)]//caso normal
    [TestCase(-2, 2, -4)]//caso negativo
    [TestCase(10, -3, 13)]//caso negativo
    public void Subt_VariosCenarios(int a, int b, int esperado)//Act
    {
        var calc = new Caladora();//Arrange
        var result = calc.subt(a, b);//Act
        Assert.That(result, Is.EqualTo(esperado));//Assert
    }

    //------------------------------------------------------------------------------

    //Mult com varios cenarios
    //Arrange
    [TestCase(1, 1, 1)]//caso normal 
    [TestCase(-2, 2, -4)]//caso negativo
    [TestCase(10, -3, -30)]//caso negativo
    [TestCase(10, 0, 0)]//caso multiplicador zero
    public void Mult_VariosCenarios(int a, int b, int esperado)//Act
    {
        var calc = new Caladora();//Arrange
        var result = calc.mult(a, b);//Act
        Assert.That(result, Is.EqualTo(esperado));//Assert
    }

    //------------------------------------------------------------------------------

    //Div com varios cenarios
    //Arrange
    [TestCase(1, 1, 1)]//caso normal
    [TestCase(-2, 2, -1)]//caso negativo
    [TestCase(-33, 10, -1.0 * (33.0 / 10.0))]//caso negativo 
    [TestCase(10, 0, -1)]//caso divisor zero

    public void Div_VariosCenarios(int a, int b, double esperado)//Act
    {
        var calc = new Caladora();//Arrange
        var result = calc.div(a, b);//Act
        Assert.That(result, Is.EqualTo(esperado));//Assert
    }

    //------------------------------------------------------------------------------

    //Raiz com varios cenarios
    //Arrange
    [TestCase(4, 2)]//caso normal
    [TestCase(9, 3)]//caso normal   
    [TestCase(0, 0)]//caso zero
    [TestCase(-4, -1)]//caso negativo

    public void Raiz_VariosCenarios(int a, int esperado)//Act
    {
        var calc = new Caladora();//Arrange
        var result = calc.raiz(a);//Act
        Assert.That(result, Is.EqualTo(esperado));//Assert
    }

    //------------------------------------------------------------------------------

    //IsPrime com varios cenarios
    //Arrange
    [TestCase(1, false)]//caso 1
    [TestCase(2, true)]//caso 2 
    [TestCase(10, false)]//caso não primo
    [TestCase(1999, true)]//caso primo grande
    [TestCase(2000, false)]//caso não primo grande
    public void IsPrime_VariosCenarios(int a, bool esperado)//Act
    {
        var calc = new Caladora();//Arrange
        var result = calc.IsPrime(a);//Act
        Assert.That(result, Is.EqualTo(esperado));//Assert
    }
}


