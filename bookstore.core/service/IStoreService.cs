namespace bookstore.core.service
{
    using model;

    /// <summary>
    /// 书店服务
    /// </summary>
    public interface IStoreService
    {
        Book lookup(string number);
    }
}