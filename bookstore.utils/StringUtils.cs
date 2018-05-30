namespace bookstore.utils
{
    /// <summary>
    /// String 辅助类
    /// </summary>
    public static class StringUtils
    {
        public static bool isNullOrEmpty(this string source){
            if(source.isNull()){
                return true;
            }

            return source.Equals(string.Empty);
        }
    }
}