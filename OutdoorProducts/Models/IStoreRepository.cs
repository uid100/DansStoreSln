using System.Linq;


namespace OutdoorProducts.Models
{
    public interface IStoreRepository
    {
        IQueryable<Product> Products { get; }
    }
}
