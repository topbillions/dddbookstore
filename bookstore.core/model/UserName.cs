namespace bookstore.core.model
{
    using except;
    using utils;
    using validation;

    /// <summary>
    /// 用户名称
    /// </summary>
    public class UserName : Validatable
    {
        public UserName(string name){
            this.Name = name;
        }

        public string Name { get; private set; }

        public bool isValid()
        {
            return this.Name.isNullOrEmpty();
        }

        public void verify()
        {
            if(this.Name.isNullOrEmpty()){
                BizException.throwError("user name is invaliable .");
            }
        }
    }
}