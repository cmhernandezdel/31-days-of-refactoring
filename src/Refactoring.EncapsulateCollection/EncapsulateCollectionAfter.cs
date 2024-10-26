namespace Refactoring.EncapsulateCollection;

public sealed class EncapsulateCollectionAfter
{
    private readonly List<Order> _orders;
    
    public IEnumerable<Order> Orders => _orders;

    public void AddOrder(Order order)
    {
        _orders.Add(order);
    }

    public void RemoveOrder(Order order)
    {
        var found = _orders.Find(o => o == order);
        if (found is not null)
        {
            _orders.Remove(found);
        }
    }
}