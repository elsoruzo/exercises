namespace AuthorizationWebAndNativeHandlerChain.Models
{
    using System;
    class FacebookAuthorizationHandler : IHandler
    {
        private IHandler _nextHandler;
        public IHandler SetNext(IHandler handler)
        {
            this._nextHandler = handler;

            return handler;
        }
        public IAutorizationModel Handle(IAutorizationModel request)
        {
            if (request.Login.Contains("facebook"))
            {
                Console.WriteLine($"FacebookAuthorizationHandler handeled the autorization of {request.Login}.\n");
                _ = new FacebookAuthorizationService().CheckEmailInFacebook(request);
                return request;
            }
            else
            {
                Console.WriteLine($"FacebookAuthorizationHandler didn't handele the autorization of {request.Login}.\n");
                if (this._nextHandler != null)
                {
                    return this._nextHandler.Handle(request);
                }
                else
                {
                    return null;
                }
            }
        }
    }
}
