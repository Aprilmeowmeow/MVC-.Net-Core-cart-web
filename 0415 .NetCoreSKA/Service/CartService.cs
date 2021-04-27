using System.Collections.Generic;
using System.ComponentModel;
using _0415_.NetCoreSKA.Models;


namespace _0415_.NetCoreSKA.Service
{
    public class CartService : ICartService
    {
		private readonly List<Phone> _myPhones = new List<Phone>();

        public IEnumerable<Phone> GetPhones()
        {
            return _myPhones;
        }

        public void Purchase(Phone phone)
        {
            _myPhones.Add(phone);
        }

        public void Delete(Phone phone)
        {
            _myPhones.Remove(phone);
        }
    }
}
