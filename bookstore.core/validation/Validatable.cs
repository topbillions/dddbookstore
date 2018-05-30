namespace bookstore.core.validation
{
    /// <summary>
    /// 可验证支持
    /// </summary>
    public interface Validatable
    {
        /// <summary>
        /// 校验，若无效抛出 <see bookstore.core.except.BizException />
        /// </summary>
         void verify();

         /// <summary>
         /// 是否有效
         /// </summary>
         /// <returns></returns>
         bool isValid();
    }
}