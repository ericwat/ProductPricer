using Pricer.Domain.Entities;
using Xunit;

namespace Pricer.Domain.UnitTests.Costs
{
    public class VariableCostUnitTest
    {
        private readonly VariableCost _sut;

        public VariableCostUnitTest()
        {
            _sut = new VariableCost();
        }

        [Theory]
        [InlineData("Vinyl", 5.0, "Vinyl", 5.0)]
        [InlineData("Packaging", 0.10, "Packaging", 0.10)]
        public void SetMustContainSpecifiedAmountAndTypeTheory(string expectedType,
            decimal expectedAmount, 
            string materialType,    
            decimal amount)
        {
            _sut.MaterialType = materialType;
            _sut.Amount = amount;
            Assert.Equal(expectedType, _sut.MaterialType);
            Assert.Equal(expectedAmount, _sut.Amount);
        }
    }
}