namespace Pricer.Domain.Entities
{
    public class VariableCost
    {
        public string MaterialType { get; set; }
        public decimal Amount { get; set; }

        public VariableCost()
        {
            
        }
        public VariableCost(string materialType, decimal amount)
        {
            MaterialType = materialType;
            Amount = amount;
        }
    }
}