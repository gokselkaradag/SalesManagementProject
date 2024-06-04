using SalesManagementProject.Models;

namespace SalesManagementProject.Repositories
{
    public class SalesRepository : ISalesRepository
    {
        private List<Sale> project = new List<Sale>();

        public void AddOffer(Sale sale)
        {
            project.Add(sale);
        }

        public List<Sale> GetAllSales()
        {
            return project;
        }

        public Sale GetSaleByListingNumber (int listingNumber)
        {
            return project.FirstOrDefault(s => s.ListingNumber == listingNumber);
        }

        public void UpdateOffer(Sale sale)
        {
            var currentsales = GetSaleByListingNumber(sale.ListingNumber);
            if (currentsales != null)
            {
                currentsales.OfferTittle = sale.OfferTittle;
                currentsales.Name = sale.Name;
                currentsales.Price = sale.Price;
                
            }
        }

        public void DeleteOffer(Sale sale)
        {
            project.Remove(sale);
        }
    }
}
