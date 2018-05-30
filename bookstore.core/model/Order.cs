namespace bookstore.core.model
{
    using validation;

    /// <summary>
    /// 订单
    /// </summary>
    public class Order : Validatable
    {
        public Order(User user, params Book[] books){
            
        }

        public bool isValid()
        {
            throw new System.NotImplementedException();
        }

        public void verify()
        {
            throw new System.NotImplementedException();
        }
    }
}