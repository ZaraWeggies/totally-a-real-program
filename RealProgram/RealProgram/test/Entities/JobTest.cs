using RealProgram.src.Entities;
using Xunit;

namespace RealProgram.test.Entities
{
    public class JobTest
    {
        private readonly Job _sut;

        public JobTest()
        {
            _sut = new Job();
        }

        [Fact]
        public void IsWellPaid_ShouldReturnTrue_WhenSalaryIsGreaterThan100000()
        {
            // Arrange
            _sut.Salary = 100001;

            // Act
            var result = _sut.IsWellPaid();

            // Assert
            Assert.True(result);
        }

        [Fact]
        public void IsWellPaid_ShouldReturnFalse_WhenSalaryIsLessThan100000()
        {
            // Arrange
            _sut.Salary = 99999;

            // Act
            var result = _sut.IsWellPaid();

            // Assert
            Assert.False(result);
        }

        [Fact]
        public void IsSenior_ShouldReturnTrue_WhenYearsExperienceIsGreaterThan10()
        {
            // Arrange
            _sut.YearsExperience = 11;

            // Act
            var result = _sut.IsSenior();

            // Assert
            Assert.True(result);
        }

        [Fact]
        public void IsSenior_ShouldReturnFalse_WhenYearsExperienceIsLessThan10()
        {
            // Arrange
            _sut.YearsExperience = 9;

            // Act
            var result = _sut.IsSenior();

            // Assert
            Assert.False(result);
        }

        [Fact]
        public void IsRemote_ShouldReturnTrue_WhenLocationIsRemote()
        {
            // Arrange
            _sut.Location = "Remote";

            // Act
            var result = _sut.IsRemote();

            // Assert
            Assert.True(result);
        }

        [Fact]
        public void IsRemote_ShouldReturnFalse_WhenLocationIsNotRemote()
        {
            // Arrange
            _sut.Location = "Corporate";

            // Act
            var result = _sut.IsRemote();

            // Assert
            Assert.False(result);
        }
    }
}
