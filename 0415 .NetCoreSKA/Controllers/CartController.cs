using Microsoft.AspNetCore.Mvc;
using _0415_.NetCoreSKA.Repos;
using _0415_.NetCoreSKA.Service;
using Microsoft.AspNetCore.Mvc.Formatters.Xml;
using System.Linq;

namespace _0415_.NetCoreSKA.Controllers
{
    public class CartController : Controller
    {
        private readonly IPhoneRepo _phoneRepo;
        private readonly ICartService _cartService;
        
        public CartController(IPhoneRepo phoneRepo, ICartService cartService)
        {
            _phoneRepo = phoneRepo;
            _cartService = cartService;
        }

        public IActionResult Index()
        {
            var phones = _cartService.GetPhones();
            return View("Cart",phones);
        }

        public IActionResult Delete(int id)
        {
            var phone = _cartService.GetPhones();
            var phoneItem = phone.FirstOrDefault(o => o.Id == id);
            _cartService.Delete(phoneItem);
            return View("Cart", phone);
        }
    }
}
