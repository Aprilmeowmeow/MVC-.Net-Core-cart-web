using System.Collections.Generic;
using _0415_.NetCoreSKA.Models;

namespace _0415_.NetCoreSKA.Repos
{
    public interface IPhoneRepo
    {
        IEnumerable<Phone> GetPhones();
        Phone GetPhoneById(int id);
    }
}