using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _0415_.NetCoreSKA.Repos;
using _0415_.NetCoreSKA.Service;

namespace _0415_.NetCoreSKA.Controllers
{
    public class PhoneController : Controller
    {
        private readonly IPhoneRepo _phoneRepo;
        private readonly ICartService _cartService;
        
        public PhoneController(IPhoneRepo phoneRepo, ICartService cartService)
        {
            _phoneRepo = phoneRepo;
            _cartService = cartService;
        }
        public IActionResult Index()
        {
            var phones = _phoneRepo.GetPhones();
            return View("Phone",phones);
        }
        //ctrl+shift+r
        public IActionResult Purchase(int id)
        {
            var phoneById = _phoneRepo.GetPhoneById(id);
            _cartService.Purchase(phoneById);
            return RedirectToAction("Index", "Cart");
        }
    }
}
