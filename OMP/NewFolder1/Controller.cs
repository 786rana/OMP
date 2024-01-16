namespace OMP.NewFolder1
{
    public class SellerService
    {
        private List<Seller> sellers = new List<Seller>
    {
        new Seller { Id = 1, Name = "Seller 1" },
        new Seller { Id = 2, Name = "Seller 2" },
        // Add more sellers
    };

        public List<Seller> GetAllSellers()
        {
            return sellers;
        }

        public Seller GetSellerById(int sellerId)
        {
            return sellers.FirstOrDefault(s => s.Id == sellerId);
        }

        public void AddSeller(Seller seller)
        {
            seller.Id = sellers.Count + 1; // Simulate auto-increment ID
            sellers.Add(seller);
        }

        public void UpdateSeller(Seller updatedSeller)
        {
            var existingSeller = sellers.FirstOrDefault(s => s.Id == updatedSeller.Id);

            if (existingSeller != null)
            {
                existingSeller.Name = updatedSeller.Name;
                // Update other properties as needed
            }
        }

        public void DeleteSeller(int sellerId)
        {
            var existingSeller = sellers.FirstOrDefault(s => s.Id == sellerId);

            if (existingSeller != null)
            {
                sellers.Remove(existingSeller);
            }
        }
    }


}
