namespace TrainingGround.Tests;

public class AgeCalculatorTests
{
    public AgeCalculatorTests()
    {
        _calculator = new AgeCalculator();
    }
    private AgeCalculator _calculator;
    [Fact]
    public void someone_born_1972_is_50_in_2022()
    {
        var p = new Person();
        p.BirthYear = 1972;

        // act
        var age = p.GetAge(2022);

        // assert
        Assert.Equal(50, age);

    }
}