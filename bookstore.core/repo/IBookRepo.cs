namespace bookstore.core.repo
{
    using model;

    /// <summary>
    /// 书籍仓储
    /// </summary>
    public interface IBookRepo
    {
        Book[] fetchAll();
    }
}