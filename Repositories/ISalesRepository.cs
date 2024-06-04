using SalesManagementProject.Models;

namespace SalesManagementProject.Repositories
{
    public interface ISalesRepository
    {
        void AddOffer(Sale sale);
        List<Sale> GetAllSales();
        Sale GetSaleByListingNumber(int listingNumber);
        void UpdateOffer(Sale sale);
        void DeleteOffer(Sale sale);
    }
}
