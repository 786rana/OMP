namespace OMP.Data
{        public class SellerService
        {
            private List<Seller> sellers = new List<Seller>
    {
        new Seller { Id = 1, Name = "Seller 1" },
        new Seller { Id = 2, Name = "Seller 2" },
        // Add more sellers
    };

            private List<Product> products = new List<Product>
    {
        new Product { Id = 1, Name = "Product 1", Price = 99.99m, SellerId = 1 },
        new Product { Id = 2, Name = "Product 2", Price = 49.99m, SellerId = 2 },
        // Add more products
    };

            public Seller GetSellerById(int sellerId)
            {
                return sellers.FirstOrDefault(s => s.Id == sellerId);
            }

            public List<Product> GetProductsForSeller(int sellerId)
            {
                return products.Where(p => p.SellerId == sellerId).ToList();
            }
        }
    }
}
