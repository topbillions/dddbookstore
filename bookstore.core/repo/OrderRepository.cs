namespace bookstore.core.repo
{
    using model;

    /// <summary>
    /// 订单仓储
    /// </summary>
    public interface OrderRepository
    {
        /// <summary>
        /// 保存订单
        /// </summary>
        /// <param name="order"></param>
         void store(Order order);

         /// <summary>
         /// 关闭订单
         /// </summary>
         /// <param name="order"></param>
         void close(Order order);
    }
}