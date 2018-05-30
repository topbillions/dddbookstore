namespace bookstore.core.service
{
    using model;

    /// <summary>
    /// 购书篮
    /// </summary>
    public interface BasketService
    {
        /// <summary>
        /// identity
        /// </summary>
        /// <returns></returns>
        string id { get; }

        /// <summary>
        /// 增加书籍
        /// </summary>
        /// <param name="book"></param>
        void addition(Book book);

        /// <summary>
        /// 移除书籍
        /// </summary>
        /// <param name="book"></param>
        void remove(Book book);

        /// <summary>
        /// 清除所有的书籍
        /// </summary>
        void clear();

        /// <summary>
        /// 查看书籍
        /// </summary>
        /// <returns></returns>
        Book[] view();
    }
}