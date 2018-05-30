namespace bookstore.core.except
{
    using System;

    /// <summary>
    /// 业务异常
    /// </summary>
    public class BizException : Exception
    {
        public BizException(string message) 
            : base(message){ }

        public static void throwError(string message){
            throw new BizException(message);
        }
    }
}