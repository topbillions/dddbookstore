namespace bookstore.core.except
{
    using System;

    /// <summary>
    /// 业务异常
    /// </summary>
    public class BizException : Exception
    {
        public int StatusCode { get; }
    }
}