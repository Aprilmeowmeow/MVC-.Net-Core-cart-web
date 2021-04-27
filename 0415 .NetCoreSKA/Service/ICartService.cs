using System.Collections.Generic;
using _0415_.NetCoreSKA.Models;

namespace _0415_.NetCoreSKA.Service
{
    public interface ICartService
    {
        IEnumerable<Phone> GetPhones();
        void Purchase(Phone phone);
        void Delete(Phone phone);
    }
}