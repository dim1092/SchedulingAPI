namespace SchedulinAPI.Models.Interfaces;

public interface IBookable
{
    long Id {  get; }
    String Name { get; }
    User Owner { get; }
}
