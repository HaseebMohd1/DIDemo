namespace DIDemo.Services;

public class SQSService : IQueueService
{
    public string GetQueueInfo()
    {
        return "SQS Queue";
    }
}
