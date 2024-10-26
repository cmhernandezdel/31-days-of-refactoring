using Shared;

namespace Refactoring.EncapsulateCollection;

public sealed class Order : Entity
{
    private Order(Guid id) : base(id)
    {
        
    }

    public static Order Create()
    {
        var id = Guid.NewGuid();
        return new Order(id);
    }
}