
namespace prueba2_jose1
{
    public class inventory
    {
        #region variables
        public string Name { get; set; }
        public double Price{ get; set; }
        public int Amount { get; set; }
        public string Category { get; set; }
        public string Storage { get; set; }
        public int MinAmount { get; set; }
        public int MaxAmount { get; set; }
        #endregion

        #region Builder
        public inventory() { }
        public inventory(string name, double price, int amount, string category, string storage, int minAmount, int maxAmount)
        {
            Name = name;
            Price = price;
            Amount= amount;
            Category= category;
            Storage= storage;
            MinAmount= minAmount;
            MaxAmount= maxAmount;
           
        }
        #endregion

    }
}
