using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pizza_TeamVit.Models
{
    public interface IStoreRepository
    {
        IQueryable<Product> Products { get; }
    }
}
