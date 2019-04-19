
using SportsStore.Domain.Entities;

namespace SportsStore.Domain.Abstract
{
    //Work being done behind scenes; Cleaner code
    public interface IOrderProcessor 
    {

        void ProcessOrder(Cart cart, ShippingDetails shippingDetails);
    }
}