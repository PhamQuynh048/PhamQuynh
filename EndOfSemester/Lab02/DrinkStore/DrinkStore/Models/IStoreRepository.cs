using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DrinkStore.Models
{
    public class IStoreRepository
    {
        IQueryable<Product> Products { get; }
    }
}
