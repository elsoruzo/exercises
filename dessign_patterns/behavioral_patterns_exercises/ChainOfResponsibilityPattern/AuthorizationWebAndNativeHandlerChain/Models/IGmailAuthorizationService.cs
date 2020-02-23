namespace AuthorizationWebAndNativeHandlerChain.Models
{
    interface IGmailAuthorizationService
    {
        bool CheckEmailInGmail(IAutorizationModel authModel);
    }
}