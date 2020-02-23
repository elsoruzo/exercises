namespace AuthorizationWebAndNativeHandlerChain.Models
{
    using System;
    class GmailAuthorizationService : IGmailAuthorizationService
    {
        public bool CheckEmailInGmail(IAutorizationModel authModel)
        {
            if (authModel.Login == "yakov@gmail.com" && authModel.Password == "12345678")
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
