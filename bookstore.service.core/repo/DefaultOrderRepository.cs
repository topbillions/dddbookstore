namespace bookstore.service.core.repo
{
    using bookstore.core.except;
    using bookstore.core.model;
    using bookstore.core.repo;
    using bookstore.dao;
    using bookstore.dao.entity;
    using bookstore.dao.impl;

    /// <summary>
    /// 默认订单仓储实现
    /// </summary>
    public class DefaultOrderRepository : OrderRepository
    {
        private OrderRecords records = new DefaultOrderRecords();

        public void close(Order order)
        {
            OrderEntity entity = toEntity(order);
            if(0 >= records.close(entity)){
                BizException.throwError("fail to close specify order .");
            }
        }

        public void store(Order order)
        {
            OrderEntity entity = toEntity(order);
            if(0 >= records.store(entity)){
                BizException.throwError("fail to store specify order .");
            }
        }

        private OrderEntity toEntity(Order order){
            return null;
        }
    }
}