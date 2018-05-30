namespace bookstore.core.service
{
    using model;

    /// <summary>
    /// 书店
    /// </summary>
    public interface StoreService
    {
        /// <summary>
        /// 书店名称
        /// </summary>
        /// <returns></returns>
        string Name { get; }

        /// <summary>
        /// 查询任意一本书
        /// </summary>
        /// <returns></returns>
        Book lookupAnyone();

        /// <summary>
        /// 用户进入
        /// </summary>
        /// <param name="user"></param>
        void entry(User user);

        /// <summary>
        /// 用户离开
        /// </summary>
        /// <param name="user"></param>
        void quit(User user);
    }
}