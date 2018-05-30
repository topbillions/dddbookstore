namespace bookstore.dao
{
    using entity;
    
    /// <summary>
    /// 数据库用户数据集
    /// </summary>
    public interface UserRecords
    {
        /// <summary>
        /// 保存用户
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
         int store(UserEntity entity);

         /// <summary>
         /// 查询指定名称的用户
         /// </summary>
         /// <param name="name"></param>
         /// <returns></returns>
         UserEntity lookup(string name);
    }
}