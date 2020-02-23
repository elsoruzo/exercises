namespace AuthorizationWebAndNativeHandlerChain.Models
{
    using System;
    using System.Linq;
    class NativePhoneAuthorizationHandler : IHandler
    {
        private IHandler _nextHandler;
        public IHandler SetNext(IHandler handler)
        {
            this._nextHandler = handler;

            return handler;
        }
        public IAutorizationModel Handle(IAutorizationModel request)
        {
            if (!request.Login.Any(c => char.IsLetter(c)))
            {
                Console.WriteLine($"NativePhoneAuthorizationHandler handeled the autorization of {request.Login}.\n");
                _ = new NativeAuthorizationService().CheckPhoneInDb(request);
                return request;
            }
            else
            {
                Console.WriteLine($"NativePhoneAuthorizationHandler didn't handele the autorization of {request.Login}.\n");
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
