namespace bookstore.dao
{
    using entity;

    /// <summary>
    /// 数据库订单数据集
    /// </summary>
    public interface OrderRecords
    {
        /// <summary>
        /// 保存订单数据
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        int store(OrderEntity entity);

        /// <summary>
        /// 关闭订单
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        int close(OrderEntity entity); 
    }
}