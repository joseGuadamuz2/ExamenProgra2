namespace prueba2_jose1
{
    public class inventory
    {
        #region Variables

        // Property to store the name of the item
        public string Name { get; set; }

        // Property to store the price of the item
        public double Price { get; set; }

        // Property to store the amount of the item in stock
        public int Amount { get; set; }

        // Property to store the category of the item
        public string Category { get; set; }

        // Property to store the name of the storage where the item is located
        public string Storage { get; set; }

        // Property to store the minimum amount allowed in stock
        public int MinAmount { get; set; }

        // Property to store the maximum amount allowed in stock
        public int MaxAmount { get; set; }

        #endregion

        #region Constructor

        // Default constructor
        public inventory() { }

        /// <summary>
        /// Constructor that initializes an inventory item with specified properties.
        /// </summary>
        /// <param name="name">Name of the item</param>
        /// <param name="price">Price of the item</param>
        /// <param name="amount">Amount of the item in stock</param>
        /// <param name="category">Category of the item</param>
        /// <param name="storage">Storage location of the item</param>
        /// <param name="minAmount">Minimum stock amount</param>
        /// <param name="maxAmount">Maximum stock amount</param>
        public inventory(string name, double price, int amount, string category, string storage, int minAmount, int maxAmount)
        {
            Name = name;
            Price = price;
            Amount = amount;
            Category = category;
            Storage = storage;
            MinAmount = minAmount;
            MaxAmount = maxAmount;
        }

        #endregion
    }
}

