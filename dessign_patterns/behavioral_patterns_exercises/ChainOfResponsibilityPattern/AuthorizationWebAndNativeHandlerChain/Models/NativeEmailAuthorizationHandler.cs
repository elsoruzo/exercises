namespace AuthorizationWebAndNativeHandlerChain.Models
{
    using System;
    class NativeEmailAuthorizationHandler : IHandler
    {
        private IHandler _nextHandler;
        public IHandler SetNext(IHandler handler)
        {
            this._nextHandler = handler;

            return handler;
        }
        public IAutorizationModel Handle(IAutorizationModel request)
        {
            if (request.Login.Contains("email"))
            {
                Console.WriteLine($"NativeEmailAuthorizationHandler handeled the autorization of {request.Login}.\n");
                _ = new NativeAuthorizationService().CheckEmailInDb(request);
                return request;
            }
            else
            {
                Console.WriteLine($"NativeEmailAuthorizationHandler didn't handele the autorization of {request.Login}.\n");
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
