using RealProgram.src;
using System;
using Xunit;
using NSubstitute;
using FluentAssertions;

namespace RealProgram.test
{
    public class ProgramTest
    {
        private readonly Program _sut;

        public ProgramTest()
        {
            _sut = new Program();
        }

        //[Fact]
        //public void Main_ShouldWriteHelloWorld_WhenCalled()
        //{
        //    // Arrange
        //    var console = Substitute.For<IConsole>();
        //    _sut.Console = console;

        //    // Act
        //    _sut.Main(new string[] { });

        //    // Assert
        //    console.Received().WriteLine("Hello, World!");
        //}


    }
}
