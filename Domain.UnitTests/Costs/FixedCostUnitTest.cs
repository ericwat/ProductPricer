using System;
using Pricer.Domain.Entities;
using Xunit;

namespace Pricer.Domain.UnitTests.Costs
{
    public class FixedCostUnitTest
    {
        private readonly FixedCost _sut;

        public FixedCostUnitTest()
        {
            _sut = new FixedCost();
        }

        [Theory]
        [InlineData("Startup", 3000.0, "Startup", 3000.0)]
        [InlineData("Marketing", 100.0, "Marketing", 100.0)]
        public void SetMustContainSpecifiedAmountAndTypeTheory(string expectedType,
            decimal expectedAmount,
            string materialType,
            decimal amount)
        {
            _sut.AdminType = materialType;
            _sut.Amount = amount;
            Assert.Equal(expectedType, _sut.AdminType);
            Assert.Equal(expectedAmount, _sut.Amount);
        }
    }
}