namespace AuthorizationWebAndNativeHandlerChain.Models
{
    using System;
    class GmailAuthorizationHandler : IHandler
    {
        private IHandler _nextHandler;
        public IHandler SetNext(IHandler handler)
        {
            this._nextHandler = handler;

            return handler;
        }
        public IAutorizationModel Handle(IAutorizationModel request)
        {
            if (request.Login.Contains("gmail"))
            {
                Console.WriteLine($"GmailAuthorizationHandler handeled the autorization of {request.Login}.\n");
                _ = new GmailAuthorizationService().CheckEmailInGmail(request);
                return request;
            }
            else
            {
                Console.WriteLine($"GmailAuthorizationHandler didn't handele the autorization of {request.Login}.\n");
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
