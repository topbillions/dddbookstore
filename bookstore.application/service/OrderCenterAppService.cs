namespace bookstore.application.service
{
    using core.model;
    using core.repo;
    using utils;

    /// <summary>
    /// 订单中心应用服务
    /// </summary>
    public sealed class OrderCenterAppService
    {
        private static readonly object locker = new object();
        private static OrderCenterAppService instance;

        public static OrderCenterAppService defaultSevice(){
            if(instance.isNull()){
                lock (locker)
                {
                    if(instance.isNull()){
                        OrderRepository repo = null;
                        instance = new OrderCenterAppService(repo);
                    }
                }
            }
            return instance;
        }

        // 订单仓储
        private OrderRepository orderRepo;

        public OrderCenterAppService(OrderRepository repo){
            this.orderRepo = repo;
        }

        /// <summary>
        /// 创建新的订单
        /// </summary>
        /// <param name="User"></param>
        /// <param name="books"></param>
        /// <returns></returns>
        public Order makeOrder(User user, Book[] books){
            Order order = new Order(user, books);
            orderRepo.store(order);
            return order;
        }
    }
}