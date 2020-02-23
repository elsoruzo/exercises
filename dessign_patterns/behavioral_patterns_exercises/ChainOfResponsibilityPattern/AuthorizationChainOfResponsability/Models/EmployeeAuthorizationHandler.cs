namespace ChainOfResponsibilityModel
{
    class EmployeeAuthorizationHandler : IHandler
    {
        private IHandler _nextHandler;
        public IHandler SetNext(IHandler handler)
        {
            this._nextHandler = handler;

            return handler;
        }
        public string Handle(string request)
        {
            if (request == "Employee")
            {
                return $"EmployeeAuthorizationHandler handeled the autorization of {request}.\n";
            }
            else
            {
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
