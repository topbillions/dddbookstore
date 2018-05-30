namespace bookstore.utils
{
    /// <summary>
    /// Object 对象辅助类型
    /// </summary>
    public static class ObjectUtils
    {
        /// <summary>
        /// 对象是否为 null
        /// </summary>
        /// <param name="source"></param>
        /// <returns></returns>
        public static bool isNull(this object source){
            return null == source;
        }

        /// <summary>
        /// 对象是否不为 null
        /// </summary>
        /// <param name="source"></param>
        /// <returns></returns>
        public static bool isNotNull(this object source){
            if(source.isNull()){
                return false;
            }

            return true;
        }
    }
}