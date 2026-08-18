public class DeliveryService
{
    public void Deliver(string type)
    {
        if (type == "standard")
        {
            Console.WriteLine("Standard delivery");
        }
        else if (type == "express")
        {
            Console.WriteLine("Express delivery");
        }
        else if (type == "same-day")
        {
            Console.WriteLine("Same-day delivery");
        }
        //if else???
    }
}