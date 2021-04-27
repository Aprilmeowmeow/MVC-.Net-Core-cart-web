using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _0415_.NetCoreSKA.Models;
using Microsoft.AspNetCore.Identity;

namespace _0415_.NetCoreSKA.Repos
{
    public class PhoneRepo : IPhoneRepo
    {
        private readonly List<Phone> _phones = new()
        {
            new Phone
            {
                Id= 0,
                Img= "iphone12 Pro Max",
                Brand= "iphone12 Pro Max",
                InchSize= "6.7",
                Price= 37900
            },
            new Phone
            {
                Id= 1,
                Img= "iphone12 Pro",
                Brand= "iphone12 Pro",
                InchSize= "6.1",
                Price= 33900
            },
            new Phone
            {
                Id= 2,
                Img= "iphone12",
                Brand= "iphone12",
                InchSize= "6.1",
                Price= 26900
            },
            new Phone
            {
                Id= 3,
                Img= "iphone11",
                Brand= "iphone11",
                InchSize= "6.1",
                Price= 19900,
            },
            new Phone
            {
                Id= 4,
                Img= "iphoneXR",
                Brand= "iphoneXR",
                InchSize= "6.1",
                Price= 16900
            },
        };

        public IEnumerable<Phone> GetPhones()
        {
            return _phones;
        }

        public Phone GetPhoneById(int id)
        {
            return _phones.FirstOrDefault(x => x.Id == id);
        }
    }

}

