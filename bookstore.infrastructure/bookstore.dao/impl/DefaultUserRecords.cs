namespace bookstore.dao.impl
{
    using entity;

    /// <summary>
    /// 默认用户数据集实现
    /// </summary>
    public class DefaultUserRecords : UserRecords
    {
        public UserEntity lookup(string name)
        {
            return new UserEntity { Name = name };
        }

        public int store(UserEntity entity)
        {
            return 1;
        }
    }
}