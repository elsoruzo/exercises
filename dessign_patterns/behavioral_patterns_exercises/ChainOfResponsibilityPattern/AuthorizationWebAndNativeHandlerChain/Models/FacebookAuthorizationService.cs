namespace AuthorizationWebAndNativeHandlerChain.Models
{
    using System;
    class FacebookAuthorizationService : IFacebookAuthorizationService
    {
        public bool CheckEmailInFacebook(IAutorizationModel authModel)
        {
            if (authModel.Login == "yakov@facebook.com" && authModel.Password == "12345678")
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
