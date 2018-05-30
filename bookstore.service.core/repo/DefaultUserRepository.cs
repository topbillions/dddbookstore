namespace bookstore.service.core.repo
{
    using bookstore.core.except;
    using bookstore.core.model;
    using bookstore.core.repo;
    using bookstore.dao;
    using bookstore.dao.entity;
    using bookstore.dao.impl;
    using bookstore.utils;

    /// <summary>
    /// 用户仓储默认实现
    /// </summary>
    public class DefaultUserRepository : UserRepository
    {
        private UserRecords records = new DefaultUserRecords();

        public User lookup(UserName name)
        {
            UserEntity entity = records.lookup(name.Name);
            if(entity.isNull()){
                BizException.throwError("specify user name no found .");
            }
            return toModel(entity);
        }

        public void store(User user)
        {
            UserEntity entity = toEntity(user);
            if(0 >= records.store(entity)){
                BizException.throwError("fail to store specify user .");
            }
        }

        private UserEntity toEntity(User user){
            return new UserEntity { Name = user.Name.Name };
        }

        private User toModel(UserEntity entity){
            UserName name = new UserName(entity.Name);
            return new User(name);
        }
    }
}