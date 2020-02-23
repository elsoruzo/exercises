namespace AuthorizationWebAndNativeHandlerChain.Models
{
    interface INativeAuthorizationService
    {
        bool CheckEmailInDb(IAutorizationModel authModel);
        bool CheckPhoneInDb(IAutorizationModel authModel);
    }
}