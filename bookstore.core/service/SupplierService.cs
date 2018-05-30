namespace bookstore.core.service
{
    using model;

    /// <summary>
    /// 书籍供货商
    /// </summary>
    public interface SupplierService
    {
        /// <summary>
        /// 供货商名称
        /// </summary>
        /// <returns></returns>
        string Name { get; }

        /// <summary>
        /// 生产书籍
        /// </summary>
        /// <returns></returns>
         Book instanceBook();

         /// <summary>
         /// 供应书籍
         /// </summary>
         /// <returns></returns>
         Book[] supply();
    }
}