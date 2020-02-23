namespace AuthorizationWebAndNativeHandlerChain.Models
{
    public interface IHandler
    {
        IHandler SetNext(IHandler handler);

        IAutorizationModel Handle(IAutorizationModel request);
    }
}
