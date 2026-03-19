using NWService.Dal.EntityClasses;

namespace TestProject1;

public class Tests
{
    [Test]
    public void Test1()
    {
        var order = new OrderEntity()
        {
            ActiveContext = new SD.LLBLGen.Pro.ORMSupportClasses.Context()
        };

        var detail = new OrderDetailEntity();

        order.OrderDetails.Add(detail);
        order.OrderDetails.Add(detail);

        Assert.That(order.OrderDetails.Count, Is.EqualTo(1));
    }

    [Test]
    public void Test2()
    {
        var order = new OrderEntity()
        {
            ActiveContext = new SD.LLBLGen.Pro.ORMSupportClasses.Context()
        };

        var detail = new OrderDetailEntity()
        {
            Order = order
        };

        order.OrderDetails.Add(detail);

        Assert.That(order.OrderDetails.Count, Is.EqualTo(1));
    }
}
