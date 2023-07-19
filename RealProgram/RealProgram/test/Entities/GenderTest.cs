using RealProgram.src.Entities;
using Xunit;

namespace RealProgram.test.Entities
{
    public class GenderTest
    {
        private readonly Gender _sut;

        public GenderTest()
        {
            _sut = new Gender();
        }

        [Fact]
        public void Pronoun_ShouldBeSet_WhenSet()
        {
            //Arrange
            var expected = "She/Her";

            //Act
            _sut.Pronoun = expected;

            //Assert
            Assert.Equal(expected, _sut.Pronoun);
        }
    }
}
