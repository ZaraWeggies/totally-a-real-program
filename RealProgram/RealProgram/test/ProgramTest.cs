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
    }
}
