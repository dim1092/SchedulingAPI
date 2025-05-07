using SchedulinAPI.Models;
using SchedulinAPI.Models.Interfaces;

namespace SchedulinAPI.Services.Interfaces;

public interface IShopService
{
    /// <summary>
    /// Get the list of IBookable (services, activities...) the shop provides
    /// </summary>
    /// <param name="shop">The shop providing the IBookables</param>
    /// <returns>List of IBookables</returns>
    /// </summary>
    public List<IBookable> GetBookables();


    /// <summary>
    /// Add a user as staff to the shop
    /// </summary>
    /// <param name="staff">The user to be added</param>
    public void AddStaff(ProUser staff);

    /// <summary>
    /// Remove staff from shop. The shop and activities owned by the shop are removed from the staff to keep data integrity
    /// </summary>
    /// <param name="staff">Staff to be removed</param>
    public void RemoveStaff(ProUser staff);
}
