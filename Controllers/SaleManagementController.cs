using Microsoft.AspNetCore.Mvc;
using SalesManagementProject.Models;
using SalesManagementProject.Repositories;

namespace SalesManagementProject.Controllers
{
    public class SaleManagementController : Controller
    {
        private readonly ISalesRepository _salesRepository;

        public SaleManagementController(ISalesRepository salesRepository)
        {
            _salesRepository = salesRepository;
        }

        [HttpGet]
        public IActionResult AddOffer()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddOffer(Sale sale)
        {
            if (ModelState.IsValid)
            {
                _salesRepository.AddOffer(sale);
                return RedirectToAction("OfferList");
            }
            return View(sale);
        }

        public IActionResult OfferList()
        {
            var sales = _salesRepository.GetAllSales();
            return View(sales);
        }

        [HttpGet]
        public IActionResult UpdateOffer(int listingNumber)
        {
            var sale = _salesRepository.GetSaleByListingNumber(listingNumber);
            if (sale == null)
            {
                return NotFound();
            }
            return View(sale);
        }

        [HttpPost]
        public IActionResult UpdateOffer(Sale sale)
        {
            if (ModelState.IsValid)
            {
                _salesRepository.UpdateOffer(sale);
                return RedirectToAction("OfferList");
            }
            return View(sale);
        }

        [HttpGet]
        public IActionResult DeleteOffer(int listingNumber)
        {

            var sale = _salesRepository.GetSaleByListingNumber(listingNumber);
            if (sale == null)
            {
                return NotFound();
            }
            _salesRepository.DeleteOffer(sale);
            return RedirectToAction("OfferList");
        }
    }
}
