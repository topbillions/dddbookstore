namespace bookstore.core.model
{
    using service;
    using validation;

    /// <summary>
    /// 用户
    /// @author 小木 ian.zh.fang@gmail.com
    /// </summary>
    public class User : Validatable
    {
        private BasketService basket;
        private StoreService store;

        public User(UserName name){
            this.Name = name;
        }

        public User entry(StoreService store){
            this.store = store;
            this.store.entry(this);
            return this;
        }

        public User selectBook(){
            Book book = this.store.lookupAnyone();
            this.basket.addition(book);
            return this;
        }

        public void quit(){
            this.store.quit(this);
            this.store = null;
        }

        public bool isValid()
        {
            throw new System.NotImplementedException();
        }

        public void verify()
        {
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// 用户姓名
        /// </summary>
        /// <returns></returns>
        public UserName Name { get; private set; }     
    }
}