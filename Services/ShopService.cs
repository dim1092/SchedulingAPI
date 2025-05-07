using SchedulinAPI.Models;
using SchedulinAPI.Models.Interfaces;

namespace SchedulinAPI.Services.Interfaces;

public class ShopService : IShopService
{
    public Shop Shop { get; }
    
    public ShopService(Shop shop)
    {
        Shop = shop;
    }

    /// <inheritdoc />
    public List<IBookable> GetBookables()
    {
        return Shop.Bookables;
    }

    /// <inheritdoc />
    public void AddStaff(ProUser staff)
    {
        Shop.Staff.Add(staff);
    }

    /// <inheritdoc />
    public void RemoveStaff(ProUser staff)
    {
        Shop.Staff.Remove(staff);
    }
}
