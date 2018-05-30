namespace bookstore.core.repo
{
    using model;

    /// <summary>
    /// 用户数据仓储
    /// </summary>
    public interface UserRepository
    {
        /// <summary>
        /// 保存用户
        /// </summary>
        /// <param name="user"></param>
         void store(User user);

         /// <summary>
         /// 查询指定名称的用户
         /// </summary>
         /// <param name="name"></param>
         /// <returns></returns>
         User lookup(UserName name);
    }
}