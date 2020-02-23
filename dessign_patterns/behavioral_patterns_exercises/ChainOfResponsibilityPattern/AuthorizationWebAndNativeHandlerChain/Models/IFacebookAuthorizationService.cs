namespace AuthorizationWebAndNativeHandlerChain.Models
{
    interface IFacebookAuthorizationService
    {
        bool CheckEmailInFacebook(IAutorizationModel authModel);
    }
}