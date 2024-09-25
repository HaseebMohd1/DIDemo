namespace DIDemo.Services;

public class ServiceBusQueueService : IQueueService
{
    public string GetQueueInfo()
    {
        return "Service Bus Queue";
    }
}
