namespace ChainOfResponsibilityModel
{

    /// <summary>
    /// Поведение цепочки по умолчанию может быть реализовано внутри базового
    /// класса обработчика.
    /// </summary>
    abstract class AbstractHandler : IHandler
    {
        private IHandler _nextHandler;

        /// <summary>
        /// 
        /// Возврат обработчика отсюда позволит связать обработчики простым
        /// способом, вот так:
        /// monkey.SetNext(squirrel).SetNext(dog);
        /// </summary>
        /// <param name="handler"></param>
        /// <returns></returns>
        public IHandler SetNext(IHandler handler)
        {
            this._nextHandler = handler;

            return handler;
        }

        public virtual object Handle(object request)
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
