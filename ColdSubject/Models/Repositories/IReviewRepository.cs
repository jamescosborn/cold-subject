using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ColdSubject.Models
{
    public interface IProductRepository
    {
        IQueryable<Review> Reviews { get; }
        Review Save(Review review);
        Review Edit(Review review);
        void Remove(Review review);

        IQueryable<Product> Products { get; }
        Product Save(Product product);
        Product Edit(Product product);
        void Remove(Product product);
    }
}
