using SchedulinAPI.Models;
using SchedulinAPI.Models.Interfaces;

namespace SchedulinAPI.Services.Interfaces;

public interface IProUserService : IUserService
{
    /// <summary>
    /// Add a Bookable the user can perform. The Bookable must exist in a shop the user works at
    /// </summary>
    /// <param name="bookable">The Bookable the user can perform</param>
    public bool AddBookable(IBookable bookable);

    /// <summary>
    /// Return the list of Bookables the user can perform
    /// </summary>
    /// <returns>list of Bookables the user can perform</returns>
    public List<IBookable> GetBookables();

    /// <summary>
    /// Remove a Bookable a user can perform
    /// </summary>
    /// <param name="bookable">The Bookable to remove</param>
    public void RemoveBookable(IBookable bookable);


    /// <summary>
    /// Add a Shop to the owned shops of the user
    /// </summary>
    /// <param name="shop">The Shop to be Added</param>
    public void AddOwnedShop(Shop shop);

    /// <summary>
    /// Remove an owned shop from user list. Remove the shop from the staff aswell to keep data consistency
    /// </summary>
    /// <param name="shop">The shop to be remove</param>
    public void RemoveOwnedShop(Shop shop);

    /// <summary>
    /// Return the list of owned shops
    /// </summary>
    /// <returns>List of owned shops</returns>
    public List<Shop>GetOwnedShop();

    /// <summary>
    /// Add a shop where the user works at
    /// </summary>
    /// <param name="worksAt">The shop to add</param>
    public void AddWorksAt(Shop worksAt);

    /// <summary>
    /// Remove shop where the user works at
    /// </summary>
    /// <param name="worksAt">Shop to be removed</param>
    public void RemoveWorksAt(Shop worksAt);
}
