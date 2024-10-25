public class PersonTests
{
    [Fact]
    public void create_person_using_parameterless_constructor()
    {
    // act
    var p = new Person("Marcus");

    // assert
    Assert.NotNull(p);
    Assert.Equal("Marcus", p.Name);
    }
}