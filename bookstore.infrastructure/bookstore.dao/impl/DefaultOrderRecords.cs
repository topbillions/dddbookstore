namespace bookstore.dao.impl
{
    using entity;

    /// <summary>
    /// 默认订单数据集实现
    /// </summary>
    public class DefaultOrderRecords : OrderRecords
    {
        public int close(OrderEntity entity)
        {
            return 1;
        }

        public int store(OrderEntity entity)
        {
            return 1;
        }
    }
}