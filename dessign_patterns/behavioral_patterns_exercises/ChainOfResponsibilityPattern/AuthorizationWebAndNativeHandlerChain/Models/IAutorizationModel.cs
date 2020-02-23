namespace AuthorizationWebAndNativeHandlerChain.Models
{
    public interface IAutorizationModel
    {
        string Login { get; set; }
        string Password { get; set; }
    }
}