namespace AuthorizationWebAndNativeHandlerChain.Models
{
    using System;

    class NativeAuthorizationService : INativeAuthorizationService
    {
        public bool CheckEmailInDb(IAutorizationModel authModel)
        {
            if (authModel.Login == "yakov@email.com" && authModel.Password == "12345678")
            {
                Console.WriteLine($"{authModel.Login} is Authorized");
                return true;
            }
            else
            {
                Console.WriteLine($"{authModel.Login} is not Authorized");
                return false;
            }
        }

        public bool CheckPhoneInDb(IAutorizationModel authModel)
        {
            if (authModel.Login == "+0 930 987 39 20" && authModel.Password == "12345678")
            {
                Console.WriteLine($"{authModel.Login} is Authorized");
                return true;
            }
            else
            {
                Console.WriteLine($"{authModel.Login} is not Authorized");
                return false;
            }
        }
    }
}
