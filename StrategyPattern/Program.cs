internal class Program
{
    private static void Main(string[] args)
    {
        var service = new DeliveryService();
        service.Deliver("express");


        IDeliveryStrategy deliveryStrategy;

        bool isExpress = false;

        if (isExpress)
        {
            deliveryStrategy = new ExpressDelivery();
        }
        else
        {
            deliveryStrategy = new DroneDelivery();
        }


        var strategyService = new DeliveryStrategyService(deliveryStrategy);

        strategyService.Deliver();

    }
}

public interface IDeliveryStrategy
{
    void Deliver();
}

public class DroneDelivery : IDeliveryStrategy
{
    public void Deliver()
    {
        Console.WriteLine("Drone strategy delivery");
    }
}
public class StandartDelivery : IDeliveryStrategy
{
    public void Deliver()
    {
        Console.WriteLine("Standart strategy delivery");
    }
}

public class ExpressDelivery : IDeliveryStrategy
{
    public void Deliver()
    {
        Console.WriteLine("Express strategy delivery");
    }
}

public class SameDayDelivery : IDeliveryStrategy
{
    public void Deliver()
    {
        Console.WriteLine("Sameday strategy delivery");
    }
}

public class DeliveryStrategyService
{
    private readonly IDeliveryStrategy _strategy;


    public DeliveryStrategyService(IDeliveryStrategy strategy)
    {
        _strategy = strategy;
    }

    public void Deliver()
    {
        _strategy.Deliver();
    }
}