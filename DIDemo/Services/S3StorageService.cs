namespace DIDemo.Services;

public class S3StorageService : IStorageService
{
    public string GetStorageInfo()
    {
        return "S3 Storage";
    }
}
