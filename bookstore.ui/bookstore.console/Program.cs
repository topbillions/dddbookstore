namespace bookstore.console
{
    using application.service;
    using core.model;
    using core.service;

    using System;

    class Program
    {
        static void Main(string[] args)
        {
            // 注册
            const string name = "anonymouse";
            UserAppService userAppService = new UserAppService();
            userAppService.signUp(name);
            User user = userAppService.signIn(name);
            // 寻找书店
            var store = (new StoreAppService()).lookupAnyone();
            // 进入书店
            user.entry(store);
            // 找书
            user.selectBook();
            // 
        }
    }
}
